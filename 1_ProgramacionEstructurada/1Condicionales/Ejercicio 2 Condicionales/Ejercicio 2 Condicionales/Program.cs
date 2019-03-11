using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {//Determinar si un año es bisiesto

            int anho;

            Console.WriteLine("Introduce un año:");
            anho = int.Parse(Console.ReadLine());

            if(anho % 4 == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }

            Console.ReadKey();
        }
    }
}
