using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    class StackSamples
    {

        public static void Run()
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();
            Console.WriteLine(Environment.NewLine);
            Sample03();
            Console.WriteLine(Environment.NewLine);
            Sample04();
            Console.WriteLine(Environment.NewLine);

        }

        public static void Sample01()
        {
            Stack pila = new Stack();
            pila.Push(34);
            pila.Push("string");
            pila.Push(true);
            pila.Push(34.6);

            Console.WriteLine("La cantidad de elementos de la pila es: " + pila.Count);

            var lastElement = pila.Pop();

            Console.WriteLine("Sacamos (con el método Pop) el último elemento de la pila que es: " + lastElement.ToString());

            Console.WriteLine("La cantidad de elementos de la pila es: " + pila.Count);

        }

        public static void Sample02()
        {
            Stack pila = new Stack();
            pila.Push(34);
            pila.Push("string");
            pila.Push(true);
            pila.Push(34.6);

            Console.WriteLine("La cantidad de elementos de la pila es: " + pila.Count);

            var lastElement = pila.Peek();

            Console.WriteLine("Obtenemos sin quitar (con el método Peek) el último elemento de la pila que es: " + lastElement.ToString());

            Console.WriteLine("La cantidad de elementos de la pila es: " + pila.Count);

        }

        public static void Sample03()
        {
            Libros libreria = new Libros();
            Console.WriteLine("Ingrese elementos:");
            libreria.IngresarLibro(6);
            string valor = libreria.DeveolverUltimoElemento().ToString();

            Console.WriteLine("El último elemento es: " + valor);
            Console.WriteLine("La cantidad de elementos de Libros es:" + libreria.ContarLibros());

            Console.WriteLine("Ingrese el libro que quiere consultrar: ");
            object elemento = Console.ReadLine();

            if (libreria.ConsultarLibro(elemento))
            {
                Console.WriteLine("Libro encontrado");
            }
            else
            {
                Console.WriteLine("Libro no encontrado");
            }

        }

        public static void Sample04()
        {
            Libros libreria = new Libros();
            Console.WriteLine("Ingrese elementos:");
            libreria.IngresarLibro(3);
            Console.WriteLine("La cantidad de elementos de Libros es:" + libreria.ContarLibros());

            Console.WriteLine("Desea retirar algún libro (s/n): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s" || respuesta.ToLower() == "si")
            {
                libreria.RetirarLibro();
            }

            Console.WriteLine("La cantidad de elementos de Libros es:" + libreria.ContarLibros());
            Console.WriteLine("Limpiando librería:" + libreria.ContarLibros());

            libreria.LimpiarLibros();

            Console.WriteLine("La cantidad de elementos de Libros es:" + libreria.ContarLibros());
        }



    }
}
