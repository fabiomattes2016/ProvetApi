using MediatR;
using Provet.Domain.Commands.Requests.Autenticacao;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Interfaces.Services.Autenticacao;

namespace Provet.Domain.Handlers.Autenticacao
{
    public class CreatePerfilHandler : IRequestHandler<CreatePerfilRequest, GenericResponse>
    {
        private readonly IPerfilService _perfilService;

        public CreatePerfilHandler(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        public async Task<GenericResponse> Handle(CreatePerfilRequest request, CancellationToken cancellationToken)
        {
            GenericResponse result = new();

            try
            {
                await _perfilService.Adicionar(request.Perfil);

                result = new GenericResponse
                {
                    Status = 201,
                    Message = "Perfil criado com sucesso",
                    Date = DateTime.UtcNow
                };
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
