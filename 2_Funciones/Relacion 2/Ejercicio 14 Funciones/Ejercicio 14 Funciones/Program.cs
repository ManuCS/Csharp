using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14_Funciones
{
    class Program
    {
        /// <summary>
        /// Funcion que lee un número natural, si no lo es, pregunta de nuevo hasta que sea.
        /// </summary>
        static void LeeNatural()
        {
            int a;
            Console.WriteLine("Introduce un número natural: ");
            a = int.Parse(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("No has introducido un número natural, vuelve a introducirlo de nuevo: ");
                a = int.Parse(Console.ReadLine());
            }


        }
        static void Main(string[] args)
        {
            LeeNatural();

            Console.ReadKey();
        }
    }
}
