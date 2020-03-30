using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresConsulta
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample01();

            Console.ReadKey();
        }

        static void Sample01()
        {
            List<string> lista = new List<string>();

            lista.Add("José Luis");
            lista.Add("Martín");
            lista.Add("Luisa");


            Console.WriteLine("First " + lista.First());
            Console.WriteLine("Last " + lista.Last());
            Console.WriteLine("Count " + lista.Count());

        }

        
    }
}
