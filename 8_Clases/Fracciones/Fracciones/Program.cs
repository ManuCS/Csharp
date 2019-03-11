using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion f1 = new Fraccion(2, 10);
            Fraccion f2 = new Fraccion(2, 4);
            Fraccion f3 = new Fraccion(2.4);
            Fraccion res;

            Console.WriteLine(f1 + f3);

            res = f2 + f3;
            Console.WriteLine(res);

            res = f3 * f1;
            Console.WriteLine(res);

            res = f1 / f3;
            Console.WriteLine(res);

            if (f1 > f3)
            {
                Console.WriteLine("es mayor");
            }
            else
            {
                Console.WriteLine("Es menor");
            }

            Console.ReadKey();
        }
    }
}
