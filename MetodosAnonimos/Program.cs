using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimos
{
    class Program
    {
        delegate void ShowMessageDelegate();

        static void Main(string[] args)
        {
            Sample01();
            Sample02();
            Sample03();
            Sample04();
            Sample05();
            Sample06();
            Console.ReadKey();
        }

        static void Sample01()
        {
            Action E = ShowMessage;
            E();

        }

        static void Sample02()
        {
            Action D = delegate ()
            {
                Console.WriteLine("Mensaje Método anonimo");
            };

            D();
        }

        static void Sample03()
        {
            ShowMessageDelegate D = delegate ()
            {
                Console.WriteLine("Mensaje Método anonimo con delegado");
            };

            D();
        }

        static void Sample04()
        {
            Action<string> s;

            s = delegate (string message)
              {
                  Console.WriteLine(message);
              };

            s("mensaje con delegado parametrizado");
        }

        static void Sample05()
        {
            Func<int, int, int> F = Add;
            var result = F(2, 4);
            Console.WriteLine(result);
        }

        static void Sample06()
        {
            Func<int, int, int> F = delegate (int a, int b)
            {
                return a + b;
            };

            var result=F(2, 4);
            Console.WriteLine(result);
        }

        static void ShowMessage()
        {
            Console.WriteLine("Messaje");
        }

        static void ParametrizedShowMessage(string messag)
        {
            Console.WriteLine("Messaje");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
