using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CriptoAsimetrico
{
    public class ClaseEncriptacion
    {

        public ClaseEncriptacion()
        {
            this.RSA = new RSACryptoServiceProvider();
        }

        public RSACryptoServiceProvider RSA { get; set; }

        public byte[] CrearClavesPublicas()
        {
            string claveXmlPublica = this.RSA.ToXmlString(false);
            return Encoding.ASCII.GetBytes(claveXmlPublica);
        }

        public byte[] CrearClavesPrivadas()
        {
            string claveXmlPrivada = this.RSA.ToXmlString(true);
            return Encoding.ASCII.GetBytes(claveXmlPrivada);
        }

        public static byte[] EncriptarTexto(string mensaje, string clavePublica)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(clavePublica);
            byte[] datosEncriptados = rsa.Encrypt(Encoding.ASCII.GetBytes(mensaje), false);
            return datosEncriptados;
        }

        public static byte[] DesencriptarTexto(string mensajeEncriptado, string clavePrivada)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(clavePrivada);
            byte[] datosDesencriptados = rsa.Decrypt(Convert.FromBase64String(mensajeEncriptado), false);
            return datosDesencriptados;

        }


    }
}
