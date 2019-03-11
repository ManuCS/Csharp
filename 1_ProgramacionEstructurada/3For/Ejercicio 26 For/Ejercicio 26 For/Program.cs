using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26_For
{
    class Program
    {
        static void Main(string[] args)
        {//Decir si pares o impares. Si pares -> Escribir los pares del 1 al 10, si impares, los impares

            int numero;
            string parimpar;

            Console.WriteLine("Elige entre 'pares' o 'impares':");
            parimpar = Console.ReadLine();

            while (parimpar != "pares" && parimpar != "impares")
            {
                Console.WriteLine("No has introducido un valor correcto. Elige o 'pares' o 'impares' de nuevo: ");
                parimpar = Console.ReadLine();
            }

            if (parimpar == "pares")
            {
                Console.WriteLine("Los números pares del 1 al 10 son:");

                for(numero = 1; numero <= 10; numero++)
                {
                    if(numero % 2 == 0)
                    {
                        Console.WriteLine(numero);
                    }
                }
            }
            else
            {
                if(parimpar == "impares")
                {
                    Console.WriteLine("Los números impares del 1 al 10 son:");

                    for (numero = 1; numero <= 10; numero++)
                    {
                        if(numero % 2 != 0)
                        {
                            Console.WriteLine(numero);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
