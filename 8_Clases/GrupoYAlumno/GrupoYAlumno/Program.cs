using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrupoYAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo g = new Grupo();
            Alumno a = new Alumno("pepe", 17, 5.5m);


            g.InsertaAlumnoLista("pepe", 17, 5.5m);
            g.InsertaAlumnoLista("asde", 18, 7.5m);
            g.InsertaAlumnoLista("pedgpe", 17, 9.5m);


            Console.WriteLine(g.Imprime());

            g.EscribeFichero("alumnos.bin");
            g.LeeFichero("alumnos.bin");

            Console.WriteLine();

            g.EscribeFicheroTXT("alumnos.txt");
            g.LeeFicheroTXT("alumnos.txt");

            Console.WriteLine();


            g.EscribeFicheroCSV("alumnos.csv");
            g.LeeFicheroCSV("alumnos.csv");


            Console.ReadKey();
        }
    }
}
