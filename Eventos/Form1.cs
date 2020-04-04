using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {

        public delegate void CambiarSaldoEventHandler(string cliente, string cuenta, double saldo);

        public event CambiarSaldoEventHandler CambiarSaldo;

        public Form1()
        {
            InitializeComponent();
            this.CambiarSaldo += MetodoGestor;
        }

        private void DepositarButton_Click(object sender, EventArgs e)
        {
            Depositar(double.Parse(ImporteTextBox.Text));
        }

        private void RetirarButton_Click(object sender, EventArgs e)
        {
            Retirar(double.Parse(ImporteTextBox.Text));
        }

        double Saldo;
        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                Saldo = double.Parse(SaldoTextBox.Text) + cantidad;
                CambiarSaldo(ClienteTextBox.Text, CuentaTextBox.Text, Saldo);
            }
            else
                MessageBox.Show("Cantidad Inválida");
        }

        public void Retirar(double cantidad)
        {
            if (double.Parse(SaldoTextBox.Text) > cantidad)
            {
                Saldo = double.Parse(SaldoTextBox.Text) -cantidad;
            }
            else
                MessageBox.Show("Saldo insuficiente");
        }

        public void MetodoGestor(string cliente, string cuenta, double saldo)
        {
            string message = "Estimado(a) {0} \nSe le notifica que el saldo de su cuenta {1} se ha modificado\nNuevo Saldo: {2}";
            message = string.Format(message, cliente, cuenta, saldo.ToString("C"));
            MessageBox.Show(message);
        }
    }
}
