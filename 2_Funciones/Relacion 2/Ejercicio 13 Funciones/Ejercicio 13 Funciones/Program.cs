using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_Funciones
{
    class Program
    {/// <summary>
     /// Funcion NotaEnTexto, a la que le pasamos la nota de un alumno(double) y nos la devolverá en formato texto
     /// </summary>
     /// <param name="a">nota introducida por teclado</param>
     /// <returns>valor en texto (suspenso, suficiente, bien..)</returns>

        static string NotaEnTexto(double a)
        {
            string notatexto;
                    
            if(a > 0 && a < 5)
            {
                notatexto = "Suspenso";
            }
            else
            {
                if(a >= 5 && a < 6)
                {
                    notatexto = "Suficiente";
                }
                else
                {
                    if(a >= 6 && a < 7)
                    {
                        notatexto = "Bien";
                    }
                    else
                    {
                        if(a >= 7 && a < 9)
                        {
                            notatexto = "Notable";
                        }
                        else
                        {
                            if(a >= 9 && a <= 10)
                            {
                                notatexto = "Sobresaliente";
                            }
                            else
                            {
                                notatexto = "Nota incorrecta";
                            }

                        }
                    }
                }
            }

            return notatexto;
        }

        static void Main(string[] args)
        {
            double nota;

            Console.WriteLine("Introduce la nota: ");
            nota = double.Parse(Console.ReadLine());

            Console.WriteLine(NotaEnTexto(nota));


            Console.ReadKey();
        }
    }
}
