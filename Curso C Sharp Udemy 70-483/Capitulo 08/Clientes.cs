using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class Clientes
    {

        private ArrayList db = new ArrayList();

        public void Agregar(string nombre)
        {
            db.Add(nombre);
        }

        public void Agregar(string[] nombres)
        {
            db.AddRange(nombres);
        }

        public void Editar(string edit, string element)
        {
            db[db.IndexOf(edit)] = element;
        }

        public void Eliminar(string element)
        {
            db.Remove(element);
        }

        public void SelectClientes()
        {
            foreach (object o in db)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void Ordenar()
        {
            db.Sort(new OrdenarDesc());
        }
    }
}
