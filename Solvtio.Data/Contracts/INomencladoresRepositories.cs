using Solvtio.Data.Models.Dtos;
using Solvtio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface INomencladorReadOnlyRepository
    {
        Task<IList<ModelDtoNombre>> GetAbogados();
        Task<IList<ModelDtoNombre>> GetProcuradores();
        Task<IList<ModelDtoNombre>> GetJuzgados();
        Task<IList<ModelDtoNombre>> GetPartidoJudiciales();
        Task<IList<ModelDtoNombre>> GetCarteras();
        
        Task<IList<ModelDtoNombre>> GetCaracteristicaBaseByGrupo(string grupo, bool soloActivos = false);
        Task<IList<ModelDtoNombre>> GetPagadoresPorOficina(int? idClienteOficina);
    }
    
    public interface IClienteOficinaRepository : IGenericRepository<Gnr_ClienteOficina>
    {
    }
    public interface IClienteRepository : IGenericRepository<Gnr_Cliente>
    {
    }

    public interface ITipoAreaRepository : IGenericRepository<Gnr_TipoArea>
    {
    }

    public interface IAbogadoRepository : IGenericRepository<Gnr_Abogado>
    {
    }

    public interface IProcuradorRepository : IGenericRepository<Gnr_Procurador>
    {
    }
    
}
