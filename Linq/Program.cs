using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
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

            Console.ReadKey();
        }

        static void Sample01()
        {
            //1 fuente de datos
            int[] datos = new int[] { 2, 4, 7, 8, 15, 20, 12 };

            //2 crear consulta
            var consulta = from d in datos select d;

            //3 ejecutar consulta
            foreach(var c in consulta)
            {
                Console.WriteLine("Los elementos son: {0}", c);
            }
        }

        static void Sample02()
        {
            //1 fuente de datos
            int[] datos = new int[] { 2, 4, 7, 8, 15, 20, 12 };

            //2 crear consulta
            var consulta = from d in datos
                           where ((d % 2)==0)
                           select d;

            //3 ejecutar consulta
            foreach (var c in consulta)
            {
                Console.WriteLine("Los elementos son: {0}", c);
            }
        }

        static void Sample03()
        {
            Persona[] personas = {
                                    new Persona("Jose","Suarez",25),
                                    new Persona("Marco", "De la Fuente",34),
                                    new Persona("Pablo","Escobar",37)
                                    };

            IEnumerable<Persona> consulta = from p in personas
                                            where p.Edad > 30
                                            select p;


            foreach(var p in consulta)
            {
                Console.WriteLine(p.Nombre + " " + p.Apellidos);
            }
        }

    }
}
