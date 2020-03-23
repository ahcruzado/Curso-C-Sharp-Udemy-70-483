using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class ArraySamples
    {
        public static void Run()
        {
            Console.WriteLine("EJEMPLOS ARRAY");
            Console.WriteLine(Environment.NewLine);

            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();
            Console.WriteLine(Environment.NewLine);
            Sample03();
            Console.WriteLine(Environment.NewLine);
            Sample04();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("FINAL ARRAYS 08");
            Console.WriteLine(Environment.NewLine);

           
        }

        public static void Sample01()
        {
            Console.WriteLine("Sample 01 -- Initializing array with 'new int[20]'");
            int[] myarray = new int[20];
            myarray[0] = 2;
            myarray[3] = 5;
            Console.WriteLine("myarray.Length = " + myarray.Length.ToString());
            Console.WriteLine("Initialize array in old Vb 06 (20) return got an array with 21 elements");
            Console.WriteLine("Element in index 3 = " + myarray[3]);
            
            
        }

        public static void Sample02()
        {
            Console.WriteLine("Sample 02 -- Initializing array with 'new bool[] { true, false,false}'");
            bool[] myarray = new bool[] { true, false,false};

            Console.WriteLine("myarray.Length = " + myarray.Length.ToString());            
        }

        public static void Sample03()
        {
            Console.WriteLine("Sample 03 -- Initerating Array");
            string[] myarray = new string[4];

            myarray[0] = "2";
            myarray[1] = "hola";
            myarray[2] = "dos";
            myarray[3] = "5";

            foreach(string element in myarray)
            {
                Console.WriteLine(element);
            }

        }

        public static void Sample04()
        {
            Console.WriteLine("Sample 04 -- array multidimencional'");
            string[,] myarray = new string[3,2];

            //file one
            myarray[0, 0] = "file 0, column 0";
            myarray[0, 1] = "file 0, column 1";

            //file two
            myarray[1, 0] = "file 1, column 0";
            myarray[1, 1] = "file 1, column 1";

            //file three
            myarray[2, 0] = "file 2, column 0";
            myarray[2, 1] = "file 2, column 1";

            for (int f = 0; f<= myarray.GetUpperBound(0); f++)
            {
                for (int c =0; c<= myarray.GetUpperBound(1); c++)
                {
                    Console.WriteLine(myarray[f, c].ToString());
                }
                Console.WriteLine();
            }

        }


    }
}
