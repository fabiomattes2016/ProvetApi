using MediatR;
using Provet.Domain.Commands.Requests;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services;

namespace Provet.Domain.Handlers
{
    public class DeleteResponsavelHandler : IRequestHandler<DeleteResponsavelRequest, GenericResponse>
    {
        private readonly IResponsavel _responsavel;
        private readonly IResponsavelService _responsavelService;

        public DeleteResponsavelHandler(IResponsavel responsavel, IResponsavelService responsavelService)
        {
            _responsavel = responsavel;
            _responsavelService = responsavelService;
        }

        public async Task<GenericResponse> Handle(DeleteResponsavelRequest request, CancellationToken cancellationToken)
        {
            GenericResponse result = new();

            try
            {
                var exists = await _responsavelService.BuscarPorId(request.Responsavel.Id);

                if (exists is null)
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
                    await _responsavelService.Deletar(request.Responsavel);

                    result = new GenericResponse
                    {
                        Status = 200,
                        Message = "Responsável excluído com sucesso",
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
