using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33_For
{
    class Program
    {
        static void Main(string[] args)
        {//Calcular el máximo, mínimo y media de una serie de 10 números.

            int numero, sumanumeros, media, minimo, maximo, contador;

            sumanumeros = 0;
            contador = 1;

            Console.WriteLine("Introduce el número" + contador + ":");
            numero = int.Parse(Console.ReadLine());
            
            minimo = numero;
            maximo = numero;
            sumanumeros = sumanumeros + numero;

            for(contador = 2; contador <= 10; contador++)
            {
                Console.WriteLine("Introduce el número" + contador + ":");
                numero = int.Parse(Console.ReadLine());

                sumanumeros = sumanumeros + numero;

                if(numero >= maximo)
                {
                    maximo = numero;
                }
                else
                {
                    if(numero <= minimo)
                    {
                        minimo = numero;
                    }
                }
            }

            media = sumanumeros / contador;

            Console.WriteLine("El máximo es: " + maximo);
            Console.WriteLine("El mínimo es: " + minimo);
            Console.WriteLine("La media es: " + media);

            Console.ReadKey();
        }
    }
}
