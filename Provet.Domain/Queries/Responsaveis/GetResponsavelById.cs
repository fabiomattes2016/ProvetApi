using MediatR;
using Provet.Entities.Entities;

namespace Provet.Domain.Queries.Responsaveis
{
    public record GetResponsavelById(int Id) : IRequest<Responsavel>;
}
