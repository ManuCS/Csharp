using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {//Leer 2 números y calcular la resta del mayor menos la del menor.

            int n1, n2, resta;

            Console.WriteLine("Escribe el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 >= n2)
            {
                resta = n1 - n2;
                Console.WriteLine(n1 + " - " + n2 + " = " + resta);
            }
            else
            {
                resta = n2 - n1;
                Console.WriteLine(n2 + " - " + n1 + " = " + resta);
            }

            Console.ReadKey();
        }
    }
}
