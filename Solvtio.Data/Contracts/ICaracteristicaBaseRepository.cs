using Solvtio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface ICaracteristicaBaseRepository : IGenericRepository<CaracteristicaBase>
    {
        Task<List<CaracteristicaBase>> GetByGrup(string grupo, bool soloActivos);
    }
}
