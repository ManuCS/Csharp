using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_While
{
    class Program
    {
        static void Main(string[] args)
        {//Calcular en un mismo bucle el valor maximo, minimo y media de 10 números.

            int numero, contador, maximo, minimo, numerototal, suma, media;

            contador = 1;
            suma = 0;

            Console.WriteLine("Introduce el valor del numero" + contador + ":");
            numero = int.Parse(Console.ReadLine());
            contador++;

            maximo = numero;
            minimo = numero;
            numerototal = numero;
            media = numerototal / contador;

            while(contador <= 10)
            {
                Console.WriteLine("Introduce el valor del numero" + contador + ":");
                numero = int.Parse(Console.ReadLine());
                
                numerototal = numerototal + numero;
                contador++;


                if (numero >= maximo)
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

            media = numerototal / contador;

            Console.WriteLine("El máximo es: " + maximo);
            Console.WriteLine("El mínimo es: " + minimo);
            Console.WriteLine("La media es: " + media);



            Console.ReadKey();
        }
    }
}
