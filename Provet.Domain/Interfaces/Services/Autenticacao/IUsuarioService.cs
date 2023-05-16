using Provet.Entities.Entities;

namespace Provet.Domain.Interfaces.Services.Autenticacao
{
    public interface IUsuarioService
    {
        Task Adicionar(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task<Usuario> BuscarPorId(int id);
        Task Deletar(Usuario usuario);
        Task<List<Usuario>> ListarTodos();
        Task<bool> JaCadastrado(string usuario);
        Task<Usuario> Login(string usuario, string senha);
    }
}
