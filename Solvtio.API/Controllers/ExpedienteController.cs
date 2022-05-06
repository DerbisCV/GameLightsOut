﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solvtio.Data.Contracts;
using Solvtio.Data.Models.Dtos;
using Solvtio.Models;
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
        private readonly IExpedienteRepository _repository;

        public ExpedienteController(ILogger<ExpedienteController> logger, IExpedienteRepository repository) : base(logger)
        {
            _repository = repository;
        }

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

        [HttpGet("GetDeudores")]
        public async Task<ActionResult<List<ExpedienteDeudorDto>>> GetDeudores(int idExpediente)
        {
            try
            {
                var result = await _repository.GetGetDeudores(idExpediente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetNotas: ");
                return StatusCode(500, error);
            }
        }


    }
}
