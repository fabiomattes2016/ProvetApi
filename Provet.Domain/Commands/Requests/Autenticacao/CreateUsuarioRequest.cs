using MediatR;
using Provet.Domain.Commands.Responses;
using Provet.Entities.Entities;

namespace Provet.Domain.Commands.Requests.Autenticacao
{
    public record CreateUsuarioRequest(Usuario Usuario) : IRequest<GenericResponse>;
}
