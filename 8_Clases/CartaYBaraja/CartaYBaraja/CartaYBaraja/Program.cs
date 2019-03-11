using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaYBaraja
{
    class Program
    {
        static void Main(string[] args)
        {
            Carta c;
            Baraja b = new Baraja(1, true);

            int sigono = 1; // 0 -> plantarse ; 1 -> seguir jugando
            decimal puntuacion = 0;

            while(sigono != 0 && puntuacion <= 7.5m)
            {
                if(sigono == 1)
                {
                    c = b.Robar();
                    puntuacion = c.Valor7ymedia + puntuacion;

                    Console.WriteLine("["+ c.NombreCarta + "] = " + c.Valor7ymedia + " punto(s).");

                    if(puntuacion <= 7.5m)
                    {
                        Console.WriteLine("En total tienes " + puntuacion + " puntos.");
                        Console.WriteLine("Pulsa '1' para seguir jugando, '0' para plantarte.");
                        sigono = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("En total tienes " + puntuacion + " puntos. ¡Te has pasado!");
                        Console.WriteLine();
                    }

                    
                }
                else
                {
                    if(sigono != 0)
                    {
                        Console.WriteLine("La opción introducida no es válida. '1' para seguir jugando, '0' para plantarte.");
                        sigono = int.Parse(Console.ReadLine());
                    }
                }
            }

            if(puntuacion == 7.5m)
            {
                Console.WriteLine("¡Enhorabuena, has ganado, ya eres mi discipulo!");
            }
            else
            {
                if(puntuacion > 7.5m)
                {
                    Console.WriteLine("¡Has perdido noob!");
                }
                else
                {
                    Console.WriteLine("¡Casi consigues ganar!");
                }
            }


            Console.ReadKey();
        }
    }
}
