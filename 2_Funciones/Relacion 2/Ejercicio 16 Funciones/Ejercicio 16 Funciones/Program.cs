using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16_Funciones
{
    class Program
    {
        static int Elevado(int a, int b)
        {
            int resultado, contador;

            
            resultado = a;
            contador = 1;

            while (contador < b)
            {
                resultado = resultado * a;
                contador++;
            }

            return resultado;
        }
        static void Main(string[] args)
        {
            int n, exp;

            Console.WriteLine("Introduce un número: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce su exponente: ");
            exp = int.Parse(Console.ReadLine());

            Console.WriteLine(n + "^" + exp + " = " + Elevado(n, exp));

            Console.ReadKey();
        }
    }
}
