using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlDom
{
    public partial class Xml : Form
    {
        public Xml()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Application.StartupPath,
                Title = "Buscar Archivo",
                DefaultExt = "xml",
                Filter = "xml files(*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                this.Text = openFileDialog.FileName;
            }
        }

        private void CargarButton_Click(object sender, EventArgs e)
        {
            XmlTextReader xtr = new XmlTextReader(this.Text);
            var datos = String.Empty;

            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name=="curso")
                {
                    string s1 = xtr.ReadElementContentAsString();
                    //string s1 = xtr.ReadElementContentAsObject().ToString();
                    //string s1 = xtr.ReadContentAsString();                    
                    datos += s1 + Environment.NewLine;
                }
            }

            CargaTextBox.Text = datos;
        }

        private void CargaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
