using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9_Funciones
{
    class Program
    {//Función MCM de dos números

        static int MCM(int a, int b)
        {
            int mayor, i, mcm;

            if (a >= b)
            {
                mayor = a;
            }
            else
            {
                mayor = b;
            }

            i = mayor;

            while((i % a != 0) || (i % b != 0))
            {
                i++;
            }

            mcm = i;

            return mcm;
            
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Introduce el valor del primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor del segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El MCM es: " + MCM(n1, n2));

            Console.ReadKey();
        }
    }
}
