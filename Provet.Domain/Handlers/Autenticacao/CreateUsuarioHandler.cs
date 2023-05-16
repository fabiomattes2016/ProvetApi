using MediatR;
using Provet.Domain.Commands.Requests.Autenticacao;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Interfaces.Services.Autenticacao;

namespace Provet.Domain.Handlers.Autenticacao
{
    public class CreateUsuarioHandler : IRequestHandler<CreateUsuarioRequest, GenericResponse>
    {
        public readonly IUsuarioService _usuarioService;

        public CreateUsuarioHandler(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<GenericResponse> Handle(CreateUsuarioRequest request, CancellationToken cancellationToken)
        {
            GenericResponse result = new();

            try
            {
                var exists = await _usuarioService.JaCadastrado(request.Usuario.NomeUsuario);

                if (exists)
                {
                    result = new GenericResponse
                    {
                        Status = 302,
                        Message = "Usuário já cadastrado",
                        Date = DateTime.UtcNow
                    };
                }
                else
                {
                    await _usuarioService.Adicionar(request.Usuario);

                    result = new GenericResponse
                    {
                        Status = 201,
                        Message = "Usuário criado com sucesso",
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
