using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_Funciones
{
    class Program
    {//Funcion Min que devuelve el menor de los números introducidos por teclado

        static int Min(int a, int b)
        {
            if(a <= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Escribe dos números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El menor es: " + Min(n1, n2));

            Console.ReadKey();
        }
    }
}
