using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Funciones
{
    class Program
    {//Funcion TablaMultiplicar

        static void TablaMultiplicar(int numero)
        {
            int num = numero;
            int i;
            int resultado;

            for(i = 1; i <= 10; i++)
            {
                resultado = num * i;
                Console.WriteLine(numero + " * " + i + " = " + resultado);
            } 
        }

        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un número: ");
            numero = int.Parse(Console.ReadLine());

            TablaMultiplicar(numero);

            Console.ReadKey();
        }
    }
}
