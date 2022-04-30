using Solvtio.Models;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface IExpedienteRepository //: IGenericRepository<Expediente>
    {
        Task<ModelExpedienteEdit> GetModelExpediente(int id);
        Task<SearchExpediente> GetWithPagination(PaginationFilter paginationFilter);
    }
}
