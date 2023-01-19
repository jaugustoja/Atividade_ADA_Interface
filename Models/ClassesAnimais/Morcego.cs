using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_3.Interfaces;

namespace Exercicio_3.Models.ClassesAnimais
{
    public class Morcego : Mamífero, IVoar
    {
        public Morcego(DateTime dataNascimento, char sexo, string corPelos)
        {
            this.Nome = "Morcego";
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
            this.CorDoPelo = corPelos;
        }

        public int AlitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}