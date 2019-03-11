using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FicherosBinarios
{
    class Program
    {
        /// <summary>
        /// Función que escribe los números del 1 a 100 en un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        static void EscribeFichero1_100(string fichero)//Ejercicio 1
        {
            int n;

            n = 1;

            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);


            while(n <= 100)
            {
                bw.Write(n);
                n++;
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Función que lee los primeros 100 valores de un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        static void LeeFicheroInt100(string fichero)//Ejercicio 2
        {
            int i, n;

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            for(i = 0; i < 100; i++)
            {
                n = br.ReadInt32();
                Console.WriteLine(n);
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Función que escribe que escribe números aleatorios en un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        /// <param name="n">Total de números que escribirá en el fichero binario</param>
        static void EscribeFicheroIntAleatorio(string fichero, int n)//Ejercicio 3
        {
            int i;

            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            Random rnd = new Random();

            for(i = 0; i < n; i++)
            {
                bw.Write(rnd.Next(1, 100));
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Función que escribe números aleatorios comprendidos entre los que les digas en un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        /// <param name="total">Total de números que escribirá</param>
        /// <param name="min">El mínimo de los valores entre los que podrá tomar</param>
        /// <param name="max">El máximo de los valores entre los que podrá tomar</param>
        static void EscribeFicheroIntAleatorioPro(string fichero, int total, int min, int max)//Ejercicio 4
        {
            int i;

            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            Random rnd = new Random();

            for(i = 0; i < total; i++)
            {
                bw.Write(rnd.Next(min, max));
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Función que lee los enteros de un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        static void LeeFicheroInt(string fichero)//Ejercicio 5
        {
            int n;

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while(fs.Position < fs.Length)
            {
                n = br.ReadInt32();
                Console.WriteLine(n);
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Función que suma los enteros de un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        /// <returns>Suma de los enteros del fichero binario</returns>
        static int SumaFicheroInt(string fichero)//Ejercicio 6
        {
            int suma;
            suma = 0;

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while(fs.Position < fs.Length)
            {
                suma = suma + br.ReadInt32();
            }

            br.Close();
            fs.Close();

            return suma;
        }



        static void EscribeLista(List<int> l)
        {
            int i;
            Console.Write("< ");
            for (i = 0; i < l.Count - 1; i++)
            {
                Console.Write(l[i] + ", ");
            }
            Console.WriteLine(l[l.Count - 1] + " >");
        }

        /// <summary>
        /// Función que lee los enteros de un fichero binario mediante una lista
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        /// <returns>Lista con los enteros del fichero binario</returns>
        static List<int> LeeFicheroIntLista(string fichero)//Ejercicio 7
        {
            List<int> l = new List<int>();
            
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while(fs.Position < fs.Length)
            {
                l.Add(br.ReadInt32());
            }

            br.Close();
            fs.Close();

            return l;
        }

        /// <summary>
        /// Función que ordena los enteros de un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        static void OrdenaFicheroInt(string fichero)//Ejercicio 8
        {
            int i;

            List<int> l = new List<int>();
                 
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while(fs.Position < fs.Length)
            {
                l.Add(br.ReadInt32());
            }

            br.Close();
            fs.Close();

            l.Sort();

            FileStream fs1 = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs1);

            for(i = 0; i < l.Count; i++)
            {
                bw.Write(l[i]);
            }

            bw.Close();
            fs1.Close();
        }

        /// <summary>
        /// Función que clasifica los números positivos y negativos de un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        static void SeparaFicheroInt(string fichero)//Ejercicio 9
        {
            int n;

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            FileStream fs1 = new FileStream(fichero + "positivos", FileMode.Create);
            BinaryWriter bw1 = new BinaryWriter(fs1);

            FileStream fs2 = new FileStream(fichero + "negativos", FileMode.Create);
            BinaryWriter bw2 = new BinaryWriter(fs2);


            while(fs.Position < fs.Length)
            {
                n = br.ReadInt32();

                if (n < 0)
                {
                    bw1.Write(n);
                }
                else
                {
                    bw2.Write(n);
                }
            }

            fs.Close();
            br.Close();
            fs1.Close();
            bw1.Close();
            fs2.Close();
            bw2.Close();
        }

        /// <summary>
        /// Función que invierte las posiciones de un fichero binario
        /// </summary>
        /// <param name="fichero">Fichero binario</param>
        static void InvierteFicheroInt(string fichero)//Ejercicio 10
        {
            int i;

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            List<int> l = new List<int>();

            while(fs.Position < fs.Length)
            {
                l.Add(br.ReadInt32());
            }

            br.Close();
            fs.Close();

            FileStream fs1 = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs1);

            for(i = l.Count - 1; i >= 0; i--)
            {
                bw.Write(l[i]);
            }

            fs1.Close();
            bw.Close();
        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU DE FICHEROS BINARIOS");
            Console.WriteLine("=========================");
            Console.WriteLine(" 1- EscribeFichero1_100");
            Console.WriteLine(" 2- LeeFicheroInt100");
            Console.WriteLine(" 3- EscribeFicheroIntAleatorio");
            Console.WriteLine(" 4- EscribeFicheroIntAleatorioPro");
            Console.WriteLine(" 5- LeeFicheroInt");
            Console.WriteLine(" 6- SumaFicheroInt");
            Console.WriteLine(" 7- LeeFicheroIntLista");
            Console.WriteLine(" 8- OrdenaFicheroInt");
            Console.WriteLine(" 9- SeparaFicheroInt");
            Console.WriteLine(" 10- InvierteFicheroInt");

            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        string fichero = "datos01.bin";

                        EscribeFichero1_100(fichero);
                    }
                    break;

                case 2:
                    {
                        LeeFicheroInt100("datos01.bin");
                    }
                    break;

                case 3:
                    {
                        string fichero = "datos01_random.bin";
                        int n = 11;

                        EscribeFicheroIntAleatorio(fichero, n);
                    }
                    break;

                case 4:
                    {
                        string fichero = "randompro.bin";
                        int valor, min, max;

                        valor = 10;
                        min = 5;
                        max = 11;

                        EscribeFicheroIntAleatorioPro(fichero, valor, min, max);
                    }
                    break;

                case 5:
                    {
                        LeeFicheroInt("randompro.bin");
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine(SumaFicheroInt("randompro.bin"));
                    }
                    break;

                case 7:
                    {
                        EscribeLista(LeeFicheroIntLista("randompro.bin"));
                    }
                    break;

                case 8:
                    {
                        OrdenaFicheroInt("randompro.bin");
                        LeeFicheroInt("randompro.bin");
                    }
                    break;

                case 9:
                    {
                        EscribeFicheroIntAleatorioPro("negatipositivo.bin", 10, -3, 3);

                        SeparaFicheroInt("negatipositivo.bin");

                        LeeFicheroInt("negatipositivo.binpositivos");
                        LeeFicheroInt("negatipositivo.binnegativos");
                    }
                    break;

                case 10:
                    {
                        EscribeFicheroIntAleatorioPro("inviertefichero.bin", 10, 1, 10);
                        LeeFicheroInt("inviertefichero.bin");

                        Console.WriteLine("Invertido:");
                        InvierteFicheroInt("inviertefichero.bin");
                        LeeFicheroInt("inviertefichero.bin");
                    }
                    break;

                default: Console.WriteLine("Ejercicio no válido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
