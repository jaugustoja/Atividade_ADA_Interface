using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public abstract class Mamífero : Animal
    {
        //Propriedades
        public int QtdeDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }

        //Constructor
        // public Mamífero(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento, int qtdeMamas, bool pelos, string corPelos) : base(nome, dataNascimento, sexo, carnivoro, peconhento)
        // {
        //     this.QtdeDeMamas = qtdeMamas;
        //     this.Pelos = pelos;
        //     this.CorDoPelo = corPelos;
        // }

        //Métodos
        public void Amamentar()
        {
            if (this.Sexo == 'f')
            {
                Console.WriteLine($"{this.Nome} está amamentado.");
            }
            else
            {
                Console.WriteLine($"{this.Nome} não amamenta pois é macho.");
            }
        }
    }
}