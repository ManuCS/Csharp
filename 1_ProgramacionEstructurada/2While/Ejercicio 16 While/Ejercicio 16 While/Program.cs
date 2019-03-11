using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16_While
{
    class Program
    {
        static void Main(string[] args)
        {//Escribir los números impares entre dos números. Antes hay que comprobar cual de los dos es mayor

            int numero1, numero2, resultado;

            Console.WriteLine("Introduce el primer número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            while(numero1 == numero2)
            {
                Console.WriteLine("Los números no pueden ser iguales. Introduce los valores de nuevo: ");
                Console.WriteLine("Introduce el primer número: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número: ");
                numero2 = int.Parse(Console.ReadLine());
            }

            if(numero1 < numero2)
            {
                resultado = numero1;

                Console.WriteLine("Los números impares comprendidos entre " + numero1 + " y " + numero2 + " son:");
                while(resultado <= numero2)
                {
                    if(resultado % 2 != 0)
                    {
                        Console.WriteLine(resultado);
                        resultado++;
                    }
                    else
                    {
                        resultado++;
                    }
                }
            }
            else
            {
                if(numero2 < numero1)
                {
                    resultado = numero1;

                    Console.WriteLine("Los números impares comprendidos entre " + numero2 + " y " + numero1 + " son:");
                    while (resultado >= numero2)
                    {
                        if(resultado % 2 != 0)
                        {
                            Console.WriteLine(resultado);
                            resultado--;
                        }
                        else
                        {
                            resultado--;
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
