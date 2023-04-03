using CpfLibrary;
using MediatR;
using Provet.Domain.Commands.Requests;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services;

namespace Provet.Domain.Handlers
{
    public class UpdateResponsavelHandler : IRequestHandler<UpdateResponsavelRequest, GenericResponse>
    {
        private readonly IResponsavel _responsavel;
        private readonly IResponsavelService _responsavelService;

        public UpdateResponsavelHandler(IResponsavel responsavel, IResponsavelService responsavelService)
        {
            _responsavel = responsavel;
            _responsavelService = responsavelService;
        }

        public async Task<GenericResponse> Handle(UpdateResponsavelRequest request, CancellationToken cancellationToken)
        {
            GenericResponse result = new();

            try
            {
                var validCpf = Cpf.Check(request.Responsavel.Cpf);
                var exists = await _responsavelService.BuscarPorId(request.Responsavel.Id);

                if(exists is null)
                {
                    result = new GenericResponse
                    {
                        Status = 404,
                        Message = "Responsável não cadastrado!",
                        Date = DateTime.UtcNow
                    };
                }
                else
                {
                    await _responsavelService.Atualizar(request.Responsavel);

                    result = new GenericResponse
                    {
                        Status = 200,
                        Message = "Responsável atualizado com sucesso",
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
