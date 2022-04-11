using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solvtio.Data.Contracts;
using Solvtio.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaracteristicaBaseController : ControllerBaseSolvtioApi
    {
        private readonly ICaracteristicaBaseRepository _repository;

        public CaracteristicaBaseController(ILogger<CaracteristicaBaseController> logger, ICaracteristicaBaseRepository repository) : base(logger)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<CaracteristicaBase>>> GetAll()
        {
            try
            {
                var result = _repository.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CaracteristicaBase>> Get(int id)
        {
            try
            {
                var model = await _repository.Get(id);
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
                _repository.Add(model);
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside Add: ");
                return StatusCode(500, error);
            }            
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CaracteristicaBase model)
        {
            try
            {
                model.Id = id;
                _repository.Update(model);
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
                _repository.Delete(new CaracteristicaBase() { Id = id });
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
