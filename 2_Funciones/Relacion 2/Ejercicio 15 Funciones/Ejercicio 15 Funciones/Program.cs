using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15_Funciones
{
    class Program
    {
        /// <summary>
        /// Funcion que pide un número comprendido entre dos parámetros que le pasamos. Si no está comprendido entre ellos, vuelve a pedir el número
        /// </summary>
        /// <param name="a">Valor de un extremo de nuestra posibilidad de números correctos</param>
        /// <param name="b">Valor del otro extremo de nuestra posibilidad de números correctos</param>
        static void LeeNumero(int a, int b)
        {
            int n;

            Console.WriteLine("Introduce un número entre " + a + " y " + b + ":");
            n = int.Parse(Console.ReadLine());


            if(a >= b)
            {
                while(n > a || n < b)
                {
                    Console.WriteLine("El número introducido es incorrecto. Vuelve a introducirlo de nuevo: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                if(a < b)
                {
                    while(n < a || n > b)
                    {
                        Console.WriteLine("El número introducido es incorrecto. Vuelve a introducirlo de nuevo: ");
                        n = int.Parse(Console.ReadLine());
                    }
                }
                
            }

        }
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Introduce el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            LeeNumero(n1, n2);

            Console.ReadKey();
        }
    }
}
