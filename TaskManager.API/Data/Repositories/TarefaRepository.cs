using MongoDB.Driver;
using System.Collections.Generic;
using TaskManager.API.Data.Configurations;
using TaskManager.API.Models;

namespace TaskManager.API.Repositories
{
    public class TarefaRepository : ITarefasRepository
    {
        private readonly IMongoCollection<Tarefa> _tarefas;

        public TarefaRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _tarefas = database.GetCollection<Tarefa>("tarefas");
        }

        public void Adicionar(Tarefa tarefa)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(string id, Tarefa tarefa)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Tarefa> Buscar()
        {
            throw new System.NotImplementedException();
        }

        public Tarefa Buscar(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
