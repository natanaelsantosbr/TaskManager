using System.Collections;
using System.Collections.Generic;
using TaskManager.API.Models;

namespace TaskManager.API.Repositories
{
    public interface ITarefasRepository
    {
        void Adicionar(Tarefa tarefa);
        void Atualizar(string id, Tarefa tarefaAtualizada);
        IEnumerable<Tarefa> Buscar();
        Tarefa Buscar(string id);

    }
}
