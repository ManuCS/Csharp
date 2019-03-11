using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22_While
{
    class Program
    {
        static void Main(string[] args)
        { // Calcular el factorial de un numero entero.

            int numero, contador, factorial;

            Console.WriteLine("Introduce un número entero: ");
            numero = int.Parse(Console.ReadLine());

            contador = numero;
            factorial = numero;

            while(contador > 1)
            {
                contador--;
                factorial = factorial * contador; 
            }

            Console.WriteLine("El factorial de " + numero + " es: " + factorial);

            Console.ReadKey();
        }
    }
}
