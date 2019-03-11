using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_While
{
    class Program
    {
        static void Main(string[] args)
        {//Escribe la tabla de multiplicar del número que introduzcamos.

            int numero; //numero introducido por teclado para saber su tabla de multiplicar
            int tabla = 1; //números los cuales multiplican al número elegido
            int resultado; //resultado de la multiplicación

            Console.WriteLine("Introduce un número y te devuelvo su tabla de multiplicar: ");
            numero = int.Parse(Console.ReadLine());

            

            while(tabla <= 10)
            {
                resultado = tabla * numero;
                Console.WriteLine(numero + " * " + tabla + " = " + resultado);
                tabla++;
            }

            Console.ReadKey();
        }
    }
}
