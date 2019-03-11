using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29_For
{
    class Program
    {
        static void Main(string[] args)
        {//Escribir los números impares entre dos números. Antes comprobar cuál de ellos es mayor

            int n1, n2, resultado;

            Console.WriteLine("Introduce el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            while(n1 == n2)
            {
                Console.WriteLine("Los números deben ser diferentes. Introduce los valores de nuevo.");
                Console.WriteLine("Introduce el primer número: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número: ");
                n2 = int.Parse(Console.ReadLine());
            }

            if (n1 < n2)
            {
                Console.WriteLine("Los números impares entre " + n1 + " y " + n2 + " son:");

                for(resultado = n1; resultado <= n2; resultado++)
                {
                    if(resultado % 2 != 0)
                    {
                        Console.WriteLine(resultado);
                    }
                }
            }
            else
            {
                if(n1 > n2)
                {
                    Console.WriteLine("Los números impares entre " + n1 + " y " + n2 + " son:");

                    for(resultado = n1; resultado >= n2; resultado--)
                    {
                        if(resultado % 2 != 0)
                        {
                            Console.WriteLine(resultado);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
