using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    class Program
    {
        static void Main(string[] args)
        {//Calcular el minimo comun multiplo

            int n1, n2, i, mayor;

            Console.WriteLine("Escribe el primer número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número:");
            n2 = int.Parse(Console.ReadLine());

            if(n1 >= n2)
            {
                mayor = n1;
            }
            else
            {
                mayor = n2;
            }

            i = mayor;

            while((i % n1 != 0) || (i % n2 != 0))
            {
                i++;
            }

            Console.WriteLine("El MCM es: " + i);

            Console.ReadKey();
        }
    }
}
