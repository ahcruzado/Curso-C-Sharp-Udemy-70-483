using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void DelegadoCambiarProgreso(int valor);

        private void CambiarProgreso(int valor)
        {
            if (this.InvokeRequired)
            {
                DelegadoCambiarProgreso del = new DelegadoCambiarProgreso(CambiarProgreso);
                object[] parammetros = new object[] { valor };
                this.Invoke(del, parammetros);
            }
            else
            {
                progressBar1.Value = valor;
            }                       
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            //CambiarProgreso(50);
            //CorrerProceso();

            Thread hilo = new Thread(new ThreadStart(CorrerProceso));
            hilo.Start();
            
        }

        private void CorrerProceso()
        {
            //CheckForIllegalCrossThreadCalls = false;
            for (int i = 1; i<=progressBar1.Maximum; i++)
            {
                Thread.Sleep(100);
                CambiarProgreso(i);
            }
        }

        private void MensajeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje!!!");
        }
    }
}
