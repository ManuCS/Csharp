using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {//Determinar el número de cifras de un número entero hasta un máximo de 5

            int numero;

            Console.WriteLine("Introduce un número:");
            numero = int.Parse(Console.ReadLine());

            if(numero >= 0 && numero < 10 ||numero <= 0 && numero > -10 )
            {
                Console.WriteLine("El número tiene 1 cifra");
            }

            else
            {
                if (numero >= 10 && numero < 100 || numero <= -10 && numero > -100)
                {
                    Console.WriteLine("El número tiene 2 cifras");
                }
                else
                {
                    if(numero >= 100 && numero < 1000 || numero <= -100 && numero > -1000)
                    {
                        Console.WriteLine("El número tiene 3 cifras");
                    }
                    else
                    {
                        if(numero >= 1000 && numero < 10000 || numero <= -1000 && numero > -10000)
                        {
                            Console.WriteLine("El número tiene 4 cifras");
                        }
                        else
                        {
                            if(numero >= 10000 && numero < 100000 || numero <= -10000 && numero > -100000)
                            {
                                Console.WriteLine("El número tiene 5 cifras");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
