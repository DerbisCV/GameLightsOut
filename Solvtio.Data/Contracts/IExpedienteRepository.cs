using Solvtio.Models;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface IExpedienteRepository //: IGenericRepository<Expediente>
    {
        Task<ModelExpediente> GetModelExpediente(int id);
    }
}
