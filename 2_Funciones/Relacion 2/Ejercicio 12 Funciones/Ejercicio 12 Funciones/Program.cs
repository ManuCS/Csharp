using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12_Funciones
{
    class Program
    {//Funcion PulgadasACentimetros a la que le pase un valor en pulgadas y lo devuelva en centimetros(double) y otra CentimetrosAPulgadas.

        static double PulgadasACentimetros(double pulgadas)
        {
            double centimetros;

            centimetros = pulgadas * 2.54;

            return centimetros;
        }

        static double CentimetrosAPulgadas(double centimetros)
        {
            double pulgadas;

            pulgadas = centimetros / 2.54;

            return pulgadas;
        }

        static void Main(string[] args)
        {
            double n;
            string longitud; //que debe ser "pulgadas" o "centimetros"

            Console.WriteLine("Introduce un valor: ");
            n = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce su longitud, que debe ser 'pulgadas' o 'centimetros': ");
            longitud = Console.ReadLine();

            while(longitud != "pulgadas" && longitud != "centimetros")
            {
                Console.WriteLine("Has introducido una longitud incorrecta. Introducela de nuevo: ");
                longitud = Console.ReadLine();
            }

            if(longitud == "pulgadas")
            {
                Console.WriteLine(n + " pulgadas son " + PulgadasACentimetros(n) + " centimetros.");
            }
            else
            {
                Console.WriteLine(n + " centimetros son " + CentimetrosAPulgadas(n) + " pulgadas.");
            }

            Console.ReadKey();
        }
    }
}
