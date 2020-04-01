using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace CriptoAsimetrico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarClaveButton_Click(object sender, EventArgs e)
        {
            ClaseEncriptacion crypto = new ClaseEncriptacion();
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.SelectedPath = Application.StartupPath;

            if (f.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                string carpeta = f.SelectedPath;

                FileStream fichero = new FileStream(Path.Combine(carpeta, "ClavePublic.xml"), FileMode.Create, FileAccess.Write);
                byte[] clavePublica = crypto.CrearClavesPublicas();
                fichero.Write(clavePublica, 0, clavePublica.Length);
                fichero.Close();

                fichero = new FileStream(Path.Combine(carpeta, "ClavePrivate.xml"), FileMode.Create, FileAccess.Write);
                byte[] clavePrivada = crypto.CrearClavesPrivadas();
                fichero.Write(clavePrivada, 0, clavePrivada.Length);
                fichero.Close();

                MessageBox.Show("Claves Almacenadas corrextamente");
            }
        }

        private void EncriptarButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Archivos Xml (*.xml)|*.xml";
            od.InitialDirectory = Application.StartupPath;

            if (od.ShowDialog() == DialogResult.OK)
            {
                Stream temporal = od.OpenFile();
                string clavePublicaXml = new StreamReader(temporal).ReadToEnd();
                byte[] datosEncriptados = ClaseEncriptacion.EncriptarTexto(this.MensajeTextBox.Text, clavePublicaXml);
                var temp = Convert.ToBase64String(datosEncriptados);
                this.MensajeTextBox.Clear();
                this.MensajeTextBox.Text = temp;
            }
        }

        private void DesencriptarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Archivos Xml (*.xml)|*.xml";
            od.InitialDirectory = Application.StartupPath;

            if (od.ShowDialog() == DialogResult.OK)
            {
                Stream temporal = od.OpenFile();
                string clavePrivadaXml = new StreamReader(temporal).ReadToEnd();
                byte[] datosDesencriptados = ClaseEncriptacion.DesencriptarTexto(this.MensajeTextBox.Text, clavePrivadaXml);
                var temp = Encoding.ASCII.GetString(datosDesencriptados);
                this.ResultadoTextBox.Text = temp;
            }

        }
    }
}
