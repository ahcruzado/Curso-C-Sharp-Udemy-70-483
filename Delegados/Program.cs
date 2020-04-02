using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {

        delegate void OperacionDelegate();
        delegate int OperacionDelegate2(int x, int b);

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

            Sample05();
            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
        }

        private static void Sample01()
        {
            OperacionDelegate dlg = Message;
            dlg();
        }

        private static void Sample02()
        {
            OperacionDelegate2 dlg = Message;

            Console.WriteLine(dlg(2,2));
        }

        private static void Sample03()
        {
            Action a = ActionMessage;
            a();
        }

        private static void Sample04()
        {
            Func<int, int, int> f = Sumar;
            Console.WriteLine(f(1,5));
        }

        private static void Sample05()
        {
            string a, b;
            int result = 0;

            Division op = new Division();
            op.MessageHanlder = ShowMessage;

            Console.WriteLine("Ingrese el Operador 1");
            a = Console.ReadLine();

            Console.WriteLine("Ingrese el Operador 2");
            b = Console.ReadLine();

            result = op.Divide(Convert.ToInt32(a), Convert.ToInt32(b));
            Console.WriteLine($"Resultado: {result}");
        }

        public static void ShowMessage(int a, int b)
        {
            Console.WriteLine($"División entre cero, {a} - {b}");
        }

        private static void ActionMessage()
        {
            Console.WriteLine("Mensaje Action");

        }

        static void Message()
        {
            Console.Write("Un mensaje");
        }

        static int Message(int x, int y)
        {
            return x + y;
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

    }
}
