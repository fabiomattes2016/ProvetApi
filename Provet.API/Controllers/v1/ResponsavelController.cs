using MediatR;
using Microsoft.AspNetCore.Mvc;
using Provet.Domain.Commands.Requests;
using Provet.Domain.Commands.Responses;
using Provet.Domain.Queries;
using Provet.Entities.Entities;

namespace Provet.API.Controllers.v1
{
    [Route("v1/api/responsaveis")]
    [ApiController]
    public class ResponsavelController : ControllerBase
    {
        [HttpPost("novo")]
        public Task<GenericResponse> Create(
            [FromServices] IMediator _mediator,
            [FromBody] CreateResponsavelRequest _command
        )
        {
            return _mediator.Send(_command);
        }

        [HttpGet]
        public Task<List<Responsavel>> ListAll([FromServices] IMediator _mediator)
        {
            var _command = new GetListResponsaveisQuery();
            return _mediator.Send(_command);
        }

        [HttpGet("{id}")]
        public Task<Responsavel> GetById([FromServices] IMediator _mediator, int id)
        {
            var _command = new GetResponsavelById(id);
            return _mediator.Send(_command);
        }

        [HttpPut]
        public Task<GenericResponse> Update(
            [FromServices] IMediator _mediator,
            [FromBody] UpdateResponsavelRequest _command
        )
        {
            return _mediator.Send( _command);
        }

        [HttpDelete]
        public Task<GenericResponse> Remove(
            [FromServices] IMediator _mediator,
            [FromBody] DeleteResponsavelRequest _command
        )
        {
            return _mediator.Send(_command);
        }
    }
}
