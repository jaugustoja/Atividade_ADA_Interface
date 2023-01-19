using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public abstract class Ave : Animal
    {
        //Propriedades
        public bool Rapina { get; set; }
        public string CorPena { get; set; }
        // public Ave(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento, bool rapina, bool corPena) : base(nome, dataNascimento, sexo, carnivoro, peconhento)
        // {
        //     this.Rapina = rapina;
        //     this.CorPena = corPena;
        // }

        public void Ciscar()
        {
            Console.WriteLine($"{this.Nome} está ciscando...");
            Thread.Sleep(3000);
        }
    }
}