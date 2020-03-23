using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class CollectionsSamples
    {
        public static void Run()
        {
            Console.WriteLine("EJEMPLOS COLLECTIONS");
            Console.WriteLine(Environment.NewLine);
            Sample01();


            Console.WriteLine("FINAL COLLECTIONS");

        }

        public static void Sample01()
        {
            ArrayList al = new ArrayList();
            Queue cola = new Queue();
            Stack pila = new Stack();
            Hashtable table = new Hashtable();
            SortedList list = new SortedList();
            Dictionary<int, string> dic = new Dictionary<int, string>();

            Figura<double> fig = new Figura<double>();
            fig.Tamaño = 45.6;
            Console.WriteLine(fig.Tamaño.ToString());

            al.Add(23);
            al.Add("hola");
            al.Add(true);

            for (int d= 0; d<al.Count; d++)
            {
                Console.WriteLine(al[d].ToString());
            }
        }

    }
}
