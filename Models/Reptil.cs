using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public abstract class Reptil : Animal
    {
        //Propriedades
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }

        //Constructor
        // public Reptil(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento, bool temCasco, bool temEscamas) : base(nome, dataNascimento, sexo, carnivoro, peconhento)
        // {

        //     this.TemEscamas = temEscamas;
        //     this.TemCasco = temCasco;

        // }
    }
}