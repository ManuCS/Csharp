using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10_Funciones
{
    class Program
    {//Funcion Primo, que devuelve verdadero si el número es primo, falso si no lo es.

        static bool Primo(int a)
        {
            int i, idivisores;

            i = 1;
            idivisores = 0;

            while(i <= a)
            {
                if(a % i == 0)
                {
                    idivisores++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            if(idivisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un número: ");
            numero = int.Parse(Console.ReadLine());

            if (Primo(numero))
            {
                Console.WriteLine("El número es primo.");
            }
            else
            {
                Console.WriteLine("El número no es primo.");
            }

            Console.ReadKey();
        }
    }
}
