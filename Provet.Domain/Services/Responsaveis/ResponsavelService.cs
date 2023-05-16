using Provet.Domain.Interfaces.Responsaveis;
using Provet.Domain.Interfaces.Services.Responsaveis;
using Provet.Entities.Entities;

namespace Provet.Domain.Services.Responsaveis
{
    public class ResponsavelService : IResponsavelService
    {
        private readonly IResponsavel _responsavel;

        public ResponsavelService(IResponsavel responsavel)
        {
            _responsavel = responsavel;
        }

        public async Task<List<Responsavel>> ListarTodos()
        {
            return await _responsavel.GetAll();
        }

        public async Task<Responsavel> BuscarPorId(int id)
        {
            return await _responsavel.BuscarResponsavelPorId(id);
        }

        public async Task<bool> JaCadastrado(string cpf)
        {
            return await _responsavel.JaCadastrado(cpf);
        }

        public async Task Adicionar(Responsavel responsavel)
        {
            responsavel.CriadoEm = DateTime.UtcNow;
            await _responsavel.Add(responsavel);
        }

        public async Task Atualizar(Responsavel responsavel)
        {
            responsavel.AtualizadoEm = DateTime.UtcNow;
            await _responsavel.Update(responsavel);
        }

        public async Task Deletar(Responsavel responsavel)
        {
            await _responsavel.Delete(responsavel);
        }
    }
}
