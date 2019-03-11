using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9_While
{
    class Program
    {
        static void Main(string[] args)
        {// Escribir números del 10 al 20

            int numero = 10;

            Console.WriteLine("Los números del 10 al 20: ");
            while(numero >= 10 && numero <= 20)
            {
                Console.WriteLine(numero);
                numero++;          
            }

            Console.ReadKey();
        }
    }
}
