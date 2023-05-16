using MediatR;
using Microsoft.EntityFrameworkCore;
using Nest;
using Provet.Domain;
using Provet.Domain.Interfaces.Autenticacao;
using Provet.Domain.Interfaces.Generics;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services.Autenticacao;
using Provet.Domain.Interfaces.Services.Responsaveis;
using Provet.Domain.Services.Autenticacao;
using Provet.Domain.Services.Responsaveis;
using Provet.Infrastructure.Configuration;
using Provet.Infrastructure.Repositories.Autenticacao;
using Provet.Infrastructure.Repositories.Generic;
using Provet.Infrastructure.Repositories.Responsaveis;

namespace Provet.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = configBuilder.Build();

            var connectionString = _configuration.GetConnectionString("Postgres");

            // Add services to the container.
            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ContextBase>(opt => opt.UseNpgsql(connectionString));

            // Config Interface e Repo
            builder.Services.AddSingleton(typeof(IGeneric<>), typeof(GenericRepository<>));
            builder.Services.AddSingleton<IResponsavel, ResponsavelRepository>();
            builder.Services.AddSingleton<IPerfil, PerfilRepository>();
            builder.Services.AddSingleton<IUsuario, UsuarioRepository>();

            // Config Domain
            builder.Services.AddSingleton<IResponsavelService, ResponsavelService>();
            builder.Services.AddSingleton<IPerfilService, PerfilService>();
            builder.Services.AddSingleton<IUsuarioService, UsuarioService>();

            // Elastic Search
            var uri = _configuration.GetSection("ElasticSearchSettings").GetSection("Uri").Value;
            var defaultIndex = _configuration.GetSection("ElasticSearchSettings").GetSection("DefaultIndex").Value;
            
            var settings = new ConnectionSettings(new Uri(uri));

            if(!string.IsNullOrEmpty(defaultIndex))
            {
                settings = settings.DefaultIndex(defaultIndex);
            }

            var client = new ElasticClient(settings);

            builder.Services.AddSingleton<IElasticClient>(client);

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddMediatR(typeof(DomainEntryPoint).Assembly);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}