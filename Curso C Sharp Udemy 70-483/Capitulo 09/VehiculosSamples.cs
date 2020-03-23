using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483.Capitulo_09
{
    public static class VehiculosSamples
    {
        public static void Run()
        {
            Sample01();
            Console.WriteLine(Environment.NewLine);
            Sample02();
        }

        public static void Sample01()
        {
            Carro car = new Carro("marca1", "modelo1", 15, 80, 1, "rojo");
            car.AumentarKilometraje(10);
            Console.WriteLine("El kilometraje es de: {0}", car.Kilometraje);

            Vehiculo ve = new Vehiculo("vehículo", "modelo", 12.3, 120);
            Console.WriteLine(ve.ToString());

        }

        public static void Sample02()
        {
            Carro car = new Carro("marca1", "modelo1", 15, 80, 1, "rojo");
            car.CambiarColor("negro");
            Console.WriteLine("El kilometraje es de: {0}", car.Kilometraje);

            Vehiculo ve = new Vehiculo("vehículo", "modelo", 12.3, 120);
            ve.CambiarColor("verde");
            Console.WriteLine(ve.ToString());

        }

    }
}
