using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {//Escribir 3 números y decir si están ordenados de menor a mayor.

            int n1, n2, n3;

            Console.WriteLine("Introduce el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número: ");
            n3 = int.Parse(Console.ReadLine());

            if(n1 < n2 && n2 < n3)
            {
                Console.WriteLine("Los números están ordenados de menor a mayor.");
            }
            else
            {
                Console.WriteLine("Los números NO están ordenados de menor a mayor."); 
            }

            Console.ReadKey();

        }
    }
}
