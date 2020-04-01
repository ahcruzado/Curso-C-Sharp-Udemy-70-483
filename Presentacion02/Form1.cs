using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Presentacion02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFile(Application.StartupPath + @"\Libreria.dll");

            Type[] tipos = assembly.GetTypes();

            foreach (var t in tipos)
            {
                if (t.IsClass)
                    this.ClasesListBox.Items.Add(t.ToString());
            }

            FieldInfo[] fields = tipos[0].GetFields();

            foreach (var campo in fields)
            {
                AtributosListBox.Items.Add(campo.Name);
            }

            MethodInfo[] methods = tipos[0].GetMethods();

            foreach (var m in methods)
            {
                MetodosListBox.Items.Add(m.Name);
            }

            string[] nombres = new string[] { "nombre persona" };
            object instance = Activator.CreateInstance(tipos[0],nombres);

            object[] parameters = null;// { "Ernesto" };
            //methods[1].Invoke(instance, parameters);
            methods[0].Invoke(instance, parameters);

        }
    }
}
