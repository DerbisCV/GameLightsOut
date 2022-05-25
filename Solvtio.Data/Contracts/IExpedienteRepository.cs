using Solvtio.Data.Common;
using Solvtio.Data.Models.Dtos;
using Solvtio.Data.Models.Estado;
using Solvtio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface IExpedienteRepository
    {
        Task<SearchExpediente> GetWithPagination(PaginationFilter paginationFilter);
        Task<ModelExpedienteEdit> GetModelExpediente(int id);
        Task<ModelResult> Update(ModelExpedienteEdit entity);

        Task<ExpedienteEstadoDto> GetEstadoActual(int idExpediente);
        

        int? GetIdExpedienteByNo(string noExpediente);

        Task<List<ExpedienteNotaDto>> GetNotas(int idExpediente);
        Task<List<ExpedienteDeudorDto>> GetDeudores(int idExpediente);

        Task<ModelDashboardAlarmas> GetModelDashboardAlarmas(FilterBase filter, bool quitarLosResultadosConGestionReciente = false);

        Task<ExpedienteHipDto> GetExpedienteByTypeHip(int idExpediente);
    }
}
