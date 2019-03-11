using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20_Funciones
{
    class Program
    {
        static void ResolucionCamara(double megapx, out double x, out double y)
        {
            y = Math.Sqrt(9 * megapx / 16);
            x = megapx / y;
        }
        static void Main(string[] args)
        {
            double megapx, x, y;

            Console.WriteLine("Introduce los MegaPixeles que tiene tu cámara: ");
            megapx = double.Parse(Console.ReadLine());

            ResolucionCamara(megapx, out x, out y);

            Console.WriteLine("La resolución es de: " + x *1000 + " x " + y *1000);

            Console.ReadKey();


        }
    }
}
