using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Conectar();
        }

        static void Conectar()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.200.28"), 80);

            byte[] recibido = new byte[255];

            try
            {
                socket.Bind(direccion);
                socket.Listen(1);

                Console.WriteLine("Escuchando...");
                Socket escucha = socket.Accept();
                Console.WriteLine("Conexion exitosa...");

                int largoREcibido = escucha.Receive(recibido, 0, recibido.Length, 0);
                Array.Resize(ref recibido, largoREcibido);

                Console.Write("El cliente dice: " + Encoding.Default.GetString(recibido));
                
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Presione una Tecla");
            Console.ReadKey();

        }
    }
}
