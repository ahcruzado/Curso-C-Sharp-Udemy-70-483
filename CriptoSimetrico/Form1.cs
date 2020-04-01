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

namespace CriptoSimetrico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncriptarButton_Click(object sender, EventArgs e)
        {
            var resutlado=EncriptarTexto(this.MensajeTextBox.Text, this.ClaceTextBox.Text);
            this.ResultadoTextBox.Text = resutlado;
        }

        private static string EncriptarTexto(string mensaje, string clave)
        {
            var password = new PasswordDeriveBytes(clave, null);
            byte[] array = password.GetBytes(32);

            string resutado = EncriptarTexto(mensaje, array);

            return resutado;
        }


        private static string EncriptarTexto(string mensaje, byte[] clave)
        {
            Rijndael cifradoRijn = Rijndael.Create();

            byte[] byteEncriptado = null;
            byte[] byteSalida = null;

            try
            {
                cifradoRijn.Key = clave;
                cifradoRijn.GenerateIV();

                byte[] byteEntrada = System.Text.Encoding.UTF8.GetBytes(mensaje);
                byteEncriptado= cifradoRijn.CreateEncryptor().TransformFinalBlock(byteEntrada, 0, byteEntrada.Length);
                byteSalida = new byte[cifradoRijn.IV.Length + byteEncriptado.Length];
                cifradoRijn.IV.CopyTo(byteSalida, 0);
                byteEncriptado.CopyTo(byteSalida, cifradoRijn.IV.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cifradoRijn.Clear();
            }

            string textoSalida = Encoding.Default.GetString(byteSalida);
            return textoSalida;
        }

        private static string DesencriptarTexto(byte[] datosCifrados, byte[] clave)
        {
            Rijndael cifradoRijn = Rijndael.Create();
            byte[] arrayTemporal = new byte[cifradoRijn.IV.Length];
            byte[] byteEncriptado = new byte[datosCifrados.Length - cifradoRijn.IV.Length];
            string textoDescifrado = string.Empty;

            try
            {
                cifradoRijn.Key = clave;
                Array.Copy(datosCifrados, arrayTemporal, arrayTemporal.Length);
                Array.Copy(datosCifrados, arrayTemporal.Length, byteEncriptado, 0, byteEncriptado.Length);
                cifradoRijn.IV = arrayTemporal;

                textoDescifrado = System.Text.Encoding.UTF8.GetString(cifradoRijn.CreateDecryptor().TransformFinalBlock(byteEncriptado, 0, byteEncriptado.Length));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cifradoRijn.Clear();
            }

            return textoDescifrado;
        }

        private void DesencriptarButton_Click(object sender, EventArgs e)
        {
            byte[] mensajeCifrado= Encoding.Default.GetBytes(this.ResultadoTextBox.Text);
            var password = new PasswordDeriveBytes(this.ClaceTextBox.Text, null);
            byte[] array = password.GetBytes(32);

            string resutdado = DesencriptarTexto(mensajeCifrado, array);
            this.MensajeTextBox.Text = resutdado;
        }
    }
}
