﻿using MediatR;
using Provet.Domain.Commands.Responses;
using Provet.Entities.Entities;

namespace Provet.Domain.Commands.Requests.Responsaveis
{
    public record UpdateResponsavelRequest(Responsavel Responsavel) : IRequest<GenericResponse>;
}
