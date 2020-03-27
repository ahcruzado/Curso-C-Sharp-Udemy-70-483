using System;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {

        Calculadora cal;
        Mascota gato= new Gato("tom");
        Mascota perico = new Perico("Peric");
        Lista<string> lista;
        public Form1()
        {
            InitializeComponent();
            cal = new Calculadora(23.5,4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cal.Sumar(1,43);
            //double r = cal.Sumar( 45.2);
            //MessageBox.Show(r.ToString());
            //MessageBox.Show(gato.Saludar());
            //MessageBox.Show(perico.Saludar());

            lista = new Lista<string>(10);

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            lista.AgregarElemento(ElementoTextBox.Text, lista.Count());
        }

        private void ObtenerElementoButton_Click(object sender, EventArgs e)
        {
            int indice;
            if (int.TryParse(this.ElementoTextBox.Text, out indice))
            {
                MessageBox.Show(lista.ObtenerElemento(indice));
            }
        }
    }
}
