﻿using MediatR;
using Provet.Domain.Commands.Responses;
using Provet.Entities.Entities;

namespace Provet.Domain.Commands.Requests
{
    public record CreateResponsavelRequest(Responsavel Responsavel) : IRequest<GenericResponse>;
}
