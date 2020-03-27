using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract class Mascota
    {
        protected string nombre;
        protected int edad;

        public abstract string Saludar();
    }

    class Gato:Mascota
    {
        public Gato(string nombre):base()
        {
            this.nombre = nombre;
        }
        public override string Saludar()
        {
            return "hola soy un gato y mi nombre es " + this.nombre;
        }
    }

    class Perico:Mascota
    {

        public Perico(string nombre) : base()
        {
            this.nombre = nombre;
        }

        public override string Saludar()
        {
            return "hola soy un perico y mi nombre es " + this.nombre;
        }
    }

}
