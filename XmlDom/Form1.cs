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

namespace XmlDom
{
    public partial class Form1 : Form
    {

        XmlDocument doc;
        XmlNodeList nodos;
        public Form1()
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

            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                this.Text = openFileDialog.FileName;                
            }
        }

        private void CargarButton_Click(object sender, EventArgs e)
        {
            CargarArchivoXml(this.Text, CargaTextBox);
            doc = new XmlDocument();
            doc.Load(this.Text);
        }

        private void CargarArchivoXml(string archivo, TextBox nombreTextBox)
        {
            var fich = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            var str = new StreamReader(fich);

            str.BaseStream.Seek(0, SeekOrigin.Begin);

            nombreTextBox.Text = str.ReadToEnd();
            str.Close();

        }

        private void BuscarNodoButton_Click(object sender, EventArgs e)
        {
            nodos = doc.GetElementsByTagName(BuscarNodoTextBox.Text);

            foreach (XmlNode nodo in nodos)
            {
                BuscarNodoListBox.Items.Add(nodo.Attributes["tipo"].Value);
            }

        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            nodos = doc.GetElementsByTagName("informatica");
            XmlAttribute att;

            foreach (XmlNode nodo in nodos)
            {
                if (nodo.Attributes["tipo"].Value=="presencial")
                {
                    att = doc.CreateAttribute("Codigo");
                    att.Value = "A001";
                    nodo.Attributes.Append(att);
                }

                if (nodo.Attributes["tipo"].Value == "online")
                {
                    att = doc.CreateAttribute("Codigo");
                    att.Value = "B001";
                    nodo.Attributes.Append(att);
                }
            }

            var rutaNuevoArchivo = Path.Combine(Application.StartupPath, "curso2.xml");
            doc.Save(rutaNuevoArchivo);

            CargarArchivoXml(rutaNuevoArchivo, this.ModifocacionTextBox);

            doc = new XmlDocument();
            doc.Load(rutaNuevoArchivo);

        }

        private void AgregarNodoButton_Click(object sender, EventArgs e)
        {
            nodos = doc.GetElementsByTagName("informatica");

            foreach (XmlElement nodo in nodos)
            {
                if (nodo.Attributes["tipo"].Value== "presencial")
                {
                    XmlNode n1;
                    XmlNode n2;
                    XmlNode n3;

                    n1 = doc.CreateNode(XmlNodeType.Element, "seguridad", "");
                    n2 = doc.CreateNode(XmlNodeType.Element, "curso", "");
                    n3 = doc.CreateNode(XmlNodeType.Text, "", "");
                    n3.Value = "Seguridad Informática";

                    n2.AppendChild(n3);
                    n1.AppendChild(n2);
                    nodo.AppendChild(n1);
                }
            }
            
            var rutaNuevoArchivo = Path.Combine(Application.StartupPath, "curso3.xml");
            doc.Save(rutaNuevoArchivo);

            CargarArchivoXml(rutaNuevoArchivo, AgregarNodoTextBox);
        }
    }
}
