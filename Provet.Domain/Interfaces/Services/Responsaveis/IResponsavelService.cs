using Provet.Entities.Entities;

namespace Provet.Domain.Interfaces.Services.Responsaveis
{
    public interface IResponsavelService
    {
        Task Adicionar(Responsavel responsavel);
        Task Atualizar(Responsavel responsavel);
        Task<Responsavel> BuscarPorId(int id);
        Task Deletar(Responsavel responsavel);
        Task<bool> JaCadastrado(string cpf);
        Task<List<Responsavel>> ListarTodos();
    }
}
