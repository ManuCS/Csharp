using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_28_For
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe 2 números. Si n1 < n2 escribir los numeros comprendidos entre ellos en orden ascendente, si n1 > n2, descendente

            int n1, n2, i;

            Console.WriteLine("Introduce el primer número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            n2 = int.Parse(Console.ReadLine());


            if(n1 <= n2)
            {
                Console.WriteLine("Los números comprendidos entre " + n1 + " y " + n2 + " son: ");
                for (i = n1; i <= n2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                if(n1 >= n2)
                {
                    Console.WriteLine("Los números comprendidos entre " + n1 + " y " + n2 + " son: ");
                    for(i = n1; i >= n2; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
