using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {//Introducir 3 números y decir si son consecutivos

            int x, y, z;

            Console.WriteLine("Introduce el primer número: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número: ");
            z = int.Parse(Console.ReadLine());

            if(y == x + 1 && z == y + 1)
            {
                Console.WriteLine("Los números son consecutivos.");
            }
            else
            {
                Console.WriteLine("Los números no son consecutivos.");
            }

            Console.ReadKey();

        }
    }
}
