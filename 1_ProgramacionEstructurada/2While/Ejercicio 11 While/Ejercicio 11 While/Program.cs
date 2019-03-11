using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11_While
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe los primeros 10 números pares

            int x = 1;

            Console.WriteLine("Estos son los 10 primeros números pares");

            while(x >= 1 && x <= 20)
            {
                if(x % 2 == 0)
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
