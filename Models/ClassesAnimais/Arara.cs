using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_3.Interfaces;

namespace Exercicio_3.Models.ClassesAnimais
{
    public class Arara : Ave, IVoar, IOviparo
    {

        public Arara(DateTime dataNascimento, char sexo, string corPena)
        {
            this.Nome = "Arara";
            this.DataDeNascimento = dataNascimento;
            this.Sexo = sexo;
            TimeSpan IdadeEmData = DateTime.Now - DataDeNascimento;
            this.Idade = (IdadeEmData.Days / 365);
            this.Carnívoro = false;
            this.Peconhento = false;
            this.Rapina = false;
            this.CorPena = corPena;
        }


        public int AlitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool BotouOvo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Botar()
        {
            Console.WriteLine($"O {this.Nome} está botando um ovo...");
            Thread.Sleep(3000);
            Console.WriteLine($"O {this.Nome} botou um ovo!");
            this.BotouOvo = true;
        }

        public void Chocar()
        {
            Console.WriteLine($"O {this.Nome} está chocando o ovo...");
            Thread.Sleep(3000);
            Console.WriteLine($"Ovo chocado!");
            this.BotouOvo = false;
        }
    }
}