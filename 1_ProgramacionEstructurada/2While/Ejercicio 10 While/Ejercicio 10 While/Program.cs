using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10_While
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe los números impares comprendidos entre 1 y 10

            int x = 1;

            Console.WriteLine("Estos son los números impares comprendidos entre 1 y 10: ");

            while(x >= 1 && x <= 10)
            {
                if(x % 2 != 0)
                {
                    Console.WriteLine(x);
                    x++;
                }
                else
                {
                    x++;
                }
            }

            Console.ReadKey();
        }
    }
}
