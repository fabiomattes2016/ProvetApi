using Provet.Domain.Interfaces.Generics;
using Provet.Entities.Entities;

namespace Provet.Domain.Interfaces.Autenticacao
{
    public interface IUsuario : IGeneric<Usuario>
    {
        Task<bool> JaCadastrado(string cpf);
        Task<Usuario> Login(string usuario, string senha);
    }
}
