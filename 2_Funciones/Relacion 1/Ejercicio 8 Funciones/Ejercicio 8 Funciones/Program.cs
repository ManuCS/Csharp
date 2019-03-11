using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Funciones
{
    class Program
    {//Funcion que calcule el MCD de dos números

        static int MCD(int a, int b)
        {
            int menor, mcd;

            if(a >= b)
            {
                menor = b;
            }
            else
            {
                menor = a;
            }

            int i = menor;

            while((a % i != 0) || (b % i != 0))
            {
                i--;
            }

            mcd = i;
            return mcd;

        }
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Introduce el primer número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El MCD es: " + MCD(n1, n2));

            Console.ReadKey();
        }
    }
}
