using Solvtio.Data.Models.Dtos;
using Solvtio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface IExpedienteEstadoRepository : IGenericRepository<ExpedienteEstado>
    {
        Task<List<ExpedienteEstadoDto>> GetByExpediente(int idExpediente);
        void Update(ExpedienteEstadoDto entity);

        Task<List<ExpedienteNotaDto>> GetExpedienteNotaByEstado(int idExpedienteEstado);
        Task<List<LogEstadoSubfase>> LogEstadoSubfaseByEstado(int idExpedienteEstado);
    }
}
