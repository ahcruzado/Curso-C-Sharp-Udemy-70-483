using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Expresion
    {
        public static void SampleFunc()
        {
            Func<string, int, int, decimal> H;
            H = (msg, a, b) => Add(msg, a, b);
            H("Mensaje", 5,5);
        }

        public static decimal Add(string msg, int a ,int b)
        {
            var result= a + b;
            Console.WriteLine($"{msg} {a} {b} {result}");
            return result;
        }

        public static void SampleLambda()
        {
            Func<String, int, int, decimal> V;
            V = (msg, a, b) =>
              {
                  Console.WriteLine($"{msg} {a} {b}");
                  return a + b;
              };

            V("Mensaje 2", 10,10);
        }
    }
}
