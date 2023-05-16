using MediatR;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services.Responsaveis;
using Provet.Domain.Queries.Responsaveis;
using Provet.Entities.Entities;

namespace Provet.Domain.Handlers.Responsaveis
{
    public class GetResponsavelByIdHandler : IRequestHandler<GetResponsavelById, Responsavel>
    {
        private readonly IResponsavel _responsavel;
        private readonly IResponsavelService _responsavelService;

        public GetResponsavelByIdHandler(IResponsavel responsavel, IResponsavelService responsavelService)
        {
            _responsavel = responsavel;
            _responsavelService = responsavelService;
        }

        public async Task<Responsavel> Handle(GetResponsavelById request, CancellationToken cancellationToken)
        {
            return await _responsavelService.BuscarPorId(request.Id);
        }
    }
}
