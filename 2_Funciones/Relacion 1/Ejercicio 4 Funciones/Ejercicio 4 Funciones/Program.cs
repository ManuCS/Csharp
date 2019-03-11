using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Funciones
{
    class Program
    {//ImprimeSerie, le pasas 2 numeros enteros y escribe los valores comprendidos entre ambos en ascendente si n1 < n2 y descendente si n1 > n2

        static void ImprimeSerie(int a, int b)
        {

            int i;

            if(a >= b)
            {
                Console.WriteLine("Los números comprendidos entre " + a + " y " + b + " son: ");
                for (i = a; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Los números comprendidos entre " + a + " y " + b + " son: ");
                for(i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Introduce 2 números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            ImprimeSerie(n1, n2);

            Console.ReadKey();
        }
    }
}
