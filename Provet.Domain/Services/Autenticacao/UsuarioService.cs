using Provet.Domain.Interfaces.Autenticacao;
using Provet.Domain.Interfaces.Services.Autenticacao;
using Provet.Entities.Entities;

namespace Provet.Domain.Services.Autenticacao
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuario _usuario;

        public UsuarioService(IUsuario usuario)
        {
            _usuario = usuario;
        }

        public async Task<List<Usuario>> ListarTodos()
        {
            return await _usuario.GetAll();
        }

        public async Task Adicionar(Usuario usuario)
        {
            usuario.CriadoEm = DateTime.UtcNow;
            var hashPassword = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            usuario.Senha = hashPassword;
            await _usuario.Add(usuario);
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _usuario.GetEntityById(id);
        }

        public async Task Atualizar(Usuario usuario)
        {
            usuario.AtualizadoEm = DateTime.UtcNow;
            await _usuario.Update(usuario);
        }

        public async Task Deletar(Usuario usuario)
        {
            await _usuario.Delete(usuario);
        }

        public async Task<Usuario> Login(string usuario, string senha)
        {
            return await _usuario.Login(usuario, senha);
        }

        public async Task<bool> JaCadastrado(string usuario)
        {
            return await _usuario.JaCadastrado(usuario);
        }
    }
}
