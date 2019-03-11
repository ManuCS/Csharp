using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FicherosTexto
{
    class Program
    {

        /// <summary>
        /// Función que escribe en un fichero de texto 10 números aleatorios
        /// </summary>
        /// <param name="fichero">Fichero de texto</param>
        static void EscribeFicheroNumRandom10(string fichero)//Ejercicio 1
        {
            int i, n;
            i = 0;
            StreamWriter sw = new StreamWriter(fichero);
            Random rnd = new Random();

            while(i < 10)
            {
                n = rnd.Next(1, 10);

                sw.WriteLine(n);
                i++;
            }

            sw.Close();
        }

        /// <summary>
        /// FUnción que suma 10 números contenidos en un fichero de texto.
        /// </summary>
        /// <param name="fichero">Fichero</param>
        /// <returns>Suma de los números del fichero</returns>
        static int SumaFicheroInt10(string fichero)//Ejercicio 2
        {
            int suma;
            suma = 0;
            StreamReader sr = new StreamReader(fichero);


            while (!sr.EndOfStream)
            {
                suma = suma + Convert.ToInt32(sr.ReadLine());
            }

            sr.Close();

            return suma;
        }

        /// <summary>
        /// Función que escribe en un fichero de texto el número de enteros que le especifiquemos
        /// </summary>
        /// <param name="fichero">Ficheros</param>
        /// <param name="num">Numero de enteros que escribiremos en el fichero</param>
        static void EscribeFicheroNumRandom(string fichero, int num)//Ejercicio 3
        {
            int n;
            int i = 0;

            StreamWriter sw = new StreamWriter(fichero);

            Random rnd = new Random();

            while(i < num)
            {
                n = rnd.Next(1, 10);

                sw.WriteLine(n);

                i++;
            }

            sw.Close();
        }

        /// <summary>
        /// Función que suma los números contenidos en un fichero de texto
        /// </summary>
        /// <param name="fichero">Fichero de texto</param>
        /// <returns>Suma de sus números</returns>
        static int SumaFicheroInt(string fichero)//Ejercicio 4
        {
            int suma = 0;

            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                suma = suma + Convert.ToInt32(sr.ReadLine());
            }

            sr.Close();

            return suma;
        }

        /// <summary>
        /// Función que escribe lineas en un fichero de texto
        /// </summary>
        /// <param name="fichero">Fichero de texto</param>
        static void EscribeFicheroTexto(string fichero)//Ejercicio 5
        {
            string linea;

            StreamWriter sw = new StreamWriter(fichero);

            Console.WriteLine("Escriba una linea de texto (no escribir nada para finalizar): ");
            linea = Console.ReadLine();

            while(linea != "")
            {
                sw.WriteLine(linea);
                Console.WriteLine("Escriba otra linea de texto (no escribir nada para finalizar): ");
                linea = Console.ReadLine();
            }

            sw.Close();
        }

        /// <summary>
        /// Función que lee las lineas de un fichero de texto
        /// </summary>
        /// <param name="fichero">Fichero de texto</param>
        static void LeeFicheroTexto(string fichero)//Ejercicio 6
        {
            string linea;

            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                Console.WriteLine(linea);
            }

            sr.Close();
        }

        /// <summary>
        /// Función que copia el contenido de un fichero en otro
        /// </summary>
        /// <param name="fichero1">Fichero de texto</param>
        /// <param name="fichero2">Fichero de texto donde se copiará el primero</param>
        static void CopiaFicheroTexto(string fichero1, string fichero2)//Ejercicio 7
        {
            string linea;

            StreamReader sr = new StreamReader(fichero1);
            StreamWriter sw = new StreamWriter(fichero2);

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                sw.WriteLine(linea);
            }

            sr.Close();
            sw.Close();
        }



        static string InvierteCadena(string cadena)
        {
            int i;
            string cadena1 = "";

            for (i = cadena.Length - 1; i >= 0; i--)
            {
                cadena1 = cadena1 + cadena[i];
            }

            return cadena1;
        }

        /// <summary>
        /// Función que invierte las lineas de un fichero y las copia en otro
        /// </summary>
        /// <param name="fichero1">Fichero texto</param>
        /// <param name="fichero2">Fichero de texto con las lineas del primero invertidas</param>
        static void InvierteLineasFichero(string fichero1, string fichero2)//Ejercicio 8
        {
            string linea;

            StreamReader sr = new StreamReader(fichero1);
            StreamWriter sw = new StreamWriter(fichero2);

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                sw.WriteLine(InvierteCadena(linea));
            }

            sr.Close();
            sw.Close();
        }

        /// <summary>
        /// Función que invierte elcontenido de un fichero
        /// </summary>
        /// <param name="fichero1">Fichero texto</param>
        /// <param name="fichero2">Fichero texto invertido</param>
        static void InvierteFicheroTexto(string fichero1, string fichero2)//Ejercicio 9
        {
            int i;
            string linea;

            List<string> l = new List<string>();

            StreamReader sr = new StreamReader(fichero1);
            StreamWriter sw = new StreamWriter(fichero2);

            while (!sr.EndOfStream)
            {
                l.Add(sr.ReadLine());
            }

            for(i = l.Count - 1; i >= 0; i--)
            {
                linea = l[i];
                sw.WriteLine(linea);
            }

            sr.Close();
            sw.Close();
        }

        /// <summary>
        /// Función que separa las palabras de un fichero.
        /// </summary>
        /// <param name="fichero1">Fichero texto</param>
        /// <param name="fichero2">Fichero texto con palabras separadas</param>
        static void SeparaPalabrasFichero(string fichero1, string fichero2)//Ejercicio 10
        {
            int i;
            string cadena;
            string[] array;

            StreamReader sr = new StreamReader(fichero1, Encoding.Default);
            StreamWriter sw = new StreamWriter(fichero2);


            cadena = sr.ReadToEnd();

            array = cadena.Split(' ');

            for(i = 0; i < array.Length; i++)
            {
                sw.WriteLine(array[i]);
            }

            sr.Close();
            sw.Close();
        }


        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU DE FICHEROS DE TEXTO");
            Console.WriteLine("=========================");
            Console.WriteLine(" 1- EscribeFicheroNumRandom10");
            Console.WriteLine(" 2- SumaFicheroInt10");
            Console.WriteLine(" 3- EscribeFicheroNumRandom");
            Console.WriteLine(" 4- SumaFicheroInt");
            Console.WriteLine(" 5- EscribeFicheroTexto");
            Console.WriteLine(" 6- LeeFicheroTexto");
            Console.WriteLine(" 7- CopiaFicheroTexto");
            Console.WriteLine(" 8- InvierteLineasFichero");
            Console.WriteLine(" 9- InvierteFicheroTexto");
            Console.WriteLine(" 10- SeparaPalabrasFichero");
            
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        string fichero;

                        fichero = "NumRandom10.txt";

                        EscribeFicheroNumRandom10(fichero);
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine(SumaFicheroInt10("NumRandom10.txt"));
                    }
                    break;

                case 3:
                    {
                        string fich = "FicheroNumRandom.txt";
                        int n = 11;

                        EscribeFicheroNumRandom(fich, n);
                        Console.WriteLine("Fichero creado con exito");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine(SumaFicheroInt("FicheroNumRandom.txt"));
                    }
                    break;

                case 5:
                    {
                        string fichero;
                        fichero = "EscribeFichero.txt";
                        EscribeFicheroTexto(fichero);
                    }
                    break;

                case 6:
                    {
                        LeeFicheroTexto("EscribeFichero.txt");
                    }
                    break;

                case 7:
                    {
                        string fichero1, fichero2;

                        fichero1 = "EscribeFichero.txt";
                        fichero2 = "CopiaFichero.txt";

                        CopiaFicheroTexto(fichero1, fichero2);
                    }
                    break;

                case 8:
                    {
                        InvierteLineasFichero("EscribeFichero.txt", "Inviertelineas.txt");
                    }
                    break;

                case 9:
                    {
                        InvierteFicheroTexto("EscribeFichero.txt", "invierte.txt");
                    }
                    break;

                case 10:
                    {
                        SeparaPalabrasFichero("frases.txt", "separadas.txt");
                    }
                    break;

                default: Console.WriteLine("Ejercicio no válido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
