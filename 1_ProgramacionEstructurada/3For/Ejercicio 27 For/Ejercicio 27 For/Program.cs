using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27_For
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe la tabla de multiplicar del número que introduzcas

            int numero, contador, resultado;

            Console.WriteLine("Introduce el número del que quieres saber la tabla de multiplicar: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Su tabla de multiplicar es: ");

            for(contador = 1; contador <= 10; contador++)
            {
                resultado = numero * contador;

                Console.WriteLine(numero + " * " + contador + " = " + resultado);
            }

            Console.ReadKey();
        }
    }
}
