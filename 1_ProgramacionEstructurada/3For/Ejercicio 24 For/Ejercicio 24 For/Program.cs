using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24_For
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe los números impares entre 1 y 10

            int numero;

            Console.WriteLine("Los números impares entre 1 y 10: ");

            for(numero = 1; numero <= 10; numero++)
            {
                if(numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.ReadKey();
        }
    }
}
