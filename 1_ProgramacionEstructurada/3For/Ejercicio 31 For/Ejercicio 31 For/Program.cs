using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31_For
{
    class Program
    {
        static void Main(string[] args)
        {//Profesor introduce las notas de 30 alumnos. Decir cuantos suspensos y aprobados hay.

            int contador, nota, aprobados, suspensos;

            aprobados = 0;
            suspensos = 0;

            for(contador = 1; contador <= 30; contador++)
            {
                Console.WriteLine("Introduce la nota del alumno" + contador + ":");
                nota = int.Parse(Console.ReadLine());

                if(nota < 5)
                {
                    suspensos++;
                }
                else
                {
                    if(nota >= 5)
                    {
                        aprobados++;
                    }
                }
            }

            Console.WriteLine("Hay " + aprobados + " aprobados y " + suspensos + " suspensos");

            Console.ReadKey();

        }
    }
}
