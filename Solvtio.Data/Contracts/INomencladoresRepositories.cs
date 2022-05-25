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
        Task<IList<ModelDtoNombre>> TipoDeudorGetAll();
        Task<IList<ModelDtoNombre>> TipoEstadoClienteGetAll(bool soloActivos = true);

        Task<IList<ModelDtoNombre>> GetProvincias();
        Task<IList<ModelDtoNombre>> GetMunicipiosByProvincia(int? idProvincia);

        Task<IList<ModelDtoNombre>> GetCaracteristicaBaseByGrupo(string grupo, bool soloActivos = false);
        Task<IList<ModelDtoNombre>> GetPagadoresPorOficina(int? idClienteOficina);

        //
        Task<IList<ModelDtoNombre>> TipoEstadoGetAllByExpediente(int? idExpediente);
        Task<List<TipoSubFaseEstado>> GetTipoSubFaseByEstado(ExpedienteEstadoTipo estadoTipo, bool soloActivos = true);
        Task<List<TipoIncidenciaEstado>> GetTipoIncidenciaByEstado(ExpedienteEstadoTipo estadoTipo, bool soloActivos = true);
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

    public interface ITipoExpedienteRepository : IGenericRepository<Gnr_TipoExpediente>
    {
    }

    public interface IAbogadoRepository : IGenericRepository<Gnr_Abogado>
    {
    }

    public interface IProcuradorRepository : IGenericRepository<Gnr_Procurador>
    {
    }

    public interface IExpedienteNotaRepository : IGenericRepository<ExpedienteNota>
    {
    }
    public interface IExpedienteDeudorRepository : IGenericRepository<ExpedienteDeudor>
    {
        void Update(ExpedienteDeudorDto entity);
    }
}
