﻿using MediatR;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services.Responsaveis;
using Provet.Domain.Queries.Responsaveis;
using Provet.Entities.Entities;

namespace Provet.Domain.Handlers.Responsaveis
{
    public class ListResponsaveisHandler : IRequestHandler<GetListResponsaveisQuery, List<Responsavel>>
    {
        private readonly IResponsavel _responsavel;
        private readonly IResponsavelService _responsavelService;

        public ListResponsaveisHandler(IResponsavel responsavel, IResponsavelService responsavelService)
        {
            _responsavel = responsavel;
            _responsavelService = responsavelService;
        }

        public async Task<List<Responsavel>> Handle(GetListResponsaveisQuery request, CancellationToken cancellationToken)
        {
            return await _responsavelService.ListarTodos();
        }
    }
}
