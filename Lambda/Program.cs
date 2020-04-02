using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);

            Sample02();
            Console.WriteLine(Environment.NewLine);

            Sample03();
            Console.WriteLine(Environment.NewLine);

            Sample04();
            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
        }

        static void Sample01()
        {
            Console.WriteLine("SAMPLE 02");

            Action D;
            D = MT1;
            D();

            Console.WriteLine(Environment.NewLine);

            D += () => Console.WriteLine("Metodo 2");
            D();
        }

        static void Sample02()
        {
            Console.WriteLine("SAMPLE 02");
            Action D;
            D = MT1;
            D();

            Console.WriteLine(Environment.NewLine);

            D += () => Console.WriteLine("Metodo 2");

            D += delegate ()
             {
                 Console.WriteLine("Esperando 5 segundos.");
                 Console.WriteLine(Environment.NewLine);

                 for (int i = 0; i <= 4; i++)
                 {
                     Console.Write(".");
                     Thread.Sleep(1000);
                 };

                 Console.WriteLine(Environment.NewLine);
                 Console.WriteLine("Metodo 3");
             };

            D();
        }

        static void Sample03()
        {
            Console.WriteLine("SAMPLE 03");
            Expresion.SampleFunc();
        }

        static void Sample04()
        {
            Console.WriteLine("SAMPLE 04");
            Expresion.SampleLambda();
        }


        static void MT1()
        {
            Console.WriteLine("Metodo 1");
        }
    }
}
