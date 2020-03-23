using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class SortedListSamples
    {
        public static void Run()
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();   
        }

        public static void Sample01()
        {
            SortedList sort = new SortedList();
            
            sort.Add("5", "apellidos");
            sort.Add("3", "dirección");
            sort.Add("1", "nombre");

            foreach ( DictionaryEntry de in sort)
            {
                Console.WriteLine("Key = {0}, Value {1}", de.Key, de.Value);
            }


        }

        public static void Sample02()
        {
            SortedList sort = new SortedList();

            sort.Add("5", "apellidos");
            sort.Add("3", "dirección");
            sort.Add("1", "nombre");

            sort.SetByIndex(01, "Apodo");

            foreach (DictionaryEntry de in sort)
            {
                Console.WriteLine("Key = {0}, Value {1}", de.Key, de.Value);
            }



        }


    }
}
