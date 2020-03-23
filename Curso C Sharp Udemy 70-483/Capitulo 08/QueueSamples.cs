using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class QueueSamples
    {
        public static void Run()
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();
        }

        public static void Sample01()
        {
            Queue cola = new Queue();
            cola.Enqueue("cadena");
            cola.Enqueue(18);
            cola.Enqueue(87.3);

            
            Console.WriteLine("El número de elementos de la cola es: " + cola.Count);
            Console.WriteLine("Se pide un elemento ");

            object ultimoElemento = cola.Dequeue();

            Console.WriteLine("El primer elemento en salir es: " + ultimoElemento.ToString());
            Console.WriteLine("El número de elementos de la cola es: " + cola.Count);

        }

        public static void Sample02()
        {
            Queue cola = new Queue();
            char continuar = 's';
            string opcion = "0";
            do
            {
                Console.Clear();
                Console.WriteLine("-------MENU---------");
                Console.WriteLine("1 Ingresar elemento");
                Console.WriteLine("2 Contar elementos");
                Console.WriteLine("3 Buscar elementos");
                Console.WriteLine("4 Limpiar Cola");
                Console.WriteLine("5 Salir");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Selecciones una opción");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Escriba el elemento a ingresar");
                        cola.Enqueue(Console.ReadLine());
                        Console.WriteLine("elemento ingresado");
                        break;

                    case "2":
                        Console.WriteLine(cola.Count + " elementos");
                        break;

                    case "3":
                        if (cola.Contains(Console.ReadLine()))
                        {
                            Console.WriteLine("Elemento encontrado");

                        }
                        else
                        {
                            Console.WriteLine("Elemento no encontrado");
                        }
                        break;

                    case "4":
                        cola.Clear();
                        Console.WriteLine(cola.Count + "elementos");
                        break;

                    case "5":
                        continuar = 'x' ;
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
               

            } while (continuar.ToString().ToLower() == "s");

            Console.ReadKey();
        }
    }
}
