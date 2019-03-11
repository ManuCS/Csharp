using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_While
{
    class Program
    {
        static void Main(string[] args)
        {//Profesor que introduce notas de 30 alumnos. Decir cuántos suspensos y cuántos aprobados hay

            int nota, aprobados, suspensos, i;

            aprobados = 0;
            suspensos = 0;
            i = 1;

            while(i <= 30)
            {
                Console.WriteLine("Introduce la nota del alumno" + i);
                nota = int.Parse(Console.ReadLine());
                
                while(nota < 0 || nota > 10)
                {
                    Console.WriteLine("La nota no es correcta. Vuelve a introducirla de nuevo");
                    Console.WriteLine("Introduce la nota del alumno" + i);
                    nota = int.Parse(Console.ReadLine());
                }

                i++;

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
