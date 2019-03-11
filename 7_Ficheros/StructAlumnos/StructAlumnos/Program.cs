using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StructAlumnos
{
    class Program
    {
        struct FichaAlumno
        {
            public string nombre;
            public int edad;
            public decimal calificacion;
        }


        /// <summary>
        /// Función que guarda un nuevo alumno en la lista de alumnos
        /// </summary>
        /// <param name="lista">Lista de alumnos</param>
        static void LeeAlumnoLista(List<FichaAlumno> lista)//Ejercicio 1
        {
            FichaAlumno alumno;

            Console.WriteLine("Introduce el nombre del alumno: ");
            alumno.nombre = Console.ReadLine();
            Console.WriteLine("Introduce la edad del alumno: ");
            alumno.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la calificación del alumno: ");
            alumno.calificacion = decimal.Parse(Console.ReadLine());

            while(alumno.calificacion < 0 || alumno.calificacion > 10)
            {
                Console.WriteLine("Introduce la calificación del alumno (menor que 10 y mayor que 0): ");
                alumno.calificacion = decimal.Parse(Console.ReadLine());
            }

            lista.Add(alumno);
        }

        /// <summary>
        /// Función que imprime una lista de alumnos por pantalla
        /// </summary>
        /// <param name="lista">Lista alumnos</param>
        static void ImprimeListaAlumnos(List<FichaAlumno> lista)//Ejercicio 2
        {
            int i;

            if(lista.Count == 0)
            {
                Console.WriteLine("La lista no tiene ningún valor");
            }
            else
            {
                for (i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("Nombre: " + lista[i].nombre);
                    Console.WriteLine("Edad: " + lista[i].edad);
                    Console.WriteLine("Calificación: " + lista[i].calificacion);
                    Console.WriteLine("-----------------------------");
                }
            }

        }

        /// <summary>
        /// Función que escribe en un fichero una lista de alumnos con sus registros.
        /// </summary>
        /// <param name="lista">Lista de alumnos</param>
        /// <param name="fichero">Fichero de la lista</param>
        static void EscribeFicheroAlumnos(List<FichaAlumno> lista, string fichero)//Ejercicio 3
        {
            int i, n; 
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            n = lista.Count();

            bw.Write(n);

            for(i = 0; i < lista.Count; i++)
            {
                bw.Write(lista[i].nombre);
                bw.Write(lista[i].edad);
                bw.Write(lista[i].calificacion);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Función que lee un fichero de una lista
        /// </summary>
        /// <param name="lista">Lista alumnos</param>
        /// <param name="fichero">Fichero alumnos</param>
        static void LeeFicheroAlumnos(List<FichaAlumno> lista, string fichero)//Ejercicio 4
        {

            EscribeFicheroAlumnos(lista, fichero);

            lista.Clear();

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine("Numero alumnos: " + br.ReadInt32());

            while(fs.Position < fs.Length)
            {
                Console.WriteLine("Nombre: " + br.ReadString());
                Console.WriteLine("Edad: " + br.ReadInt32());
                Console.WriteLine("Calificacion: " + br.ReadDecimal());
            }


            br.Close();
            fs.Close();
        }


        //Relación 2

        /// <summary>
        /// Función que escribe en un fichero de texto una lista de alumnos con sus registros
        /// </summary>
        /// <param name="lista">Lista de alumnos con sus registro</param>
        /// <param name="fichero">Fichero en el que se copiarán</param>
        static void EscribeFicheroAlumnosTXT(List<FichaAlumno> lista, string fichero)//Ejercicio 5
        {
            int i, n;

            n = lista.Count;

            StreamWriter sw = new StreamWriter(fichero);

            sw.WriteLine("Numero de alumnos: " + n);
            sw.WriteLine();

            for (i = 0; i < lista.Count; i++)
            {
                sw.WriteLine("Nombre: " + lista[i].nombre);
                sw.WriteLine("Edad: " + lista[i].edad);
                sw.WriteLine("Calificacion: " + lista[i].calificacion);
                sw.WriteLine("--------------------------------------");
            }

            sw.Close();
        }
        
        /// <summary>
        /// Función que lee los datos de una lista de alumnos desde un fichero de texto
        /// </summary>
        /// <param name="lista">Lista de alumnos</param>
        /// <param name="fichero">Fichero de texto</param>
        static void LeeFicheroAlumnosTXT(List<FichaAlumno> lista, string fichero)//Ejercicio 6
        {
            EscribeFicheroAlumnosTXT(lista, fichero);

            lista.Clear();

            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        /// <summary>
        /// Función que guarda los registros de una lista en un fichero CSV
        /// </summary>
        /// <param name="lista">Lista de alumnos</param>
        /// <param name="fichero">Fichero CSV</param>
        static void EscribeFicheroAlumnosCSV(List<FichaAlumno> lista, string fichero)//Ejercicio 7
        {
            int i;
            StreamWriter sw = new StreamWriter(fichero);

            for(i = 0; i < lista.Count; i++)
            {
                sw.Write(lista[i].nombre + ";" + lista[i].edad + ";" + lista[i].calificacion);
                sw.WriteLine();
            }

            sw.Close();
        }

        /// <summary>
        /// Función que convierte el fichero de EscribeFicheroAlumnosCSV en una lista.
        /// </summary>
        /// <param name="fichero">Fichero CSV</param>
        /// <returns>Lista con los datos de Fichero CSV</returns>
        static List<FichaAlumno> LeeFicheroAlumnosCSV(string fichero)//Ejercicio 8
        {
            FichaAlumno nuevo;

            List<FichaAlumno> l = new List<FichaAlumno>(); 

            string s;
            string[] cad;
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                cad = s.Split(';');

                nuevo.nombre = cad[0];
                nuevo.edad = Convert.ToInt32(cad[1]);
                nuevo.calificacion = Convert.ToDecimal(cad[2]);

                l.Add(nuevo);
            }

            return l;
        }
        

        static void Main(string[] args)
        {
            List<FichaAlumno> listaAlumnos = new List<FichaAlumno>();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine(" 1- LeeAlumnoLista");
                Console.WriteLine(" 2- ImprimeListaAlumnos");
                Console.WriteLine(" 3- EscribeFicheroAlumnos");
                Console.WriteLine(" 4- LeeFicheroAlumnos");
                Console.WriteLine(" 5- EscribeFicheroAlumnosTXT");
                Console.WriteLine(" 6- LeeFicheroAlumnosTXT");
                Console.WriteLine(" 7- EscribeFicheroAlumnosCSV");
                Console.WriteLine(" 8- LeeFicheroAlumnosCSV");

                Console.WriteLine("Salir = 0");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            LeeAlumnoLista(listaAlumnos);
                        }
                        break;

                    case 2:
                        {
                            ImprimeListaAlumnos(listaAlumnos);
                        }
                        break;

                    case 3:
                        {
                            string nombreFichero = "alumnos.bin";
                            
                            EscribeFicheroAlumnos(listaAlumnos, nombreFichero);
                        }
                        break;

                    case 4:
                        {
                            string fichero = "alumnosfichero.bin";

                            LeeFicheroAlumnos(listaAlumnos, fichero);
                        }
                        break;

                    case 5:
                        {
                            string fichero = "alumnos.txt";

                            EscribeFicheroAlumnosTXT(listaAlumnos, fichero);
                        }
                        break;

                    case 6:
                        {
                            string fichero = "alumnosfichero.txt";

                            LeeFicheroAlumnosTXT(listaAlumnos, fichero);
                        }
                        break;

                    case 7:
                        {
                            string fichero = "alumnos.csv";
                            EscribeFicheroAlumnosCSV(listaAlumnos, fichero);
                        }
                        break;

                    case 8:
                        {
                            string fichero = "alumnos.csv";
                            
                            ImprimeListaAlumnos(LeeFicheroAlumnosCSV(fichero));
                        }
                        break;

                }

                Console.ReadKey();
            }
        }
    }
}
