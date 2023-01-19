using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public abstract class Animal
    {
        //Propriedades
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnívoro { get; set; }
        public bool Peconhento { get; set; }
        protected List<string> Estômago = new List<string>();

    
        //Métodos
        public void Movimentar()
        {
            Console.WriteLine($"{this.Nome} se movimentando...");
            Thread.Sleep(3000);
        }

        public void Comunicar()
        {
            Console.WriteLine($"{this.Nome} se comunicando com seus semelhantes...");
            Thread.Sleep(3000);
        }

        public void Alimentar()
        {
        
            switch(this.Carnívoro)
            {
                case true:
                    if (Estômago.Count < 3)
                    {
                        Console.WriteLine("Comendo restos de animais...");
                        Estômago.Add("Restos de animais");
                    }
                    else
                    {
                        Console.WriteLine("Estômago cheio.");
                        Console.WriteLine("Fazendo Digestão...");
                        Thread.Sleep(3000);

                        Estômago.Clear();
                        Console.WriteLine("Estomago vazio!");
                        Thread.Sleep(3000);
                        Console.WriteLine("Comendo restos de animais...");
                        Estômago.Add("Restos de Animais");
                        Thread.Sleep(3000);
                    }
                    break;

                case false:

                    List<string> alimentosHerbivoros = new List<string>() { "Algas", "Plantas", "Frutas" };

                    if (this.Estômago.Count < 3)
                    {
                        Console.WriteLine($"O {this.Nome} irá se alimentar de algas, plantas ou frutas?");
                        string alimento = Console.ReadLine().ToLower();
                        switch(alimento)
                        {
                            case "algas":
                                Console.WriteLine("Comendo algas...");
                                Estômago.Add("Algas");
                                break;
                            case "plantas":
                                Console.WriteLine("Comendo plantas...");
                                Estômago.Add("Plantas");
                                break;
                            case "frutas":
                                Console.WriteLine("Comendo frutas...");
                                Estômago.Add("Frutas");
                                break;
                            default:
                                Console.WriteLine($"O {this.Nome} não se alimentou pois não come o alimento fornecido.");
                                break;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Estômago cheio.");
                        Console.WriteLine("Fazendo Digestão...");
                        Thread.Sleep(3000);

                        Estômago.Clear();
                        Console.WriteLine("Estomago vazio!");
                        Thread.Sleep(3000);
                        Console.WriteLine($"O {this.Nome} irá se alimentar de algas, plantas ou frutas?");
                        string alimento = Console.ReadLine().ToLower();
                        switch(alimento)
                        {
                            case "algas":
                                Console.WriteLine("Comendo algas...");
                                Estômago.Add("Algas");
                                break;
                            case "plantas":
                                Console.WriteLine("Comendo plantas...");
                                Estômago.Add("Plantas");
                                break;
                            case "frutas":
                                Console.WriteLine("Comendo frutas...");
                                Estômago.Add("Frutas");
                                break;
                            default:
                                Console.WriteLine($"O {this.Nome} não se alimentou pois não come o alimento fornecido.");
                                Thread.Sleep(3000);
                                break;
                        }

                    }
                    break;

            }

            Console.WriteLine($"Alimentos no estômago do {this.Nome}:");

            int contador = 0;
            foreach(string alimentos in Estômago)
            {
                contador++;
                Console.WriteLine($"{contador} - {alimentos}");
            }
            
        }



    }
}