using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Funciones
{
    class Program
    {//Funcion Max que devuelve entre dos números, cual es el mayor

        static int Max(int a, int b)
        {

            if(a >= b)
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

            Console.WriteLine("El mayor es: " + Max(n1, n2));

            Console.ReadKey();
        }
    }
}
