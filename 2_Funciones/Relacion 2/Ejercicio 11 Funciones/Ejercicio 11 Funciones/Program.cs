using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11_Funciones
{
    class Program
    {//Función AreaTriangulo, a la que le pasamos base y altura y nos devuelve el área del triángulo

        //b = base; h = altura
        static double AreaTriangulo(double b, double h)
        {
            double area;

            area = (b * h) / 2;

            return area;
        }
        static void Main(string[] args)
        {
            double b, h;

            Console.WriteLine("Introduce la base del triángulo en centímetros: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triángulo en centímetros: ");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine("El área del triángulo es: " + AreaTriangulo(b, h) + " cm^2.");

            Console.ReadKey();
        }
    }
}
