using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_While
{
    class Program
    {
        static void Main(string[] args)
        {//Calcular la suma de los números pares del 1 al 1000

            int numero = 1;
            int suma = 0;


            while(numero <= 1000)
            {
                if(numero % 2 == 0)
                {
                    suma = suma + numero;
                    numero++;
                }
                else
                {
                    numero++;
                }
            }

            Console.WriteLine("La suma de todos los números pares entre 1 y 1000 es igual a: " + suma);

            Console.ReadKey();
        }
    }
}
