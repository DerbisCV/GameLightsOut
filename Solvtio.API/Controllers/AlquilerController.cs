﻿using AutoMapper;
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
    public class AlquilerController : ControllerBaseSolvtioApi
    {
        private readonly IMapper _mapper;
        private readonly IAlquilerRepository _repository;
        //private readonly ICaracteristicaBaseRepository _repository;

        public AlquilerController(IMapper mapper, ILogger<AlquilerController> logger, IAlquilerRepository repository) : base(logger)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alq_Expediente>>> GetAll()
        {
            try
            {
                var result = _repository.GetAll().Take(10);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetAll: ");
                return StatusCode(500, error);
            }
        }

        //[HttpPost("GetWithPagination")]
        //public async Task<ActionResult<List<Alq_Expediente>>> GetWithPagination(PaginationFilter paginationFilter)
        //{
        //    try
        //    {
        //        var result = await _repository.GetWithPagination(paginationFilter);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = LogError(ex, "Something went wrong inside GetAll: ");
        //        return StatusCode(500, error);
        //    }
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<AlqExpedienteDto>> Get(int id)
        {
            try
            {
                var model = await _repository.Get(id);
                if (model == null) return NotFound();
                return Ok(_mapper.Map<AlqExpedienteDto>(model));
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
        public IActionResult Update(int id, AlqExpedienteDto model)
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
