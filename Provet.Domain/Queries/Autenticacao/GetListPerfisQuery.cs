using MediatR;
using Provet.Entities.Entities;

namespace Provet.Domain.Queries.Autenticacao
{
    public record GetListPerfisQuery() : IRequest<List<Perfil>>;
}
