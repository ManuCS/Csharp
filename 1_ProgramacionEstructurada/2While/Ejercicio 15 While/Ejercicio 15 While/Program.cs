using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15_While
{
    class Program
    {
        static void Main(string[] args)
        {/*Pide dos número. Si 1 > 2, escribe los números entre ellos en orden
            ascendente. Si 2 > 1, en orden descendente */

            int numero1, numero2, resultado;

            Console.WriteLine("Introduce el primer número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            while (numero1 == numero2)
            {
                Console.WriteLine("Los números no pueden ser iguales. Introduce los valores de nuevo: ");
                Console.WriteLine("Introduce el primer número: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número: ");
                numero2 = int.Parse(Console.ReadLine());
            }

            if (numero1 > numero2)
            {
                resultado = numero2;

                Console.WriteLine("Los números comprendidos entre " + numero1 + " y " + numero2 + " son: ");
                while (resultado <= numero1)
                {
                    Console.WriteLine(resultado);
                    resultado++;
                }
            }
            else
            {
                if(numero1 < numero2)
                {
                    resultado = numero2;

                    Console.WriteLine("Los números comprendidos entre " + numero2 + " y " + numero1 + " son: ");

                    while(resultado >= numero1)
                    {
                        Console.WriteLine(resultado);
                        resultado--;
                    }
                }
                
                
            }

            Console.ReadKey();

        }
    }
}
