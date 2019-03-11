using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18_Funciones
{
    class Program
    {
        static void Lee3(ref int a, ref int b, ref int c)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Introduce el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercero numero: ");
            c = int.Parse(Console.ReadLine());

            Lee3(ref a, ref b, ref c);

            Console.ReadKey();
        }
    }
}
