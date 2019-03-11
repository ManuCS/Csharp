using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Funciones
{
    class Program
    {//Funcion Bisiesto y devuelve si un año es bisiesto o no.

        static bool Bisiesto(int anho)
        {
            int year;

            year = anho;

            if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) //Debe ser divisible entre 4 Y ((no ser divisible entre 100) ó (ser divisible entre 400)
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
            int anho;

            Console.WriteLine("Introduce un año: ");
            anho = int.Parse(Console.ReadLine());

            if (Bisiesto(anho))
            {
                Console.WriteLine("El año " + anho + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + anho + " no es bisiesto");
            }

            Console.ReadKey();
        }
    }
}
