using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20_While
{
    class Program
    {
        static void Main(string[] args)
        {//Calcular un valor máximo de una serie de 10 números introducidos por teclado.

            int numero, contador, maximo;

            contador = 1;
            maximo = 0;

            while (contador <= 10)
            {
                Console.WriteLine("Introduce un valor del numero"+contador+ ":");

                numero = int.Parse(Console.ReadLine());

                contador++;

                if (numero >= maximo)
                {
                    maximo = numero;
                }
            }

            Console.WriteLine("El máximo es: " + maximo);

            Console.ReadKey();

        }
    }
}
