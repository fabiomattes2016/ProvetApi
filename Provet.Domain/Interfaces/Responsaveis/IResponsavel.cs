using Provet.Domain.Interfaces.Generics;
using Provet.Entities.Entities;

namespace Provet.Domain.Interfaces.Responsaveis
{
    public interface IResponsavel : IGeneric<Responsavel>
    {
        Task<Responsavel> BuscarResponsavelPorId(int id);
        Task<bool> JaCadastrado(string cpf);
    }
}
