using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models.ClassesAnimais
{
    public class Leão : Mamífero
    {
        public Leão(DateTime dataNascimento, char sexo, string corPelos)
        {
            this.DataDeNascimento = dataNascimento;
            this.Sexo = sexo;
            TimeSpan IdadeEmData = DateTime.Now - DataDeNascimento;
            this.Idade = (IdadeEmData.Days / 365);
            this.Carnívoro = true;
            this.Peconhento = false;
            if (sexo == 'f')
            {
                this.Nome = "Leoa";
                this.QtdeDeMamas = 4;
            }
            else
            {
                this.Nome = "Leão";
                this.QtdeDeMamas = 0;
            }
            this.Pelos = true;
            this.CorDoPelo = corPelos;
        }
        
    }
}