using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hilos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Sample01();
            Sample02();
            Console.ReadKey();
        }

        static void Sample01()
        {
            Console.WriteLine("Inicio del proceso 1");

            ThreadStart delegado = new ThreadStart(Metodo);
            Thread hilo = new Thread(delegado);
            Thread.Sleep(3000);
            hilo.Start();
            Console.WriteLine("Finalización del proceso 1");            
        }

        static void Sample02()
        {
            Thread hilo1 = new Thread(new ThreadStart(Tarea1));
            Thread hilo2 = new Thread(new ThreadStart(Tarea2));
            hilo1.Start();
            hilo2.Start();
            hilo1.Priority = ThreadPriority.Highest;
            hilo2.Priority = ThreadPriority.Lowest;
        }

        private static void Metodo()
        {
            Console.WriteLine("Inicio del Método");
            Console.WriteLine("Finalización del Método");
        }

        static void Tarea1()
        {
            for (int x = 1; x <= 10; x++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Tarea01 {0}", x);
            }
        }

        static void Tarea2()
        {
            for (int x = 11; x <= 20; x++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Tarea02 {0}", x);
            }
        }


    }
}
