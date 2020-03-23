using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class Producto:IComparable
    {

        private string codigo;
        private string nombre;
        private double precio;

        public Producto(string codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Codigo
        {
            get { return codigo; }
        }

        public string Nmbre
        {
            get { return nombre; }
        }

        public double Precio
        {
            get { return precio; }
        }

        public int CompareTo(object obj)
        {
            Producto otroProducto= (Producto)obj;

            if (this.nombre != otroProducto.nombre)
            {
                return this.nombre.CompareTo(otroProducto.nombre);
            }
            else
            {
                return this.precio.CompareTo(otroProducto.precio);
            }
        }

        public override string ToString()
        {
            return codigo + " - " + nombre.ToUpper();
        }
    }
}
