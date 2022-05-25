using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solvtio.Data.Contracts;
using Solvtio.Data.Models.Dtos;
using Solvtio.Data.Models.Estado;
using Solvtio.Data.Models.Estado.Alquiler;
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
    public class EstadoController : ControllerBaseSolvtioApi
    {
        #region Constructor & Properties

        private readonly IMapper _mapper;
        private readonly IExpedienteRepository _repository;
        private readonly IExpedienteNotaRepository _repositoryExpedienteNota;
        private readonly IExpedienteDeudorRepository _repositoryExpedienteDeudor;
        private readonly IExpedienteEstadoRepository _repositoryExpedienteEstado;

        public EstadoController(ILogger<ExpedienteController> logger, IMapper mapper,
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

        #endregion

        #region Alquiler

        [HttpGet("GetEstadoAlqFinalizacion")]
        public async Task<ActionResult<ExpedienteEstadoDto>> GetEstadoAlqFinalizacion(int id)
        {
            try
            {
                var result = await _repositoryExpedienteEstado.GetEstadoAlqFinalizacion(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetEstados: ");
                return StatusCode(500, error);
            }
        }

        [HttpPut("EstadoAlqFinalizacionUpdate")]
        public IActionResult EstadoAlqFinalizacionUpdate(EstadoAlqFinalizacionDto model)
        {
            try
            {
                _repositoryExpedienteEstado.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside EstadoAlqFinalizacionUpdate: ");
                return StatusCode(500, error);
            }
        }

        #endregion
    }
}
