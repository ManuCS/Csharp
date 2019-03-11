using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_Funciones
{
    class Program
    {
        /// <summary>
        /// Funcion que incrementa valor variable
        /// </summary>
        /// <param name="a">Variable que será incrementada</param>
        /// <returns>Incrementa la variable a </returns>
        static int Inc(ref int a)
        {
            a++;

            return a;
        }

        /// <summary>
        /// Funcion  que decrecementa un valor
        /// </summary>
        /// <param name="b">valor que será decrementado</param>
        /// <returns>Decrementa la variable b</returns>
        static int Dec(ref int b)
        {
            b--;

            return b;
        }
        static void Main(string[] args)
        {
            int inc, dec;

            Console.WriteLine("Introduce un valor:");
            inc = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un valor:");
            dec = int.Parse(Console.ReadLine());

            Console.WriteLine(Dec(ref dec));
            Console.WriteLine(Inc(ref inc));

            

            Console.ReadKey();
        }
    }
}
