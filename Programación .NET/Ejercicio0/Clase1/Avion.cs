using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Avion : Vehiculo, IContadorRuedas
    {
        public Avion(string modelo, string marca) : base (marca, modelo) {

        }

        public void volar()
        {
            Console.WriteLine("Volar");
        }
        public override void tipoCombustible()
        {
            Console.WriteLine("Queroseno");
        }

        public int contador() {

            return 6;
        }

    }
}
