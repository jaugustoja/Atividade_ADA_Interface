using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Interfaces
{
    public interface IOviparo
    {
        public bool BotouOvo { get; set; }
        //Métodos
        public void Botar();
        public void Chocar();
    }
}