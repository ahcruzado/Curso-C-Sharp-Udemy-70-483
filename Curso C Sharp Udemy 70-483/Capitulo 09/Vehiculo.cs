using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483.Capitulo_09
{

    //clas base
    public class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected double kilometraje;
        protected int velocidad;

        public Vehiculo()
        {}

        public Vehiculo(string marca, string modelo, double kilometraje, int velocidad)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.kilometraje = kilometraje;
            this.velocidad = velocidad;
        }

        public override string ToString()
        {
            return "Vehículo => Marca: " + marca + " Modelo: " + modelo;
        }

        public void AumentarKilometraje(int k)
        {
            this.kilometraje += k;
        }

        public double Kilometraje
        {
            get
            {
                return kilometraje;
            }
        }

        public virtual void CambiarColor(string color)
        {
            Console.WriteLine("No se ha asignado ningún color");
        }
    }
}
