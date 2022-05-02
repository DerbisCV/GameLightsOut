using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solvtio.Data.Contracts;
using Solvtio.Data.Models.Dtos;
using Solvtio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solvtio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomencladorController : ControllerBaseSolvtioApi
    {
        #region Constructors

        private readonly IMapper _mapper;
        private readonly ICaracteristicaBaseRepository _repository;
        private readonly INomencladorReadOnlyRepository _nomencladorReadOnlyRepository;
        private readonly IClienteRepository _repositoryCliente;
        private readonly IClienteOficinaRepository _repositoryClienteOficina;
        private readonly ITipoAreaRepository _repositoryTipoArea;
        private readonly IAbogadoRepository _repositoryAbogado;
        private readonly IProcuradorRepository _repositoryProcurador;

        public NomencladorController(ILogger<NomencladorController> logger, IMapper mapper,
            INomencladorReadOnlyRepository nomencladorReadOnlyRepository,
            ICaracteristicaBaseRepository repository, IClienteRepository clienteRepository, IClienteOficinaRepository clienteOficinaRepository,
            ITipoAreaRepository tipoAreaRepository, IAbogadoRepository abogadoRepository, IProcuradorRepository procuradorRepository
            ) : base(logger)
        {
            _mapper = mapper;
            _repository = repository;
            _nomencladorReadOnlyRepository = nomencladorReadOnlyRepository;
            _repositoryCliente = clienteRepository;
            _repositoryClienteOficina = clienteOficinaRepository;
            _repositoryTipoArea = tipoAreaRepository;
            _repositoryAbogado = abogadoRepository;
            _repositoryProcurador = procuradorRepository;
        }

        #endregion

        #region ClienteOficina

        [HttpGet("ClienteOficinaGetAll")]
        public ActionResult<List<ModelDtoNombre>> ClienteOficinaGetAll()
        {
            try
            {
                var result = _repositoryClienteOficina.GetAll();
                return Ok(_mapper.Map< List<ModelDtoNombre>>(result)); 
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside ClienteOficinaGetAll: ");
                return StatusCode(500, error);
            }
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Gnr_ClienteOficina>> ClienteOficinaGet(int id)
        //{
        //    try
        //    {
        //        var model = await _repository.Get(id);
        //        if (model == null) return NotFound();
        //        return Ok(model);
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = LogError(ex, "Something went wrong inside Get: ");
        //        return StatusCode(500, error);
        //    }
        //}

        //[HttpPost]
        //public IActionResult Add(CaracteristicaBase model)
        //{
        //    try
        //    {
        //        _repository.Add(model);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = LogError(ex, "Something went wrong inside Add: ");
        //        return StatusCode(500, error);
        //    }
        //}

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, CaracteristicaBase model)
        //{
        //    try
        //    {
        //        model.Id = id;
        //        _repository.Update(model);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = LogError(ex, "Something went wrong inside Update: ");
        //        return StatusCode(500, error);
        //    }
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    try
        //    {
        //        _repository.Delete(new CaracteristicaBase() { Id = id });
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = LogError(ex, "Something went wrong inside Delete: ");
        //        return StatusCode(500, error);
        //    }
        //}

        #endregion

        #region Cliente

        [HttpGet("ClienteGetAll")]
        public ActionResult<List<ModelDtoNombre>> ClienteGetAll()
        {
            try
            {
                var result = _repositoryCliente.GetAll();
                return Ok(_mapper.Map<List<ModelDtoNombre>>(result));
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside ClienteGetAll: ");
                return StatusCode(500, error);
            }
        }

        #endregion

        #region TipoArea

        [HttpGet("TipoAreaGetAll")]
        public ActionResult<List<ModelDtoNombre>> TipoAreaGetAll()
        {
            try
            {
                var result = _repositoryTipoArea.GetAll();
                return Ok(_mapper.Map<List<ModelDtoNombre>>(result));
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside TipoAreaGetAll: ");
                return StatusCode(500, error);
            }
        }

        #endregion

        #region Nomencladores

        [HttpGet("AbogadoGetAll")]
        public async Task<ActionResult<List<ModelDtoNombre>>> AbogadoGetAll()
        {
            try
            {
                return Ok(await _nomencladorReadOnlyRepository.GetAbogados());
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside AbogadoGetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("ProcuradorGetAll")]
        public async Task<ActionResult<List<ModelDtoNombre>>> ProcuradorGetAll()
        {
            try
            {
                var result = await _nomencladorReadOnlyRepository.GetProcuradores();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside ProcuradorGetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("JuzgadoGetAll")]
        public async Task<ActionResult<List<ModelDtoNombre>>> JuzgadoGetAll()
        {
            try
            {
                var result = await _nomencladorReadOnlyRepository.GetJuzgados();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside JuzgadoGetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("PartidoJudicialGetAll")]
        public async Task<ActionResult<List<ModelDtoNombre>>> PartidoJudicialGetAll()
        {
            try
            {
                var result = await _nomencladorReadOnlyRepository.GetPartidoJudiciales();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside PartidoJudicialGetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("CarteraGetAll")]
        public async Task<ActionResult<List<ModelDtoNombre>>> CarteraGetAll()
        {
            try
            {
                var result = await _nomencladorReadOnlyRepository.GetCarteras();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside CarteraGetAll: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("GetCaracteristicaBaseByGrupo")]
        public async Task<ActionResult<List<ModelDtoNombre>>> GetCaracteristicaBaseByGrupo(string grupo, bool soloActivos = false)
        {
            try
            {
                var result = await _nomencladorReadOnlyRepository.GetCaracteristicaBaseByGrupo(grupo, soloActivos);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetCaracteristicaBaseByGrupo: ");
                return StatusCode(500, error);
            }
        }

        [HttpGet("GetPagadoresPorOficina")]
        public async Task<ActionResult<List<ModelDtoNombre>>> GetPagadoresPorOficina(int? idClienteOficina)
        {
            try
            {
                var result = await _nomencladorReadOnlyRepository.GetPagadoresPorOficina(idClienteOficina);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = LogError(ex, "Something went wrong inside GetPagadoresPorOficina: ");
                return StatusCode(500, error);
            }
        }
        
        #endregion

        #region Other



        #endregion

        // GET: api/<NomencladorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NomencladorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NomencladorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NomencladorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NomencladorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
