using Provet.Domain.Interfaces.Autenticacao;
using Provet.Domain.Interfaces.Services.Autenticacao;
using Provet.Entities.Entities;

namespace Provet.Domain.Services.Autenticacao
{
    public class PerfilService : IPerfilService
    {
        private readonly IPerfil _perfil;

        public PerfilService(IPerfil perfil)
        {
            _perfil = perfil;
        }

        public async Task<List<Perfil>> ListarTodos()
        {
            return await _perfil.GetAll();
        }

        public async Task Adicionar(Perfil perfil)
        {
            perfil.CriadoEm = DateTime.UtcNow;
            await _perfil.Add(perfil);
        }

        public async Task<Perfil> BuscarPorId(int id)
        {
            return await _perfil.GetEntityById(id);
        }

        public async Task Atualizar(Perfil perfil)
        {
            perfil.AtualizadoEm = DateTime.UtcNow;
            await _perfil.Update(perfil);
        }

        public async Task Deletar(Perfil perfil)
        {
            await _perfil.Delete(perfil);
        }
    }
}
