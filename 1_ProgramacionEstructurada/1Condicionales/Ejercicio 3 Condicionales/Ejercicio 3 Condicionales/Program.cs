using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {//Leer número real y tipo de moneda: "euro" o "peseta". Convertir la cantidad al tipo indicado.

            double numero, resultado;
            string moneda;

            Console.WriteLine("Introduce una cantidad: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tipo de moneda al que desea convertir, 'euros' o 'pesetas':");
            moneda = Console.ReadLine();

            if(moneda == "euros")
            {
                resultado = numero / 166.386;
                Console.WriteLine(numero + " pesetas son: " + resultado + " " + moneda);
            }
            else
            {
                if(moneda == "pesetas")
                {
                    resultado = numero * 166.386;
                    Console.WriteLine(numero + " euros son: " + resultado + " " + moneda);
                }
                else
                {
                    Console.WriteLine("El tipo de moneda introducido es incorrecto");
                }
            }

            Console.ReadKey();
        }
    }
}
