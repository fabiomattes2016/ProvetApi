using MediatR;
using Provet.Domain.Interfaces.Services.Autenticacao;
using Provet.Domain.Queries.Autenticacao;
using Provet.Entities.Entities;

namespace Provet.Domain.Handlers.Autenticacao
{
    public class ListPerfisHandler : IRequestHandler<GetListPerfisQuery, List<Perfil>>
    {
        private readonly IPerfilService _perfilService;

        public ListPerfisHandler(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        public async Task<List<Perfil>> Handle(GetListPerfisQuery request, CancellationToken cancellationToken)
        {
            return await _perfilService.ListarTodos();
        }
    }
}
