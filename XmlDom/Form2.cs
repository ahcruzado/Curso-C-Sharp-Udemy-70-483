using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XmlDom
{
    public partial class Form2 : Form
    {
        XmlDocument doc;
        XPathNavigator navegador;
        public Form2()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Application.StartupPath,
                Title = "Abrir Archivo",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog.FileName;
            }
        }

        private void CargarArchivoXml(string archivo, TextBox nombreTextBox)
        {
            var fich = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            var str = new StreamReader(fich);

            str.BaseStream.Seek(0, SeekOrigin.Begin);

            nombreTextBox.Text = str.ReadToEnd();
            str.Close();

        }
        
        private void CargarButton_Click(object sender, EventArgs e)
        {
            CargarArchivoXml(this.Text, CargaTextBox);

            doc = new XmlDocument();
            doc.Load(this.Text);

            navegador = doc.CreateNavigator();
        }

        private void BuscarNodoButton_Click(object sender, EventArgs e)
        {
            string datos = string.Empty;
            XPathNodeIterator nodos = navegador.Select(BuscarNodoTextBox.Text);

            while (nodos.MoveNext())
            {
                datos += nodos.Current.OuterXml + Environment.NewLine;
            }

            BuscarNodoResultTextBox.Text = datos;
        }

        private void BuscarCursoButton_Click(object sender, EventArgs e)
        {

        }

        private void AgregarNodoButton_Click(object sender, EventArgs e)
        {
            string xPath = "/curso/informatica[@tipo = 'presencial']/datos";
            XPathNodeIterator nodos = navegador.Select(xPath);
            nodos.MoveNext();
            nodos.Current.AppendChild("<curso hora = 'noche'>SQL Server </curso>");

            var rutaArchivo = Path.Combine(Application.StartupPath, "Curso4.xml");
            doc.Save(rutaArchivo);

            CargarArchivoXml(rutaArchivo, AgregarNodoTextBox);
        }
    }
}
