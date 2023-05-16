using MediatR;
using Provet.Entities.Entities;

namespace Provet.Domain.Queries.Responsaveis
{
    public record GetListResponsaveisQuery() : IRequest<List<Responsavel>>;
}
