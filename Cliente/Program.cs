using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Conectar();
            Console.ReadKey();
        }

        static void Conectar()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.200.28"), 80);
            
            byte[] aEnviar;
            try
            {
                socket.Connect(direccion);

                Console.WriteLine("Cliente conextado con exito");
                Console.WriteLine("Ingrese mensaje: ");
                string mensaje = Console.ReadLine();

                aEnviar = Encoding.Default.GetBytes(mensaje);
                socket.Send(aEnviar, 0, aEnviar.Length, 0);
                Console.WriteLine("Mensaje enviado");
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Presione una Tecla");
        }

    }
}
