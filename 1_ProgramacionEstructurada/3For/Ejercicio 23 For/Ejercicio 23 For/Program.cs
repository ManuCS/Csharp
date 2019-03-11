using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23_For
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe los números del 10 al 20

            int numero;

            Console.WriteLine("Los números del 10 al 20: ");

            for(numero = 10; numero <= 20; numero++)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
