using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FicherosYDirectorios
{
    class Program
    {
        /// <summary>
        /// Función que devuelve el número de archivos que hay con la extensión indicada en el directorio actual
        /// </summary>
        /// <param name="extension">Extensión que deberán tener los archivos que buscamos</param>
        /// <returns>El número de archivos que hay con esa extensión</returns>
        static int CuantosFicheros(string extension)//Ejercicio 1
        {
            int cont;

            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory(), "*." + extension);

            cont = ficheros.Length;

            return cont;
        }

        /// <summary>
        /// Función que dice cuantos archivos con la extensión que le pases hay en la carpeta que le pases.
        /// </summary>
        /// <param name="extension">Extensión que deberán tener los archivos</param>
        /// <param name="carpeta">Carpeta donde estarán los archivos</param>
        /// <returns>Número de archivos que hay en esa carpeta con esa extensión</returns>
        static int CuantosFicherosPro(string extension, string carpeta)//Ejercicio 2
        {
            int cont;

            string[] ficheros = Directory.GetFiles(carpeta, "*." + extension);

            cont = ficheros.Length;

            return cont;
        }

        /// <summary>
        /// Función que crea una copia de seguridad de un fichero.
        /// </summary>
        /// <param name="fichero">Fichero del cual se creará la copia de seguridad</param>
        static void CreaBackup(string fichero)//Ejercicio 3
        {
            string copia;

            copia = fichero + ".bak";

            while (File.Exists(copia))
            {
                copia = copia + ".bak";
            }

            File.Copy(fichero, copia);
        }
        
        /// <summary>
        /// Función que Renombra los ficheros con la extension indicada(extension1) del directorio actual, cambiandole la extension(extension2).
        /// </summary>
        /// <param name="extension1">Extension a cambiar</param>
        /// <param name="extension2">Extension que será tras el cambio</param>
        static void RenombraMasivo(string extension1, string extension2)//Ejercicio 4
        {
            int i;

            string nombre;

            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory(), "*." + extension1);

            for(i = 0; i < ficheros.Length; i++)
            {
                nombre = Path.GetFileNameWithoutExtension(ficheros[i]);

                File.Move(ficheros[i], nombre + "." + extension2);
            }
        }

        /// <summary>
        /// Función que cuenta las lineas totales que hay entre todos los ficheros de la carpeta actual con la extension que le pasemos.
        /// </summary>
        /// <param name="extension">Extensión que tendrán los ficheros</param>
        /// <returns>El número de líneas que hay entre todos.</returns>
        static int CuentaLineasFicheros(string extension)//Ejercicio 5
        {
            int i, cont;

            cont = 0;

            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory(), "*." + extension);

            for(i = 0; i < ficheros.Length; i++)
            {
                StreamReader sr = new StreamReader(ficheros[i]);

                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    cont++;
                }

                sr.Close();
            }

            return cont;
        }

        /// <summary>
        /// Función que devuelve el nombre del fichero de mayor tamaño de la carpeta actual
        /// </summary>
        /// <returns>Nombre del fichero más grande de la carpeta actual</returns>
        static string FicheroMasGrande()//Ejercicio 6
        {
            int i;

            long mayor = 0;
            string nombre = "";

            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory());

            for(i = 0; i < ficheros.Length; i++)
            {
                long tam = new FileInfo(ficheros[i]).Length;

                if(tam > mayor)
                {
                    mayor = tam;
                    nombre = Path.GetFileName(ficheros[i]);
                }
            }

            return nombre;
        }

        /// <summary>
        /// Función que clasifica los ficheros mostrando cuantos de esa misma extensión hay en la carpeta actual
        /// </summary>
        static void ClasificaFicheros()//Ejercicio 7
        {
            int i, j, cont1,cont2;

            cont1 = 0;
            cont2 = 0;

            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory());

            List<string> l = new List<string>();

            for(i = 0; i < ficheros.Length; i++)
            {
                l.Add(Path.GetExtension(ficheros[i]));
            }

            l.Sort();


            for(i = 0; i < l.Count; i++)
            {
                for(j = 0; j < l.Count; j++)
                {
                    if(l[i] == l[j])
                    {
                        cont1++;
                    }
                }

                for(j = i - 1; j >= 0; j--)
                {
                    if(l[i] == l[j])
                    {
                        cont2++;
                    }
                }

                if (cont2 == 0)
                {
                    Console.WriteLine(Path.GetExtension(l[i]) + " => " + cont1);
                    cont1 = 0;
                }
                else
                {
                    cont1 = 0;
                }

            }
            

        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU FICHEROS Y DIRECTORIOS");
            Console.WriteLine("===========================");
            Console.WriteLine(" 1- CuantosFicheros");
            Console.WriteLine(" 2- CuantosFicherosPro");
            Console.WriteLine(" 3- CreaBackup");
            Console.WriteLine(" 4- RenombraMasivo");
            Console.WriteLine(" 5- CuentaLineasFicheros");
            Console.WriteLine(" 6- FicheroMasGrande");
            Console.WriteLine(" 7- ClasificaFicheros");

            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine(CuantosFicheros("txt"));
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine(CuantosFicherosPro("txt", "C://Windows"));
                    }
                    break;

                case 3:
                    {
                        CreaBackup("texto.txt");
                    }
                    break;

                case 4:
                    {
                        RenombraMasivo("txt", "texto");
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine(CuentaLineasFicheros("txt"));
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine(FicheroMasGrande());
                    }
                    break;

                case 7:
                    {
                        ClasificaFicheros();
                    }
                    break;

                default: Console.WriteLine("Ejercicio no válido"); break;
            }

            Console.ReadKey();
        }
    }
}
