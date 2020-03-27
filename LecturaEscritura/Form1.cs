using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LecturaEscritura
{
    public partial class Form1 : Form
    {

        string ruta = Application.StartupPath + @"\archivo.txt";        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BuferedStreamSample();
            //StreamWriterSample();
            //StreamReaderSample();
            AppendTextSample();
        }

        private void BuferedStreamSample()
        {
            Stream st = File.OpenRead(ruta);
            BufferedStream buf = new BufferedStream(st);
            byte[] b = new byte[128];

            buf.Read(b, 0, 128);

            MessageBox.Show("El arreglo contiene: " + Encoding.ASCII.GetString(b));
        }

        private void StreamWriterSample()
        {
            StreamWriter wri = new StreamWriter(ruta);
            wri.Write("Hola soy StreamWriter");
            wri.Close();
        }

        private void StreamReaderSample()
        {
            StreamReader re = new StreamReader(ruta);
            //MessageBox.Show(re.ReadToEnd());
            this.textBox1.Text = re.ReadToEnd();
            re.Close();
        }

        private void AppendTextSample()
        {

            StreamWriter wri = File.AppendText(ruta);
            wri.Write(Environment.NewLine);
            wri.Write("más texto");
            wri.Close();

            StreamReader re = new StreamReader(ruta);            
            this.textBox1.Text = re.ReadToEnd();
            re.Close();
        }

    }
}
