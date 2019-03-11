using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12_While
{
    class Program
    {
        static void Main(string[] args)
        {//Decir si quiere pares o impares. Si pares -> escribe pares del 1 al 10, si impares -> impares del 1 al 10

            int x = 1;

            string parimpar; //Valor 'pares' o 'impares'

            Console.WriteLine("Introduce si quieres números 'pares' o 'impares': ");
            parimpar = Console.ReadLine();

            while (parimpar != "pares" && parimpar != "impares")
            {
                Console.WriteLine("No has introducido un valor correcto. Elige o 'pares' o 'impares' de nuevo: ");
                parimpar = Console.ReadLine();
            }

            if(parimpar == "pares")
            {
                Console.WriteLine("Has elegido pares. Los números pares del 1 al 10 son: ");
                while(x <= 10)
                {
                    if(x % 2 == 0)
                    {
                        Console.WriteLine(x);
                        x++;
                    }
                    else
                    {
                        x++;
                    }
                }
            }
            else
            {
                if (parimpar == "impares")
                {
                    Console.WriteLine("Has elegido impares. Los números impares del 1 al 10 son: ");
                    while(x <= 10)
                    {
                        if(x % 2 != 0)
                        {
                            Console.WriteLine(x);
                            x++;
                        }
                        else
                        {
                            x++;
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
