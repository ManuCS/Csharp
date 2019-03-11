using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Funciones
{
    class Program
    {//Escribe una funcion que diga si un número es par o no. Funcion-> "Par" y devolverá "verdadero" si el numero es par, "falso" si es impar.

        static bool Par(int numero)
        {
            int num = numero;

            if(num % 2 == 0)
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

            Console.WriteLine("Escribe un número y te digo si es par o no: ");
            numero = int.Parse(Console.ReadLine());

            if (Par(numero))
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número no es par.");
            }

            Console.ReadKey();
        }
    }
}
