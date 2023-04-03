using Microsoft.EntityFrameworkCore;
using Provet.Domain.Interfaces.Responsaveis;
using Provet.Entities.Entities;
using Provet.Infrastructure.Configuration;
using Provet.Infrastructure.Repositories.Generic;

namespace Provet.Infrastructure.Repositories.Responsaveis
{
    public class ResponsavelRepository :  GenericRepository<Responsavel>, IResponsavel
    {
        private readonly DbContextOptions<ContextBase> _dbContextOptions;

        public ResponsavelRepository()
        {
            _dbContextOptions = new DbContextOptions<ContextBase>();
        }

        public async Task<Responsavel> BuscarResponsavelPorId(int id)
        {
            using (var banco = new ContextBase(_dbContextOptions))
            {
                return await banco.Responsaveis.FirstOrDefaultAsync(r => r.Id == id);
            }
        }

        public async Task<bool> JaCadastrado(string cpf)
        {
            using (var banco = new ContextBase(_dbContextOptions))
            {
                var responsavel = await banco.Responsaveis.FirstOrDefaultAsync(r => r.Cpf == cpf);

                if(responsavel != null)
                    return true;
                else 
                    return false;
            }
        }
    }
}
