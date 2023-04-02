using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Bote : Vehiculo
    {
        public Bote(string modelo, string marca) : base(marca, modelo)
        {

        }
        public void remar() {
            Console.WriteLine("Está remando");
        }

 
    }
}
