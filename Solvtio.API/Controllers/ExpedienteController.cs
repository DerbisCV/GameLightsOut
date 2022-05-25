using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solvtio.Data.Contracts;
using Solvtio.Data.Models.Dtos;
using Solvtio.Data.Models.Estado;
using Solvtio.Models;
using Solvtio.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solvtio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpedienteController : ControllerBaseSolvtioApi
    {
        #region Constructor & Properties

        private readonly IMapper _mapper;
        private readonly IExpedienteRepository _repository;
        private readonly IExpedienteNotaRepository _repositoryExpedienteNota;
        private readonly IExpedienteDeudorRepository _repositoryExpedienteDeudor;
        private readonly IExpedienteEstadoRepository _repositoryExpedienteEstado;

        public ExpedienteController(ILogger<ExpedienteController> logger, IMapper mapper,
            IExpedienteRepository repository,
            IExpedienteNotaRepository repositoryExpedienteNota,
            IExpedienteEstadoRepository repositoryExpedienteEstado,
            IExpedienteDeudorRepository repositoryExpedienteDeudor) : base(logger)
        {
            _mapper = mapper;
            _repository = repository;
            _repositoryExpedienteNota = repositoryExpedienteNota;
            _repositoryExpedienteEstado = repositoryExpedienteEstado;
            _repositoryExpedienteDeudor = repositoryExpedienteDeudor;
        }

        #endregion

        #region Expediente

        [HttpPost("GetWithPagination")]
        public async Task<ActionResult<SearchExpediente>> GetWithPagination(PaginationFilter paginationFilter)
        {
            try
            {
                var result = await _repository.GetWithPagination(paginationFilter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<object>>> GetAll()
        {
            try
            {
                //var result = _repository.GetAll().Take(10);
                return Ok(null);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModelExpedienteEdit>> Get(int id)
        {
            try
            {
                var model = await _repository.GetModelExpediente(id);
                if (model == null) return NotFound();
                return Ok(model);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside Get: ");
                return StatusCode(500, error);
            }
        }


        [HttpGet("GetIdExpedienteByNo")]
        public ActionResult<int?> GetIdExpedienteByNo(string noExpediente)
        {
            try
            {
                var result = _repository.GetIdExpedienteByNo(noExpediente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetIdExpedienteByNo: ");
                return StatusCode(500, error);
            }
        }

        [HttpPost]
        public IActionResult Add(CaracteristicaBase model)
        {
            try
            {
                //_repository.Add(model);
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside Add: ");
                return StatusCode(500, error);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ModelExpedienteEdit model)
        {
            try
            {
                model.IdExpediente = id;
                var result = await _repository.Update(model);
                return result.HasError ? BadRequest(result.ErrorMessage) : Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside Update: ");
                return StatusCode(500, error);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //_repository.Delete(new CaracteristicaBase() { Id = id });
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside Delete: ");
                return StatusCode(500, error);
            }
        }

        #endregion

        #region Expediente ByType

        [HttpGet("GetExpedienteByTypeHip")]
        public async Task<ActionResult<ExpedienteHipDto>> GetExpedienteByTypeHip(int id)
        {
            try
            {
                var result = await _repository.GetExpedienteByTypeHip(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetIdExpedienteByNo: ");
                return StatusCode(500, error);
            }
        }

        #endregion

        #region Estado

        [HttpGet("GetEstadoActual")]
        public async Task<ActionResult<ExpedienteEstadoDto>> GetEstadoActual(int id)
        {
            try
            {
                var result = await _repository.GetEstadoActual(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetEstadoActual: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("GetEstados")]
        public async Task<ActionResult<List<ExpedienteEstadoDto>>> GetEstados(int idExpediente)
        {
            try
            {
                var result = await _repositoryExpedienteEstado.GetByExpediente(idExpediente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetEstados: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("EstadoGetById")]
        public async Task<ActionResult<ExpedienteEstadoDto>> EstadoGetById(int idExpedienteEstado)
        {
            try
            {
                var result = await _repositoryExpedienteEstado.Get(idExpedienteEstado);
                return Ok(_mapper.Map<ExpedienteEstadoDto>(result));
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetEstados: ");
                return StatusCode(500, error);
            }
        }

        [HttpPost("EstadoAdd")]
        public IActionResult EstadoAdd(ExpedienteEstadoDto model)
        {
            try
            {
                model.Usuario = UserIdentityName ?? String.Empty;
                _repositoryExpedienteEstado.Add(new ExpedienteEstado(model));
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside EstadoAdd: ");
                return StatusCode(500, error);
            }
        }

        [HttpPut("EstadoUpdate")]
        public IActionResult EstadoUpdate(ExpedienteEstadoDto model)
        {
            try
            {
                model.Usuario = UserIdentityName;
                _repositoryExpedienteEstado.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside EstadoUpdate: ");
                return StatusCode(500, error);
            }
        }

        [HttpDelete("EstadoDelete")]
        public IActionResult EstadoDelete(int idExpedienteEstado)
        {
            try
            {
                _repositoryExpedienteEstado.Delete(new ExpedienteEstado() { ExpedienteEstadoId = idExpedienteEstado });
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside EstadoDelete: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("GetExpedienteNotaByEstado")]
        public async Task<ActionResult<List<ExpedienteNotaDto>>> GetExpedienteNotaByEstado(int idExpedienteEstado)
        {
            try
            {
                var result = await _repositoryExpedienteEstado.GetExpedienteNotaByEstado(idExpedienteEstado);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetExpedienteNotaByEstado: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("LogEstadoSubfaseByEstado")]
        public async Task<ActionResult<List<LogEstadoSubfase>>> LogEstadoSubfaseByEstado(int idExpedienteEstado)
        {
            try
            {
                var result = await _repositoryExpedienteEstado.LogEstadoSubfaseByEstado(idExpedienteEstado);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside LogEstadoSubfaseByEstado: ");
                return StatusCode(500, error);
            }
        }

        #endregion

        #region Notas

        [HttpGet("GetNotas")]
        public async Task<ActionResult<List<ExpedienteNotaDto>>> GetNotas(int idExpediente)
        {
            try
            {
                var result = await _repository.GetNotas(idExpediente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetNotas: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("NotaGetById")]
        public async Task<ActionResult<ExpedienteNotaDto>> NotaGetById(int idExpedienteNota)
        {
            try
            {
                var result = await _repositoryExpedienteNota.Get(idExpedienteNota);
                return Ok(_mapper.Map<ExpedienteNotaDto>(result));
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetNotas: ");
                return StatusCode(500, error);
            }
        }

        [HttpPost("NotaAdd")]
        public IActionResult NotaAdd(ExpedienteNotaDto model)
        {
            try
            {
                _repositoryExpedienteNota.Add(new ExpedienteNota(model) { Usuario = UserIdentityName });
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside NotaAdd: ");
                return StatusCode(500, error);
            }
        }

        [HttpPut("NotaUpdate")]
        public IActionResult NotaUpdate(ExpedienteNotaDto model)
        {
            try
            {
                _repositoryExpedienteNota.Update(new ExpedienteNota(model) { Usuario = UserIdentityName });
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside NotaUpdate: ");
                return StatusCode(500, error);
            }
        }

        [HttpDelete("NotaDelete")]
        public IActionResult NotaDelete(int idExpedienteNota)
        {
            try
            {
                _repositoryExpedienteNota.Delete(new ExpedienteNota() { IdExpedienteNota = idExpedienteNota });
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside NotaDelete: ");
                return StatusCode(500, error);
            }
        }

        #endregion
        
        #region Deudores

        [HttpGet("GetDeudores")]
        public async Task<ActionResult<List<ExpedienteDeudorDto>>> GetDeudores(int idExpediente)
        {
            try
            {
                var result = await _repository.GetDeudores(idExpediente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetDeudores: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("DeudorGetById")]
        public async Task<ActionResult<ExpedienteDeudorDto>> DeudorGetById(int idExpedienteDeudor)
        {
            try
            {
                var result = await _repositoryExpedienteDeudor.Get(idExpedienteDeudor);
                return Ok(_mapper.Map<ExpedienteDeudorDto>(result));
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetDeudores: ");
                return StatusCode(500, error);
            }
        }

        [HttpPost("DeudorAdd")]
        public IActionResult DeudorAdd(ExpedienteDeudorDto model)
        {
            try
            {
                _repositoryExpedienteDeudor.Add(new ExpedienteDeudor(model));
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside DeudorAdd: ");
                return StatusCode(500, error);
            }
        }

        [HttpPut("DeudorUpdate")]
        public IActionResult DeudorUpdate(ExpedienteDeudorDto model)
        {
            try
            {
                _repositoryExpedienteDeudor.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside DeudorUpdate: ");
                return StatusCode(500, error);
            }
        }

        [HttpDelete("DeudorDelete")]
        public IActionResult DeudorDelete(int idExpedienteDeudor)
        {
            try
            {
                _repositoryExpedienteDeudor.Delete(new ExpedienteDeudor() { IdExpedienteDeudor = idExpedienteDeudor });
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside DeudorDelete: ");
                return StatusCode(500, error);
            }
        }

        #endregion
        
        #region Otros

        #endregion

        #region Dashboards

        [HttpPost("GetDashboardKpi")]
        public async Task<ActionResult<List<KpiInfo>>> GetDashboardKpi(FilterBase filter)
        {
            try
            {
                var result = await _repository.GetModelDashboardAlarmas(filter);
                return Ok(result.LstKpiInfo);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetAll: ");
                return StatusCode(500, error);
            }
        }

        #endregion
    }
}
