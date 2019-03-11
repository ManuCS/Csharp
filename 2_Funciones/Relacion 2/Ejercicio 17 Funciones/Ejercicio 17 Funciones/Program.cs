using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_Funciones
{
    class Program
    {
        /// <summary>
        /// Funcion que devuelve el factorial de un número entero
        /// </summary>
        /// <param name="a">Número entero del que le calculamos el factorial</param>
        /// <returns>El factorial del número</returns>
        static int Factorial(int a)
        {
            int contador, factorial;

            contador = a;
            factorial = a;

            while (contador > 1)
            {
                contador--;
                factorial = factorial * contador;
            }

            return factorial;
        }
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Introduce un número y te devuelvo su factorial: ");
            n = int.Parse(Console.ReadLine());

            while(n <= 0)
            {
                Console.WriteLine("El número debe ser mayor que 0. Vuelve a introducirlo: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El factorial de " + n + " es: " + Factorial(n));

            Console.ReadKey();

        }
    }
}
