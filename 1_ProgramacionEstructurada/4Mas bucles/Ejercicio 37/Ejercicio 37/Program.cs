using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Program
    {
        static void Main(string[] args)
        {/*Presenta un menú con 3 opciones: 
            -Opción "a": escribe los múltiplos de 11 comprendidos entre 1 y 100
            -Opción "b": escribe los mútiplos de 17 comprendidos entre 1 y 100
            -Opción "c": escribe los múltiplos de 23 comprendidos entre 1 y 100 */

            char opcion;
            int numero;

            Console.WriteLine("Elige entre opción 'a', 'b' o 'c'");
            opcion = char.Parse(Console.ReadLine());

            while(opcion != 'a' && opcion != 'b' && opcion != 'c')
            {
                Console.WriteLine("La opción introducida es incorrecta. Pruebe de nuevo.");
                Console.WriteLine("Elige entre opción 'a', 'b' o 'c'");
                opcion = char.Parse(Console.ReadLine());
            }
            
            if(opcion == 'a')
            {
                Console.WriteLine("Has elegido la opción 'a'. Los múltiplos de 11 entre 1 y 100 son: ");

                for(numero = 1; numero <= 100; numero++)
                {
                    if(numero % 11 == 0)
                    {
                        Console.WriteLine(numero);
                    }
                }
            }
            else
            {
                if(opcion == 'b')
                {
                    Console.WriteLine("Has elegido la opción 'b'. Los múltiplos de 17 entre 1 y 100 son: ");

                    for(numero = 1; numero <= 100; numero++)
                    {
                        if(numero % 17 == 0)
                        {
                            Console.WriteLine(numero);
                        }
                    }
                }
                else
                {
                    if(opcion == 'c')
                    {
                        Console.WriteLine("Has elegido la opción 'b'. Los múltiplos de 17 entre 1 y 100 son: ");

                        for(numero = 1; numero <= 100; numero++)
                        {
                            if(numero % 23 == 0)
                            {
                                Console.WriteLine(numero);
                            }
                        }
                    }
                }
            }

            Console.ReadKey();


        }
    }
}
