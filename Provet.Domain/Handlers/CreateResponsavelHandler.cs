using CpfLibrary;
using MediatR;
using Nest;
using Provet.Domain.Commands.Requests;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services;

namespace Provet.Domain.Handlers
{
    public class CreateResponsavelHandler : IRequestHandler<CreateResponsavelRequest, GenericResponse>
    {
        private readonly IResponsavel _responsavel;
        private readonly IResponsavelService _responsavelService;
        //private readonly IElasticClient _elasticClient;

        public CreateResponsavelHandler(IResponsavel responsavel, IResponsavelService responsavelService, IElasticClient elasticClient)
        {
            _responsavel = responsavel;
            _responsavelService = responsavelService;
            //_elasticClient = elasticClient;
        }

        public async Task<GenericResponse> Handle(CreateResponsavelRequest request, CancellationToken cancellationToken)
        {
            GenericResponse result = new();

            try
            {
                var validCpf = Cpf.Check(request.Responsavel.Cpf);
                var exists = await _responsavelService.JaCadastrado(request.Responsavel.Cpf);

                if (exists) 
                {
                    result = new GenericResponse
                    {
                        Status = 302,
                        Message = "Responsável já cadastrado",
                        Date = DateTime.UtcNow
                    };
                }
                else if(!validCpf)
                {
                    result = new GenericResponse
                    {
                        Status = 400,
                        Message = "O CPF digitado é inválido",
                        Date = DateTime.UtcNow
                    };
                }
                else
                {
                    await _responsavelService.Adicionar(request.Responsavel);
                    //_elasticClient.IndexDocument(request);

                    result = new GenericResponse
                    {
                        Status = 201,
                        Message = "Responsável criado com sucesso",
                        Date = DateTime.UtcNow
                    };
                }
            }
            catch (Exception ex)
            {
                result = new GenericResponse
                {
                    Status = 400,
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    Date = DateTime.UtcNow
                };
            }

            return result;
        }
    }
}
