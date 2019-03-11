using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {//Resolver ecuación de segundo grado

            int a, b, c;
            double raiz, resultado1, resultado2;

            Console.WriteLine("Introduce el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número: ");
            c = int.Parse(Console.ReadLine());

            if(a == 0)
            {
                Console.WriteLine("No se puede realizar, ya que no se puede dividir por 0");
            }
            else
            {
                raiz = (b * b) - (4 * a * c);

                if(raiz > 0)
                {
                    raiz = Math.Sqrt(raiz);

                    resultado1 = ((-b) + raiz) / (2 * a);
                    resultado2 = ((-b) - raiz) / (2 * a);

                    Console.WriteLine("Esta ecuación tiene 2 resultados: ");
                    Console.WriteLine("x1 = " + resultado1);
                    Console.WriteLine("x2 = " + resultado2);
                }
                else
                {
                    if(raiz == 0)
                    {
                        resultado1 = (-b) / (2 * a);
                        Console.WriteLine("Esta ecuación tiene 1 resultado, pues su raíz es 0");
                        Console.WriteLine("x1 = " + resultado1);
                    }
                    else
                    {
                        if(raiz < 0)
                        {
                            Console.WriteLine("La ecuación no tiene solución, pues la raíz es negativa.");
                        }
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
