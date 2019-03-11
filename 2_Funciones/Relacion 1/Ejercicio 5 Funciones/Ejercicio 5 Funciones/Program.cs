using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Funciones
{
    class Program
    {//Función Signo que pasa -1 si el número es negativo, 0 si es 0 y 1 si es positivo.

        static void Signo(int n)
        {

            if(n == 0)
            {
                return 0;
            }
            else
            {
                if(n < 0)
                {
                    return -1;
                }
                else
                {
                    if(n > 0)
                    {
                        return 1;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Introduce un número: ");
            n = int.Parse(Console.ReadLine());

            Signo(n);

            Console.ReadKey();
        }
    }
}
