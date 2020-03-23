using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class GenericDictionary
    {

        public static void Run()
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();

        }

        public static void Sample01()
        {
            //Dictionary<string, string> midic = new Dictionary<string, string>();
            IDictionary<string, string> midic = new Dictionary<string, string>();

            midic.Add("clave1", "valor1");
            midic.Add("clave2", "valor2");
            midic.Add("clave3", "valor3");

            midic.Add(new KeyValuePair<string, string>("clave4", "valor4"));

            foreach(KeyValuePair<string,string> par in midic)
            {
                Console.WriteLine("Key: {0}, value: {1}", par.Key, par.Value);
            }
        }

        public static void Sample02()
        {            
            IDictionary<string, string> midic = new Dictionary<string, string>();

            midic.Add("clave1", "valor1");
            midic.Add("clave2", "valor2");
            midic.Add("clave3", "valor3");
            midic.Add(new KeyValuePair<string, string>("clave4", "valor4"));

            string value;

            if (midic.TryGetValue("clave3", out value))
            {
                Console.WriteLine("El calor encontrado mediante Key = clave3 es {0}", value);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    }
}
