using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {//Elige al azar un número del 1 al 100 y el usuario probará a ver si acierta. Si no, da pistas si es mayor o menor.

            int numerosuerte, numeroelegido, intentos;

            Random num = new Random();
            numerosuerte = num.Next(1, 100);

            Console.WriteLine("Juego del numero secreto");
            Console.WriteLine("Introduce un número del 1 al 100: ");
            numeroelegido = int.Parse(Console.ReadLine());

            intentos = 1;


            while(numeroelegido != numerosuerte)
            {
                if(numerosuerte > numeroelegido)
                {
                    Console.WriteLine("Mi número es mayor. Vuelve a introducir otro número: ");
                    numeroelegido = int.Parse(Console.ReadLine());
                    intentos++;
                }
                else
                {
                    Console.WriteLine("Mi número es menor. Vuelve a introducir otro número: ");
                    numeroelegido = int.Parse(Console.ReadLine());
                    intentos++;
                }
            }

            if(numeroelegido == numerosuerte)
            {
                Console.WriteLine("¡Has acertado!");
                Console.WriteLine("Has necesitado " + intentos + " intentos");
            }

            Console.ReadKey();

        }
    }
}
