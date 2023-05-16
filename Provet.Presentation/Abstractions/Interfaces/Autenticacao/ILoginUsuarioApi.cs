using Provet.Domain.Commands.Responses;
using Refit;

namespace Provet.Presentation.Abstractions.Interfaces.Autenticacao
{
    [Headers("Content-Type: application/json; charset=utf-8")]
    public interface ILoginUsuarioApi
    {
        [Post("/autenticacao/usuario/login")]
        Task<GenericResponse> Login(string usuario, string senha);
    }
}
