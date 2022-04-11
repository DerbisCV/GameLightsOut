using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solvtio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomencladorController : ControllerBase
    {
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
