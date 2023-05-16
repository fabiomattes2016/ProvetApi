using Provet.Entities.Entities;

namespace Provet.Domain.Interfaces.Services.Autenticacao
{
    public interface IPerfilService
    {
        Task Adicionar(Perfil perfil);
        Task Atualizar(Perfil perfil);
        Task<Perfil> BuscarPorId(int id);
        Task Deletar(Perfil perfil);
        Task<List<Perfil>> ListarTodos();
    }
}
