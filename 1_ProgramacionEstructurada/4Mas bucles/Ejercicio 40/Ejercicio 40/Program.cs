using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    class Program
    {
        static void Main(string[] args)
        {//Decir si un número es primo o no.

            int numero, i, idivisores; //idivisores es el contador de los divisiores que tiene el número.

            Console.WriteLine("Introduce un número: ");
            numero = int.Parse(Console.ReadLine());

            i = 1;
            idivisores = 0;

            //Contador que va de 1 hasta el número comprobando cuántos divisores tiene. 
            while(i <= numero)
            {
                if(numero % i == 0)
                {
                    i++;
                    idivisores++;
                }
                else
                {
                    i++;
                }
            }

            //Para que sea primo, solo debe tener 2 divisores: 1 y el propio número
            if(idivisores == 2)
            {
                Console.WriteLine("El número " + numero + " es primo");
            }
            else
            {
                Console.WriteLine("El número " + numero + " NO es primo");
            }

            Console.ReadKey();
        }
    }
}
