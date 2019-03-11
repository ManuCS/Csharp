using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe los 10 primeros números que no sean múltiplos ni de 2 ni de 3

            int numero;

            Console.WriteLine("Los 10 primeros números que no son múltiplos ni de 2 ni de 3 son: ");
           
            for(numero = 1; numero < 30; numero++)
            {
                if(numero % 2 != 0 && numero % 3 != 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.ReadKey();
        }
    }
}
