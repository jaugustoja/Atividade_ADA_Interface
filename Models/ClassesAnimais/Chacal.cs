using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models.ClassesAnimais
{
    public class Chacal : Mamífero
    {
        public Chacal(DateTime dataNascimento, char sexo, string corPelos)
        {
            this.Nome = "Chacal";
            this.DataDeNascimento = dataNascimento;
            this.Sexo = sexo;
            TimeSpan IdadeEmData = DateTime.Now - DataDeNascimento;
            this.Idade = (IdadeEmData.Days / 365);
            this.Carnívoro = true;
            this.Peconhento = false;
            if (sexo == 'f')
            {
                this.QtdeDeMamas = 4;
            }
            else
            {
                this.QtdeDeMamas = 0;
            }
            this.Pelos = true;
            this.CorDoPelo = corPelos;
        }
    }
}