using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25_For
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe los 10 primeros números pares

            int numero;

            Console.WriteLine("Estos son los 10 primeros números pares: ");

            for (numero = 1; numero <= 20; numero++)
            {
                if(numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.ReadKey();
        }
    }
}
