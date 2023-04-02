using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Vehiculo
    {
        public string marca;
        public string modelo;
        public int ruedas;
        public int contadores;

        public Vehiculo(String marca, String modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public int Ruedas
        {
            set { ruedas = value; }
            get { return ruedas; }
        }

        public void avanzar()
        {
            Console.WriteLine("Avanzando");
        }
        public void frenar()
        {
            Console.WriteLine("Frenando");
        }

        public virtual void tipoCombustible()
        {
            Console.WriteLine("Gasolina");
        }


    }
}