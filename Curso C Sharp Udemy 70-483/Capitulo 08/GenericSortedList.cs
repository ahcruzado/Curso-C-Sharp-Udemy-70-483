using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class GenericSortedList
    {

        public static void Run()
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();
            Console.WriteLine(Environment.NewLine);
            Sample03();

        }

        public static void Sample01()
        {
            SortedList<int, string> sList = new SortedList<int, string>();

            sList.Add(4, "cuatro");
            sList.Add(3, "tres");
            sList.Add(1,"uno");
            sList.Add(2, "dos");
                        

            for (int i=0; i<sList.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1} ", sList.Keys[i].ToString(), sList.Values[i].ToString());
            }

        }

        public static void Sample02()
        {
            SortedList<int, string> sList = new SortedList<int, string>();

            sList.Add(4, "cuatro");
            sList.Add(3, "tres");
            sList.Add(1, "uno");
            sList.Add(2, "dos");

            string valor;

            if (sList.TryGetValue(3, out valor))
            {
                Console.WriteLine("El valor de la clave 3 es " + valor);
            }
            else
            {
                Console.WriteLine("Clave no encontrada");
            }
        }

        public static void Sample03()
        {
            SortedList<int, string> sList = new SortedList<int, string>();

            sList.Add(4, "cuatro");
            sList.Add(3, "tres");
            sList.Add(1, "uno");
            sList.Add(2, "dos");

            bool containsKey = sList.ContainsKey(2);
            bool containsValue = sList.ContainsValue("dos");

            Console.WriteLine("ContainsKey(2) devolvió " + containsKey.ToString());
            Console.WriteLine("ContainsValue('dos') devolvió " + containsValue.ToString());
        }

    }
}
