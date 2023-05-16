using Provet.Domain.Interfaces.Autenticacao;
using Provet.Entities.Entities;
using Provet.Infrastructure.Repositories.Generic;

namespace Provet.Infrastructure.Repositories.Autenticacao
{
    public class PerfilRepository : GenericRepository<Perfil>, IPerfil
    {
    }
}
