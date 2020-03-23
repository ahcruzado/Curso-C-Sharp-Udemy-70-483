using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class Libros
    {

        private Stack pilaDb = new Stack();
        public void IngresarLibro(int numero)
        {
            for (int c = 1; c <= numero; c++)
            {
                object elemento = Console.ReadLine();
                pilaDb.Push(elemento);
            }
        }

        public object RetirarLibro()
        {
            object elemento = pilaDb.Pop();
            return elemento;

        }

        public bool ConsultarLibro(object busqueda)
        {
            bool encontrado = false;
            encontrado = pilaDb.Contains(busqueda);
            return encontrado;
        }

        public object DeveolverUltimoElemento()
        {
            object elemento = pilaDb.Peek();
            return elemento;
        }

        public void LimpiarLibros()
        {
            pilaDb.Clear();
        }

        public int ContarLibros()
        {
            return pilaDb.Count;
        }
    }
}
