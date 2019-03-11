using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrupoYAlumno
{
    class Grupo
    {
        //Propiedades

        private List<Alumno> listaAlumnos;


        //Constructores

        /// <summary>
        /// Inicializa la lista de alumnos
        /// </summary>
        public Grupo()
        {
            listaAlumnos = new List<Alumno>();
        }


        //Métodos

        /// <summary>
        /// Inserta un nuevo alumno en la lista
        /// </summary>
        /// <param name="a">alumno</param>
        public void InsertaAlumnoLista(Alumno a)
        {
            listaAlumnos.Add(a);
        }

        /// <summary>
        /// Inserta un nuevo alumno en la lista pasando los datos por parámetro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="calificacion"></param>
        public void InsertaAlumnoLista(string nombre, int edad, decimal calificacion)
        {
            Alumno a = new Alumno(nombre, edad, calificacion);
            InsertaAlumnoLista(a);
        }

        /// <summary>
        /// Imprime un listado de toda la lista en un string
        /// </summary>
        /// <returns></returns>
        public string Imprime()
        {
            int i;
            string cadena = "";

            for(i = 0; i < listaAlumnos.Count; i++)
            {
                cadena = cadena + listaAlumnos[i].Imprime(listaAlumnos[i]);
                cadena = cadena + "\n";
            }

            return cadena;
        }

        /// <summary>
        /// Escribe fichero con los datos de los alumnos de la lista
        /// </summary>
        /// <param name="fichero">Fichero que se creará</param>
        public void EscribeFichero(string fichero)
        {
            int i, n;
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            n = this.listaAlumnos.Count();

            bw.Write(n);

            for (i = 0; i < this.listaAlumnos.Count; i++)
            {
                bw.Write(listaAlumnos[i].Nombre);
                bw.Write(listaAlumnos[i].Edad);
                bw.Write(listaAlumnos[i].Calificacion);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Lee los datos de un fichero de una lista de alumnos
        /// </summary>
        /// <param name="fichero">Fichero con los datos de los alumnos</param>
        public void LeeFichero(string fichero)
        {
            
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine("Numero alumnos: " + br.ReadInt32());

            while (fs.Position < fs.Length)
            {
                Console.WriteLine("Nombre: " + br.ReadString());
                Console.WriteLine("Edad: " + br.ReadInt32());
                Console.WriteLine("Calificacion: " + br.ReadDecimal());
            }


            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Escribe los datos de una lista de alumnos en un fichero txt
        /// </summary>
        /// <param name="fichero">Fichero txt</param>
        public void EscribeFicheroTXT(string fichero)
        {
            int i, n;

            n = this.listaAlumnos.Count;

            StreamWriter sw = new StreamWriter(fichero);

            sw.WriteLine("Numero de alumnos: " + n);
            sw.WriteLine();

            for (i = 0; i < this.listaAlumnos.Count; i++)
            {
                sw.WriteLine("Nombre: " + listaAlumnos[i].Nombre);
                sw.WriteLine("Edad: " + listaAlumnos[i].Edad);
                sw.WriteLine("Calificacion: " + listaAlumnos[i].Calificacion);
                sw.WriteLine("--------------------------------------");
            }

            sw.Close();
        }

        /// <summary>
        /// Lee los datos de los alumnos almacenados en un fichero txt
        /// </summary>
        /// <param name="fichero">fichero txt</param>
        public void LeeFicheroTXT(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        /// <summary>
        /// Escribe un fichero csv con los datos de los alumnos
        /// </summary>
        /// <param name="fichero"></param>
        public void EscribeFicheroCSV(string fichero)
        {
            int i;
            StreamWriter sw = new StreamWriter(fichero);

            for (i = 0; i < this.listaAlumnos.Count; i++)
            {
                sw.Write(listaAlumnos[i].Nombre + ";" + listaAlumnos[i].Edad + ";" + listaAlumnos[i].Calificacion);
                sw.WriteLine();
            }

            sw.Close();
        }

        /// <summary>
        /// Lee los datos de alumnos almacenados en un fichero CSV
        /// </summary>
        /// <param name="fichero">fichero CSV</param>
        public void LeeFicheroCSV(string fichero)
        {
            string s, nombre;
            int edad;
            decimal calificacion;
            string[] cad;
            
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                cad = s.Split(';');

                nombre = cad[0];

                edad = Convert.ToInt32(cad[1]);

                calificacion = Convert.ToDecimal(cad[2]);

                Alumno a = new Alumno(nombre, edad, calificacion);

                Console.WriteLine(a.Imprime(a));

                //this.listaAlumnos.Add(a);
            }

            

            sr.Close();
        }

    }
}
