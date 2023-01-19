using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_3.Interfaces;

namespace Exercicio_3.Models.ClassesAnimais
{
    public class Lontra : Mamífero, IAquatico
    {
        public Lontra(DateTime dataNascimento, char sexo, string corPelos)
        {
            this.Nome = "Lontra";
            this.DataDeNascimento = dataNascimento;
            this.Sexo = sexo;
            TimeSpan IdadeEmData = DateTime.Now - DataDeNascimento;
            this.Idade = (IdadeEmData.Days / 365);
            this.Carnívoro = true;
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

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Nadar()
        {
            Console.WriteLine($"{this.Nome} está nadando...");
            Thread.Sleep(3000);
        }
    }
}