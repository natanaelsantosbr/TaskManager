using System;

namespace TaskManager.API.Models
{
    public class Tarefa
    {
        public Tarefa()
        {
            this.Id = Guid.NewGuid().ToString();
            this.DataDoCadastro = DateTime.Now;
        }

        public Tarefa(string nome, string detalhes) : this()    
        {
            Nome = nome;
            Detalhes = detalhes;
        }

        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Detalhes { get; private set; }
        public bool Concluido { get; private set; }
        public DateTime DataDoCadastro { get; private set; }
        public DateTime? DataConclusao { get; private set; }

        public void AtualizarTarefa(string nome, string detalhes, bool? concluido = false)
        {
            this.Nome = nome;
            this.Detalhes = detalhes;
            this.Concluido = concluido ?? false;

            if (this.Concluido)
                this.DataConclusao = DateTime.Now;
        }
    }
}
