using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class Vehiculo : IFuncion
    {
        public string Nombre
        {
            get
            {
                return "hola";
            }
            set
            {
                nombre = value;
            }
        }
        private string nombre;

        public string Encender()
        {
            return "Prendido";
        }
    }
}
