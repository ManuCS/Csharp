using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {// Introducir 3 números y decir cual es el mayor, el menor y el mediano

            int a, b, c;

            Console.WriteLine("Introduce el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número: ");
            c = int.Parse(Console.ReadLine());


            while(a == b && b == c || a == b && b != c || a == c && c != b || b == c && c != a)
            {
                Console.WriteLine("Los 3 números deben ser diferentes.  Vuelve a introducir los valores de nuevo.");
                Console.WriteLine("Introduce el primer número: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el tercer número: ");
                c = int.Parse(Console.ReadLine());
            }


            if (a > b && b > c)
            {
                Console.WriteLine("A es el mayor, C el menor y B el mediano");
            }
            else
            {
                if (a > c && c > b)
                {
                    Console.WriteLine("A es el mayor, B el menor y C el mediano");
                }
                else
                {
                    if (b > a && a > c)
                    {
                        Console.WriteLine("B es el mayor, C el menor y A el mediano");
                    }
                    else
                    {
                        if (b > c && c > a)
                        {
                            Console.WriteLine("B es el mayor, A el menor y C el mediano");
                        }
                        else
                        {
                            if (c > a && a > b)
                            {
                                Console.WriteLine("C es el mayor, B el menor y A el mediano");
                            }
                            else
                            {
                                if (c > b && b > a)
                                {
                                    Console.WriteLine("C es el mayor, A el menor y B el mediano");
                                }
                                
                                
                            }
                        }
                    }
                }
            }

            Console.ReadKey();

            
        }
    }
}
