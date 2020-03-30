using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;

        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;             
        }

        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }

        public int Edad { get { return edad; } }
    }
}
