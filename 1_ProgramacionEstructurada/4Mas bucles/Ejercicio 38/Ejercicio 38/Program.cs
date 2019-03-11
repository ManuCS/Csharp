using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {//Calcula el maximo comun divisor

            int n1, n2, i, menor;

            Console.WriteLine("Escribe el primer número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número:");
            n2 = int.Parse(Console.ReadLine());

            if (n1 >= n2)
            {
                menor = n2;
            }
            else
            {
                menor = n1;
            }

            i = menor;

            while((n1 % i != 0) || (n2 % i != 0))
            {
                i--;
            }

            Console.WriteLine("El MCD es: " + i);

            Console.ReadKey();
        }
    }
}
