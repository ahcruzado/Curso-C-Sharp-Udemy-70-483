using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionRemota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void RecuperarDatos(string url)
        {
            WebClient webClient = new WebClient();
            Stream stream= webClient.OpenRead(url);

            StreamReader reader = new StreamReader(stream);
            string respuesta = reader.ReadToEnd();
            reader.Close();

            this.RichTextBox1.Text = respuesta;

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            RecuperarDatos(UrlTextBox.Text);
        }
    }    
}
