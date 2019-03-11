using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14_While
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribe 2 números con la condicion de que el segundo > primero , sino pregunta hasta que se cumpla. Cuando se cumpla escribe los números 
            comprendidos entre ellos.(ambos inclusive) */

            int numero1;
            int numero2;
            int numeroscomprendidos;

            Console.WriteLine("Introduce el número 1: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número 2: ");
            numero2 = int.Parse(Console.ReadLine());


            while(numero1 >= numero2)
            {
                Console.WriteLine("El segundo número debe ser mayor que el primero. Introduce los números de nuevo: ");
                Console.WriteLine("Introduce el número 1: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el número 2: ");
                numero2 = int.Parse(Console.ReadLine());
            }

            numeroscomprendidos = numero1;

            Console.WriteLine("Los números comprendidos entre " + numero1 + " y " + numero2 + " son: ");
            while (numeroscomprendidos <= numero2)
            {

                Console.WriteLine(numeroscomprendidos);
                numeroscomprendidos++;
            }


            Console.ReadKey();
        }
    }
}
