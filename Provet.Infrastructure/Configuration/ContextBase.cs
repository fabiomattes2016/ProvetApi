using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Provet.Entities.Entities;

namespace Provet.Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfiguration _configuration = configBuilder.Build();

                var connectionString = _configuration.GetConnectionString("Postgres");

                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        public DbSet<Responsavel> Responsaveis { get; set; }
    }
}
