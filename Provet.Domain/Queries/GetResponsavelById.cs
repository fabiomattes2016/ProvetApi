using MediatR;
using Provet.Entities.Entities;

namespace Provet.Domain.Queries
{
    public record GetResponsavelById(int Id) : IRequest<Responsavel>;
}
