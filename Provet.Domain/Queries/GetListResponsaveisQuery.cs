using MediatR;
using Provet.Entities.Entities;

namespace Provet.Domain.Queries
{
    public record GetListResponsaveisQuery() : IRequest<List<Responsavel>>;
}
