using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483.Capitulo_09
{
    public class Carro:Vehiculo
    {

        private int codigoLicencia;
        private string color;

        public Carro()
        {

        }
        public Carro(string marca, string modelo, double kilometraje, int velocidad,int codigoLicencia, string color):
            base(marca,modelo,kilometraje,velocidad)
        {
            this.codigoLicencia = codigoLicencia;
            this.color = color;
        }
        public override void CambiarColor(string color)
        {
            this.color = color;
            Console.WriteLine("El color es {0}: ", this.color);
        }
    }
}
