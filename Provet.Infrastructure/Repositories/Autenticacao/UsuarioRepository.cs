using Microsoft.EntityFrameworkCore;
using Provet.Domain.Interfaces.Autenticacao;
using Provet.Entities.Entities;
using Provet.Infrastructure.Configuration;
using Provet.Infrastructure.Repositories.Generic;

namespace Provet.Infrastructure.Repositories.Autenticacao
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuario
    {
        private readonly DbContextOptions<ContextBase> _dbContextOptions;

        public UsuarioRepository()
        {
            _dbContextOptions = new DbContextOptions<ContextBase>();
        }

        public async Task<bool> JaCadastrado(string usuario)
        {
            using (var banco = new ContextBase(_dbContextOptions))
            {
                var usuarioBanco = await banco.Usuarios.FirstOrDefaultAsync(r => r.NomeUsuario == usuario);

                if (usuarioBanco != null)
                    return true;
                else
                    return false;
            }
        }

        public async Task<Usuario> Login(string usuario, string senha)
        {
            using var banco = new ContextBase(_dbContextOptions);
            Usuario? result = null;

            var usuarioBanco = await banco.Usuarios.FirstOrDefaultAsync(u => u.NomeUsuario == usuario);

            if (usuarioBanco != null)
            {
                var passwordVerified = BCrypt.Net.BCrypt.Verify(senha, usuarioBanco.Senha);

                if (passwordVerified != false)
                {
                    result = new Usuario
                    { 
                        Id = usuarioBanco.Id,
                        Nome = usuarioBanco.Nome,
                        NomeUsuario = usuarioBanco.NomeUsuario,
                        //PerfilId = usuarioBanco.PerfilId,
                        CriadoEm = usuarioBanco.CriadoEm,
                        AtualizadoEm = usuarioBanco.AtualizadoEm
                    };

                    return result;
                }
            }

            return result;
        }
    }
}
