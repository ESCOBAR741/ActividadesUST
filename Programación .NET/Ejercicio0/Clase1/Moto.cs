using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Moto : Vehiculo, IContadorRuedas
    {
        public Moto(string modelo, string marca) : base(marca, modelo)
        {

        }


        public int contador()
        {

            return 2;
        }

    }
}
