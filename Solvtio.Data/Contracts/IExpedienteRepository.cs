using Solvtio.Data.Common;
using Solvtio.Data.Models.Dtos;
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
        Task<List<ExpedienteNotaDto>> GetNotas(int idExpediente);

        int? GetIdExpedienteByNo(string noExpediente);
    }
}
