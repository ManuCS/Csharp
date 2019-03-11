using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32_For
{
    class Program
    {
        static void Main(string[] args)
        {//Calcular valor máximo de una serie de 10 números.

            int numero, maximo, contador;

            maximo = 0;

            for(contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("Introduce el número" + contador+ ":");
                numero = int.Parse(Console.ReadLine());

                if(numero >= maximo)
                {
                    maximo = numero;
                }
            }

            Console.WriteLine("El máximo es: " + maximo);

            Console.ReadKey();
        }
    }
}
