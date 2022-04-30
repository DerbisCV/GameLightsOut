using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solvtio.Data.Contracts;
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
        public IActionResult Update(int id, Expediente model)
        {
            try
            {
                model.IdExpediente = id;
                //_repository.Update(model);
                return Ok();
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
    }
}
