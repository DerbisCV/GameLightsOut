using Solvtio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface IAlquilerRepository : IGenericRepository<Alq_Expediente>
    {
        Task<IEnumerable<Alq_Expediente>> GetWithPagination(PaginationFilter paginationFilter);
    }
}
