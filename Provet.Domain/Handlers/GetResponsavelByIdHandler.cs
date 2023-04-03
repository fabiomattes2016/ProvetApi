using MediatR;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services;
using Provet.Domain.Queries;
using Provet.Entities.Entities;

namespace Provet.Domain.Handlers
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
