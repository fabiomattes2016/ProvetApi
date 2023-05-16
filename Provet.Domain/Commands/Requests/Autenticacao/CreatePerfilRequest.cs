using MediatR;
using Provet.Domain.Commands.Responses;
using Provet.Entities.Entities;

namespace Provet.Domain.Commands.Requests.Autenticacao
{
    public record CreatePerfilRequest(Perfil Perfil) : IRequest<GenericResponse>;
}
