using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_For
{
    class Program
    {
        static void Main(string[] args)
        { //Calcular la suma de los números pares entre 1 y 1000

            int numero, suma;
            suma = 0;

            for(numero = 1; numero <= 1000; numero++)
            {
                if(numero % 2 == 0)
                {
                    suma = suma + numero;
                }
            }

            Console.WriteLine("La suma de los números pares entre 1 y 1000 es: " + suma);

            Console.ReadKey();
        }
    }
}
