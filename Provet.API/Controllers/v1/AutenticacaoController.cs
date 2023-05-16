using MediatR;
using Microsoft.AspNetCore.Mvc;
using Provet.Domain.Commands.Requests.Autenticacao;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Queries.Autenticacao;
using Provet.Entities.Entities;
using System.Text.Json;

namespace Provet.API.Controllers.v1
{
    [Route("v1/api/autenticacao")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        [HttpPost("perfil/novo")]
        public Task<GenericResponse> Create(
            [FromServices] IMediator _mediator,
            [FromBody] CreatePerfilRequest _command
        )
        {
            return _mediator.Send(_command);
        }

        [HttpGet("perfil")]
        public Task<List<Perfil>> ListAll([FromServices] IMediator _mediator)
        {
            var _command = new GetListPerfisQuery();
            return _mediator.Send(_command);
        }

        [HttpPost("usuario/novo")]
        public Task<GenericResponse> Create(
            [FromServices] IMediator _mediator,
            [FromBody] CreateUsuarioRequest _command
        )
        {
            return _mediator.Send(_command);
        }

        [HttpPost("usuario/login")]
        public IActionResult Login(
            [FromServices] IMediator _mediator,
            [FromForm] LoginUsuarioRequest _command
        )
        {
            var data = _mediator.Send(_command);
            var result = new GenericResponse
            { 
                Status = data.Result.Status,
                Message = data.Result.Message,
                StackTrace = data.Result.StackTrace,
                Data = data.Result.Data,
                Date = data.Result.Date
            };

            return Ok(result);
        }
    }
}
