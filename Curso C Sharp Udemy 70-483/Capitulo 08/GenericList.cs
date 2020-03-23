using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class GenericList
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

        }

        public static void Sample01()
        {
            List<string> milista = new List<string>();

            milista.Add("23");
            milista.Add("hello");
            milista.Insert(0, "uno");

            Console.WriteLine(milista[0]);
        }

        public static void Sample02()
        {
            List<string> milista = new List<string>();

            milista.Capacity = 5;

            milista.Add("23");
            milista.Add("hello");
            milista.Insert(0, "uno");
            milista.Add("string");
            milista[1] = "ventitres";
            milista.Add("elemento");

            Console.WriteLine("La lista tiene una cantidad de: {0}", milista.Count);
            Console.WriteLine("La lista tiene una capacidad de: {0}", milista.Capacity);

            //exception
            //milista.Add("elemento que excede capacity");

        }

        public static void Sample03()
        {
            List<Producto> milista = new List<Producto>();

            milista.Add(new Producto("PROD001", "Avena", 6.23));
            milista.Add(new Producto("PROD002", "Leche", 1.87));
            milista.Add(new Producto("PROD003", "Mermelada", 2.45));
            milista.Add(new Producto("PROD004", "Gelatina", 5.23));            

            foreach (Producto p in milista)
            {
                Console.WriteLine(p + ", " + p.Precio.ToString());
            }

        }

        public static void Sample04()
        {
            List<Producto> milista = new List<Producto>();

            milista.Add(new Producto("PROD001", "Avena", 6.23));
            milista.Add(new Producto("PROD002", "Leche", 1.87));
            milista.Add(new Producto("PROD003", "Mermelada", 2.45));
            milista.Add(new Producto("PROD004", "Avena", 5.23));

            milista.Sort();

            foreach (Producto p in milista)
            {
                Console.WriteLine(p + ", " + p.Precio.ToString());
            }

        }

    }
}
