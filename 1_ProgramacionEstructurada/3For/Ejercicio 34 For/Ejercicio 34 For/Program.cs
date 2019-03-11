using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34_For
{
    class Program
    {
        static void Main(string[] args)
        {// Calcular el factorial de un numero entero

            int numero, contador, factorial;

            Console.WriteLine("Introduce un número entero: ");
            numero = int.Parse(Console.ReadLine());

            factorial = numero;

            for(contador = (numero - 1); contador >= 1; contador--)
            {
                factorial = factorial * contador;
            }

            Console.WriteLine("El factorial de " + numero + "! es: " + factorial);

            Console.ReadKey();
        }
    }
}
