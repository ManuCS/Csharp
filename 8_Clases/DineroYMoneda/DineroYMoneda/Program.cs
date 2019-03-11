using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineroYMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinero euroo = new Dinero(10, TipoMoneda.Euro);
            Dinero dolaar = new Dinero(10, TipoMoneda.Dolar);
            Dinero francoo = new Dinero(10, TipoMoneda.Libra);

            Console.WriteLine("Suma de euros ");
            Console.WriteLine(euroo + euroo);

            Console.WriteLine("Suma de euros y dolares");
            Console.WriteLine(euroo + dolaar);

            Console.WriteLine("Suma de euros y francos");
            Console.WriteLine(euroo + francoo);

            Console.WriteLine("10 euros a Francos y dolares.");
            Console.WriteLine("10 a francos  -----> " + euroo.ValorEn(TipoMoneda.Libra));
            Console.WriteLine("10 a dolares  -----> " + euroo.ValorEn(TipoMoneda.Dolar));

            Console.ReadKey();
        }
    }
}
