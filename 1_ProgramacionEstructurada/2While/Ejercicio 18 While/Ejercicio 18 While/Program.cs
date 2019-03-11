using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18_While
{
    class Program
    {
        static void Main(string[] args)
        {/*Calcular el valor medio de una serie de números positivos para parar de introducir números el usuario debe teclear un número
           negativo*/

            int numero, numerototal, contador, media;

            Console.WriteLine("Introduce un valor: ");
            numero = int.Parse(Console.ReadLine());

            numerototal = numero;
            contador = 1;
            media = numerototal / contador;

            while (numero > 0)
            {
                
                Console.WriteLine("Introduce otro valor, cuando quieras parar, introduce un número negativo:");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    numerototal = numerototal + numero;
                    contador = contador + 1;
                }
            }

            media = (numerototal / contador);

            Console.WriteLine("La media es: " + media);

            Console.ReadKey();


        }
    }
}
