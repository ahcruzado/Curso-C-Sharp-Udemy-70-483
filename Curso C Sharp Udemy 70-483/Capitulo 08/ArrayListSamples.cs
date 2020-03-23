using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class ArrayListSamples
    {
        public static void Run()
        {
            Console.WriteLine("EJEMPLOS ARRAYLIST");
            Console.WriteLine(Environment.NewLine);

            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("FINAL ARRAYLIST 08");
            Console.WriteLine(Environment.NewLine);


        }

        public static void Sample01()
        {
            ArrayList arli = new ArrayList();

            arli.Add(2);
            arli.Add("dos");
            arli.Add(12.5);

            arli.Insert(2, true);
            arli.RemoveAt(2);
            arli.Remove("dos");

            Console.WriteLine("arli.Count = " + arli.Count);

            foreach (object o in arli)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public static void Sample02()
        {
            Clientes cli = new Clientes();

            cli.Agregar("Jose Perez");
            cli.Agregar(new string[] { "Cliente3","Cliente1", "Cliente2", "Cliente4" });
            cli.Editar("Cliente2", "María Sanchez");
            cli.Eliminar("Cliente4");
            cli.Ordenar();
            cli.SelectClientes();
        }
        }
    }
