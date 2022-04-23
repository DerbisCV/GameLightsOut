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
    public class AlquilerController : ControllerBaseSolvtioApi
    {
        private readonly IAlquilerRepository _repository;

        public AlquilerController(ILogger<AlquilerController> logger, IAlquilerRepository repository) : base(logger)
        {
            _repository = repository;
        }

        [HttpPost("GetWithPagination")]
        public async Task<ActionResult<List<Alq_Expediente>>> GetWithPagination(PaginationFilter paginationFilter)
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Alq_Expediente>> Get(int id)
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
        public IActionResult Add(Alq_Expediente model)
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
        public IActionResult Update(int id, Alq_Expediente model)
        {
            try
            {
                model.IdExpediente = id;
                _repository.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside Update: ");
                return StatusCode(500, error);
            }
        }

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    try
        //    {
        //        _repository.Delete(new Alq_Expediente() { Id = id });
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = LogError(ex, "Something went wrong inside Delete: ");
        //        return StatusCode(500, error);
        //    }            
        //}
    }
}
