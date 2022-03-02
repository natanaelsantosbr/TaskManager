using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskManager.API.Repositories;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private ITarefasRepository _tarefasRepository;

        public TarefasController(ITarefasRepository tarefasRepository)
        {
            _tarefasRepository = tarefasRepository;
        }

        // GET: api/<TarefasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TarefasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TarefasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TarefasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TarefasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
