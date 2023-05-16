using MediatR;
using Provet.Domain.Commands.Requests.Autenticacao;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Interfaces.Services.Autenticacao;

namespace Provet.Domain.Handlers.Autenticacao
{
    public class LoginUsuarioHandler : IRequestHandler<LoginUsuarioRequest, GenericResponse>
    {
        private readonly IUsuarioService _usuarioService;

        public LoginUsuarioHandler(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<GenericResponse> Handle(LoginUsuarioRequest request, CancellationToken cancellationToken)
        {
            GenericResponse result = new();

            try
            {
                var data = await _usuarioService.Login(request.Usuario, request.Senha);

                if (data != null)
                {
                    result = new GenericResponse
                    {
                        Status = 200,
                        Message = "Usuário autenticado com sucesso",
                        StackTrace = "true",
                        Data = data,
                        Date = DateTime.UtcNow
                    };
                }
                else
                {
                    result = new GenericResponse
                    {
                        Status = 401,
                        Message = "Usuário e/ou senha inválidos",
                        StackTrace = "false",
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
