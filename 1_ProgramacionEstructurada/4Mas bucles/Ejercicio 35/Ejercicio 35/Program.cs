using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe una nota y devuelve una respuesta: sobresaliente, notable...

            double nota;

            Console.WriteLine("Introduce una nota: ");
            nota = double.Parse(Console.ReadLine());

            while(nota < 0 || nota > 10)
            {
                Console.WriteLine("La nota introducida es incorrecta. Introduce el valor de nuevo.");
                Console.WriteLine("Introduce una nota: ");
                nota = double.Parse(Console.ReadLine());
            }

            if(nota >= 0 && nota < 5)
            {
                Console.WriteLine("Suspenso");
            }
            else
            {
                if(nota >= 5 && nota < 7)
                {
                    Console.WriteLine("Bien");
                }
                else
                {
                    if(nota >= 7 && nota < 9)
                    {
                        Console.WriteLine("Notable");
                    }
                    else
                    {
                        if(nota >= 9 && nota <= 10)
                        {
                            Console.WriteLine("Sobresaliente");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
