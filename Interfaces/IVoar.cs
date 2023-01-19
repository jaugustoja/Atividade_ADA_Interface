using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Interfaces
{
    public interface IVoar
    {
        //Propriedades
        public int AlitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
    }
}