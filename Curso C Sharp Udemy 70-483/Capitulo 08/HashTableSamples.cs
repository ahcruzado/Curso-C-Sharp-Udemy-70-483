using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class HashTableSamples
    {
        public static void Run()
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();
        }

        public static void Sample01()
        {
            Hashtable tabla = new Hashtable();

            tabla.Add("1", 34.45);
            tabla.Add("2", 56.23);
            tabla.Add("3", 34.67);
            tabla.Add("4", 12.6);

            bool encontrado = tabla.Contains("3");

            Console.WriteLine("El valor del elemento 3 es: " + tabla["2"].ToString());
            Console.WriteLine("Encontrado " + encontrado.ToString());

            encontrado = tabla.ContainsValue(34.6);                
        }

        public static void Sample02()
        {
            Hashtable tabla = new Hashtable();

            tabla.Add("1", 34.45);
            tabla.Add("2", 56.23);
            tabla.Add("3", 34.67);
            tabla.Add("4", 12.6);

            foreach (DictionaryEntry de in tabla)
            {
                Console.WriteLine("Key = {0}, Value = {1}",de.Key,de.Value);
            }
            
        }

    }
}
