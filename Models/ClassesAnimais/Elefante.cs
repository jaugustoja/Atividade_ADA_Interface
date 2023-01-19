using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models.ClassesAnimais
{
    public class Elefante : Mamífero
    {
        public Elefante(DateTime dataNascimento, char sexo)
        {
            this.Nome = "Elefante";
            this.DataDeNascimento = dataNascimento;
            this.Sexo = sexo;
            TimeSpan IdadeEmData = DateTime.Now - DataDeNascimento;
            this.Idade = (IdadeEmData.Days / 365);
            this.Carnívoro = false;
            this.Peconhento = false;
            if (sexo == 'f')
            {
                this.QtdeDeMamas = 2;
            }
            else
            {
                this.QtdeDeMamas = 0;
            }
            this.Pelos = true;
            
        }
    }
}