using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public class Persona
    {
        public string Nombre;
        public int Edad;

        public Persona(string nombre)
        {
            this.Nombre = nombre;            
        }

        public void Saludar()
        {
            MessageBox.Show(Nombre);

        }
        
        public void Saludo(string nombre)
        {
            MessageBox.Show("Hola " + nombre);
        }
    }

    public class Humano
    {
        public char Genero;
        public bool Estado;
        public string Nombre()
        {
            return "Hombre";
        }
    }


    public enum Nombre
    {
        Juan, Pedro, Andreu
    }

}
