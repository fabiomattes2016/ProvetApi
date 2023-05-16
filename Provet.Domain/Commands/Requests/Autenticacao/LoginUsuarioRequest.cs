using MediatR;
using Provet.Domain.Commands.Responses;

namespace Provet.Domain.Commands.Requests.Autenticacao
{
    public record LoginUsuarioRequest(string Usuario, string Senha) : IRequest<GenericResponse>;
}
