using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Musica;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Instrumeto ins;
        //public Vehiculo ve;
        public  IFuncion fun;

        public Form1()
        {
            InitializeComponent();
            //ins = new Guitarra();
            //ins =new Violin();
            //ve = new Vehiculo();
            fun = new Vehiculo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ins.Tocar());
            //MessageBox.Show(ve.Encender());
            MessageBox.Show(fun.Encender());
        }
    }
}
