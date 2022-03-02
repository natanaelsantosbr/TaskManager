using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskManager.API.Models;
using TaskManager.API.Models.InputModels;
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
                
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tarefasRepository.Buscar());
        }
                
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var tarefa = _tarefasRepository.Buscar(id);

            if(tarefa == null)
                return NotFound();

            return Ok(tarefa);
        }
                
        [HttpPost]
        public IActionResult Post([FromBody] TarefaInputModel novaTarefa)
        {
            var tarefa = new Tarefa(novaTarefa.Nome, novaTarefa.Detalhes);

            _tarefasRepository.Adicionar(tarefa);
            return Created("", tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] TarefaInputModel tarefaAtualizada)
        {
            var tarefa = _tarefasRepository.Buscar(id);

            if (tarefa == null)
                return NotFound();


            tarefa.AtualizarTarefa(tarefaAtualizada.Nome, tarefaAtualizada.Detalhes, tarefaAtualizada.Concluido);

            _tarefasRepository.Atualizar(id, tarefa);

            return Ok(tarefa);
            
        }

        // DELETE api/<TarefasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var tarefa = _tarefasRepository.Buscar(id);

            if (tarefa == null)
                return NotFound();

            _tarefasRepository.Remover(id);

            return NoContent();



        }
    }
}
