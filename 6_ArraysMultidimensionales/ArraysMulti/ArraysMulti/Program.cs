using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMulti
{
    class Program
    {
        /// <summary>
        /// Función que escribe un array bidimensional de tamaño 3x3
        /// </summary>
        /// <param name="a">array 3x3</param>
        static void EscribeArray3x3(int[,] a)//Ejercicio 1
        {
            int i, j;

            for(i = 0; i < 3; i++)
            {
                Console.Write("| ");

                for(j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.Write("|");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Función que rellena un array3x3 con números del 1 al 9
        /// </summary>
        /// <param name="a">array 3x3</param>
        static void Rellena3x3(int[,] a)//Ejercicio 2
        {
            int i, j, cont;

            cont = 1;

            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    a[i,j] = cont;
                    cont++;
                }
            }
        }

        /// <summary>
        /// Función que rellena un array3x3 con números aleatorios
        /// </summary>
        /// <param name="a">array 3x3</param>
        static void RellenaAleatorio3x3(int[,] a)//Ejercicio 3
        {
            int i, j;

            Random rnd = new Random();

            for (i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    a[i, j] = rnd.Next(0, 11);
                }
            }
        }

        /// <summary>
        /// Función que suma todos los números de un array 3x3
        /// </summary>
        /// <param name="a">array3x3</param>
        /// <returns>La suma de todos los números del array 3x3</returns>
        static int SumaArray3x3(int[,] a)//Ejercicio 4
        {
            int i, j, suma;

            suma = 0;

            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    suma = suma + a[i, j];
                }
            }

            return suma;
        }

        /// <summary>
        /// Función que escribe por pantalla un array bidimensional de cualquier dimnensión
        /// </summary>
        /// <param name="a">array bidimensional</param>
        static void EscribeArrayBi(int[,] a)//Ejercicio 5
        {
            int i, j;

            for (i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("| ");

                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.Write("|");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Función que rellena un array bidimensional de cualquier tamaño con números aleatorios
        /// </summary>
        /// <param name="a">array bidimensional</param>
        static void RellenaAleatorioBi(int[,] a)//Ejercicio 6
        {
            int i, j;

            Random rnd = new Random();

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(0, 11);
                }
            }
        }

        /// <summary>
        /// Función que rellena un array bidimensional con números a partir del 1 en orden.
        /// </summary>
        /// <param name="a">array bidimensional</param>
        static void RellenaEnOrdenBi(int[,] a)//Ejercicio 7
        {
            int i, j, cont;

            cont = 1;

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = cont;
                    cont++;
                }
            }
        }

        /// <summary>
        /// Función que suma los números de un array bidimensional
        /// </summary>
        /// <param name="a">array bidimensional</param>
        /// <returns>la suma de sus números</returns>
        static int SumaArrayBi(int[,] a)//Ejercicio 8
        {
            int i, j, suma;
            suma = 0;

            for(i = 0; i < a.GetLength(0); i++)
            {
                for(j = 0; j < a.GetLength(1); j++)
                {
                    suma = suma + a[i, j];
                }
            }

            return suma;
        }

        /// <summary>
        /// Función que suma los elementos de las posiciones dos arrays bidimensionales y guarda el resultado en un tercero
        /// </summary>
        /// <param name="a">Array bidimensional 1</param>
        /// <param name="b">Array bidimensional 2</param>
        /// <returns>Array con la suma de los elementos de las posiciones de a + b</returns>
        static int[,] Suma2ArraysBi(int[,] a, int[,] b)//Ejercicio 9
        {
            int i, j;

            int[,] res = new int[a.GetLength(0), a.GetLength(1)];

            
            for(i = 0; i < a.GetLength(0); i++)
            {
                for(j = 0; j < a.GetLength(1); j++)
                {
                    res[i, j] = a[i, j] + b[i, j];
                }
            }

            return res;
        }

        /// <summary>
        /// Función que copia el contenido del primer array en el segundo
        /// </summary>
        /// <param name="a">Array 1</param>
        /// <param name="b">Array 2</param>
        static void CopiaArrayBi(int[,] a, int[,] b)//Ejercicio 10
        {
            int i, j;

            if(a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1))
            {
                for (i = 0; i < a.GetLength(0); i++)
                {
                    for (j = 0; j < a.GetLength(1); j++)
                    {
                        b[i, j] = a[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("Los arrays deben tener las mismas dimensiones.");
            }
        }

        /// <summary>
        /// Función que devuelve otro array como copia del primero
        /// </summary>
        /// <param name="a">Array a copiar</param>
        /// <returns>Copia del array</returns>
        static int[,] CopiaArrayBiPro(int[,] a)//Ejercicio 11
        {
            int[,] res = new int[a.GetLength(0), a.GetLength(1)];

            CopiaArrayBi(a, res);

            return res;
        }
 
        /// <summary>
        /// Función que rellena un array 8x8 con la forma de un tablero de ajedrez
        /// </summary>
        /// <param name="a"></param>
        static void RellenaArrayAjedrez(int[,] a)//Ejercicio 12
        {
            int i, j;

            for(i = 0; i < a.GetLength(0); i++)
            {
                for(j = 0; j < a.GetLength(1); j++)
                {
                    if((i + j) % 2 == 0)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Función que rellena el array bidimensional cuadrado, con 1 -> diagonal, 2-> cuadrado que queda por encima, 3-> cuadrado por debajo
        /// </summary>
        /// <param name="a">array bidimensional cuadrado</param>
        static void RellenaDiagonal(int[,] a)//Ejercicio 13
        {
            int i, j;

            for(i = 0; i < a.GetLength(0); i++)
            {
                for(j = 0; j < a.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if(i > j)
                        {
                            a[i, j] = 3;
                        }
                        else
                        {
                            if(i < j)
                            {
                                a[i, j] = 2;
                            }
                        }
                    }
                }
            }

        }

        /// <summary>
        /// Función que rellena un array cuadrado con 1-> diagonal, 2 -> resto
        /// </summary>
        /// <param name="a"></param>
        static void RellenaX(int[,] a)//Ejercicio 14
        {
            int i, j;

            for(i = 0; i < a.GetLength(0); i++)
            {
                for(j = 0; j < a.GetLength(1); j++)
                {
                    if(i == j || (i + j) == (a.GetLength(0) - 1))
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        a[i, j] = 2;
                    }
                }
            }
        }

        /// <summary>
        /// Función que rellena un array cuadrado de lado par en cuatro cuadros.
        /// 1-> cuadro superior izquierdo ; 2-> superior derecho ; 3-> inferior izquierdo ; 4-> inferior derecho
        /// </summary>
        /// <param name="a">Array cuadrado de lados pares</param>
        static void RellenaCuadros(int[,] a)//Ejercicio 15
        {
            if(a.GetLength(0) % 2 == 0)
            {
                int i, j;

                for(i = 0; i < a.GetLength(0); i++)
                {
                    for(j = 0; j < a.GetLength(1); j++)
                    {
                        if(i < (a.GetLength(0) / 2) && j < (a.GetLength(1) / 2))
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            if(i < (a.GetLength(0) / 2) && j >= (a.GetLength(1) / 2))
                            {
                                a[i, j] = 2;
                            }
                            else
                            {
                                if (i >= (a.GetLength(0) / 2) && j < (a.GetLength(1) / 2))
                                {
                                    a[i, j] = 3;
                                }
                                else
                                {
                                    if (i >= (a.GetLength(0) / 2) && j >= (a.GetLength(1) / 2))
                                    {
                                        a[i, j] = 4;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Debe ser un array cuadrado de lado PAR: 2x2, 4x4, 6x6...");
            }
        }


        //--------------------------- Ejercicios adicionales ----------------------------

        /// <summary>
        /// Función que invierte un array bidimensional cuadrado
        /// </summary>
        /// <param name="a">array bidimensional</param>
        static void InvierteBi(int[,] a)//Ejercicio 16
        {
            int i, j, t, z;

            t = 0;
            z = 0;

            if(a.GetLength(0) == a.GetLength(1))
            {
                int[,] copia = new int[a.GetLength(0), a.GetLength(1)];

                for(i = 0; i < a.GetLength(0); i++)
                {
                    for(j = 0; j < a.GetLength(1); j++)
                    {
                        copia[t, z] = a[i, j];
                        t++;
                    }
                    t = 0;
                    z++;
                }

                CopiaArrayBi(copia, a);
            }
            else
            {
                Console.WriteLine("El array bidimensional tiene que ser cuadrado");
            }
           
        }

        /// <summary>
        /// Función que calcula el determinante de un array 3x3
        /// </summary>
        /// <param name="a">array3x3</param>
        /// <returns>Determinante</returns>
        static int CalculaDeterminante(int[,] a)//Ejercicio 17
        {
            int det, p1, p2;

            p1 = (a[0, 0] * a[1, 1] * a[2, 2]) + (a[0, 1] * a[1, 2] * a[2, 0]) + (a[0, 2] * a[1, 0] * a[2, 1]);
            p2 = (a[0, 2] * a[1, 1] * a[2, 0]) + (a[0, 1] * a[1, 0] * a[2, 2]) + (a[0, 0] * a[1, 2] * a[2, 1]);

            det = p1 - p2;

            return det;
        }



        // CUADRADO MÁGICO


        /// <summary>
        /// Suma las filas del array 3x3
        /// </summary>
        /// <param name="a">array 3x3</param>
        /// <returns>la suma de una de sus columnas si el resultado de la suma de todas es el mismo, sino devuelve -1</returns>
        static int SumaFilas(int[,] a)
        {
            int i, j, suma1, suma2, suma3;

            suma1 = 0;
            suma2 = 0;
            suma3 = 0;

            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    if(i == 0)
                    {
                        suma1 = suma1 + a[i, j];
                    }
                    else
                    {
                        if(i == 1)
                        {
                            suma2 = suma2 + a[i, j];
                        }
                        else
                        {
                            if(i == 2)
                            {
                                suma3 = suma3 + a[i, j];
                            }
                        }
                    }
                }
            }

            if(suma1 == suma2 && suma1 == suma3)
            {
                return suma1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Suma de columnas del array 3x3
        /// </summary>
        /// <param name="a">array 3x3</param>
        /// <returns>Suma de una de sus columnas si la suma de cada una es igual al de las demas, sino 0</returns>
        static int SumaColumnas(int[,] a)
        {
            int i, j, suma1, suma2, suma3;

            suma1 = 0;
            suma2 = 0;
            suma3 = 0;

            for (j = 0; j < 3; j++)
            {
                for (i = 0; i < 3; i++)
                {
                    if (j == 0)
                    {
                        suma1 = suma1 + a[j, i];
                    }
                    else
                    {
                        if (j == 1)
                        {
                            suma2 = suma2 + a[j, i];
                        }
                        else
                        {
                            if (j == 2)
                            {
                                suma3 = suma3 + a[j, i];
                            }
                        }
                    }
                }
            }

            if (suma1 == suma2 && suma1 == suma3)
            {
                return suma1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Suma de diagonales del array 3x3
        /// </summary>
        /// <param name="a">array3x3</param>
        /// <returns>la suma de una diagonal si el resultado de la suma de cada diagonal es el mismo, sino -1</returns>
        static int SumaDiagonales(int[,] a)
        {
            int i, j, d1, d2;

            d1 = 0;
            d2 = 0;
            
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        if (i + j == 2)
                        {
                            d2 = d2 + a[i, j];
                            d1 = d1 + a[i, j];
                        }
                        else
                        {
                            d1 = d1 + a[i, j];
                        }

                    }
                    else
                    {
                        if ((i + j) == 2) //2 es la longitud (3) - 1 = 2
                        {
                            d2 = d2 + a[i, j];
                        }
                    }
                }
            }

            if(d1 == d2)
            {
                return d1;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Función que dice si un array 3x3 es cuadrado perfecto o no
        /// </summary>
        /// <param name="a">array 3x3</param>
        /// <returns>Si es cuadrado perfecto o no</returns>
        static bool CuadradoMagico(int[,] a)//Ejercicio 18
        {
            int suma1, suma2, suma3;

            suma1 = SumaFilas(a);
            suma2 = SumaColumnas(a);
            suma3 = SumaDiagonales(a);

            
            if(suma1 == suma2 && suma1 == suma3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




        // SUDOKU

        /// <summary>
        /// Función que comprueba que un array de longitud 9, contiene los números del 1 al 9
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Si el array contiene los números del 1 al 9 o no.</returns>
        static bool CompruebaArray19(int[] a)
        {
            int i, cont1, cont2;

            cont1 = 0;
            cont2 = 0;

            List<int> l = new List<int>();

            for(i = 0; i < a.Length; i++)
            {
                l.Add(a[i]);
            }

            l.Sort();

            a = l.ToArray();

            for(i = 0; i < a.Length - 1; i++)
            {
                if(a[i] < 1 || a[i] > 9)
                {
                    cont1++;
                }
                else
                {
                    if(a[i] != a[i + 1] - 1)
                    {
                        cont2++;
                    }
                }
            }

            if (cont1 == 0 && cont2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Función que comprueba que las filas del array 9x9 (sudoku) tengan los números del 1 al 9
        /// </summary>
        /// <param name="a">array 9x9 (sudoku)</param>
        /// <returns>Si las filas del array 9x9(sudoku) tiene los números del 1 al 9 o no</returns>
        static int CompruebaFilas(int[,] a)
        {
            int i, j, cont;
            cont = 0;

            List<int> l = new List<int>();

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    l.Add(a[i, j]);
                }

                if (CompruebaArray19(l.ToArray()) == false)
                {
                    cont++;
                    l.Clear();
                }
                else
                {
                    l.Clear();
                }
            }

            return cont;
        }

        /// <summary>
        /// Función que comprueba que las columnas del array 9x9 (sudoku) tengan los números del 1 al 9
        /// </summary>
        /// <param name="a">array 9x9 (sudoku)</param>
        /// <returns>Si las columnas del array 9x9(sudoku) tiene los números del 1 al 9 o no</returns>
        static int CompruebaColumnas(int[,] a)
        {
            int i, j, cont;

            cont = 0;

            List<int> l = new List<int>();

            for (j = 0; j < a.GetLength(0); j++)
            {
                for (i = 0; i < a.GetLength(1); i++)
                {
                    l.Add(a[j, i]);
                }

                if (CompruebaArray19(l.ToArray()) == false)
                {
                    cont++;
                    l.Clear();
                }
                else
                {
                    l.Clear();
                }
            }

            return cont;
        }

        /// <summary>
        /// Función que comprueba que las submatrices3x3 del array 9x9 (sudoku) tengan los números del 1 al 9
        /// </summary>
        /// <param name="a">array 9x9</param>
        /// <returns>Si las submatrices 3x3 del array 9x9(sudoku) tiene los números del 1 al 9 o no</returns>
        static int CompruebaSubmatriz(int[,] a)
        {
            int i, j, cont;

            cont = 0;

            List<int> l = new List<int>();
            //Primera columna de submatrices 3x3
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        l.Add(a[i, j]);
                        if (CompruebaArray19(l.ToArray()) == false)
                        {
                            cont++;
                            l.Clear();
                        }
                        else
                        {
                            l.Clear();
                        }
                    }
                    else
                    {
                        if (i == 5 && j == 2)
                        {
                            l.Add(a[i, j]);
                            if (CompruebaArray19(l.ToArray()) == false)
                            {
                                cont++;
                                l.Clear();
                            }
                            else
                            {
                                l.Clear();
                            }
                        }
                        else
                        {
                            if (i == 8 && j == 2)
                            {
                                l.Add(a[i, j]);
                                if (CompruebaArray19(l.ToArray()) == false)
                                {
                                    cont++;
                                    l.Clear();
                                }
                                else
                                {
                                    l.Clear();
                                }
                            }
                            else
                            {
                                l.Add(a[i, j]);
                            }
                        }
                    }
                }
            }

            //Segunda columna de submatrices 3x3
            for (i = 0; i < 9; i++)
            {
                for (j = 3; j < 6; j++)
                {
                    if (i == 2 && j == 5)
                    {
                        l.Add(a[i, j]);
                        if (CompruebaArray19(l.ToArray()) == false)
                        {
                            cont++;
                            l.Clear();
                        }
                        else
                        {
                            l.Clear();
                        }
                    }
                    else
                    {
                        if (i == 5 && j == 5)
                        {
                            l.Add(a[i, j]);
                            if (CompruebaArray19(l.ToArray()) == false)
                            {
                                cont++;
                                l.Clear();
                            }
                            else
                            {
                                l.Clear();
                            }
                        }
                        else
                        {
                            if (i == 8 && j == 5)
                            {
                                l.Add(a[i, j]);
                                if (CompruebaArray19(l.ToArray()) == false)
                                {
                                    cont++;
                                    l.Clear();
                                }
                                else
                                {
                                    l.Clear();
                                }
                            }
                            else
                            {
                                l.Add(a[i, j]);
                            }
                        }
                    }

                }
            }

            //Tercera columna de submatrices 3x3
            for (i = 0; i < 9; i++)
            {
                for (j = 6; j < 9; j++)
                {
                    if (i == 2 && j == 8)
                    {
                        l.Add(a[i, j]);
                        if (CompruebaArray19(l.ToArray()) == false)
                        {
                            cont++;
                            l.Clear();
                        }
                        else
                        {
                            l.Clear();
                        }
                    }
                    else
                    {
                        if (i == 5 && j == 8)
                        {
                            l.Add(a[i, j]);
                            if (CompruebaArray19(l.ToArray()) == false)
                            {
                                cont++;
                                l.Clear();
                            }
                            else
                            {
                                l.Clear();
                            }
                        }
                        else
                        {
                            if (i == 8 && j == 8)
                            {
                                l.Add(a[i, j]);
                                if (CompruebaArray19(l.ToArray()) == false)
                                {
                                    cont++;
                                    l.Clear();
                                }
                                else
                                {
                                    l.Clear();
                                }
                            }
                            else
                            {
                                l.Add(a[i, j]);
                            }
                        }
                    }

                }
            }


            return cont;
        }


        /// <summary>
        /// Función que comprueba si un sudoku es correcto o no.
        /// </summary>
        /// <param name="a">Array 9x9 (sudoku)</param>
        /// <returns>Si es correcto o no el sudoku</returns>
        static bool CompruebaSudoku(int[,] a)//Ejercicio 19
        {
            
            if(CompruebaFilas(a) == 0 && CompruebaColumnas(a) == 0 && CompruebaSubmatriz(a) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        // HUNDIR LA FLOTA

        
        




            static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU DE ARRAYS MULTIDIMENSIONALES");
            Console.WriteLine("=================================");
            Console.WriteLine(" 1- EscribeArray3x3");
            Console.WriteLine(" 2- Rellena3x3");
            Console.WriteLine(" 3- RellenaAleatorio3x3");
            Console.WriteLine(" 4- SumaArray3x3");
            Console.WriteLine(" 5- EscribeArrayBi");
            Console.WriteLine(" 6- RellenaAleatorioBi");
            Console.WriteLine(" 7- RellenaEnOrdenBi");
            Console.WriteLine(" 8- SumaArrayBi");
            Console.WriteLine(" 9- Suma2ArraysBi");
            Console.WriteLine(" 10- CopiaArrayBi");
            Console.WriteLine(" 11- CopiaArrayBiPro");
            Console.WriteLine(" 12- RellenaArrayAjedrez");
            Console.WriteLine(" 13- RellenaDiagonal");
            Console.WriteLine(" 14- RellenaX");
            Console.WriteLine(" 15- RellenaCuadros");
            Console.WriteLine();
            Console.WriteLine("-----Adicionales-----");
            Console.WriteLine(" 16- InvierteBi");
            Console.WriteLine(" 17- CalculaDeterminante");
            Console.WriteLine(" 18- CuadradoMagico");
            Console.WriteLine(" 19- CompruebaSudoku");

            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9 } };
                        EscribeArray3x3(array);
                    }
                    break;

                case 2:
                    {
                        int[,] array = new int[3, 3];
                        Rellena3x3(array);
                        EscribeArray3x3(array);
                    }
                    break;

                case 3:
                    {
                        int[,] a = new int[3, 3];
                        RellenaAleatorio3x3(a);

                        EscribeArray3x3(a);
                    }
                    break;

                case 4:
                    {
                        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                        Console.WriteLine(SumaArray3x3(a));
                    }
                    break;

                case 5:
                    {
                        int[,] a = { { 1, 2 }, { 1, 2 } };
                        EscribeArrayBi(a);
                    }
                    break;

                case 6:
                    {
                        int[,] a = new int[5, 2];
                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 7:
                    {
                        int[,] a = new int[7, 3];
                        RellenaEnOrdenBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 8:
                    {
                        int[,] a = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
                        Console.WriteLine(SumaArrayBi(a));
                    }
                    break;

                case 9:
                    {
                        int[,] a = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
                        int[,] b = { { 5, 4, 3, 2, 1 }, { 10, 9, 8, 7, 6 } };

                        EscribeArrayBi(Suma2ArraysBi(a, b));
                    } 
                    break;

                case 10:
                    {
                        int[,] a = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
                        int[,] b = new int[2, 5];

                        CopiaArrayBi(a, b);
                        EscribeArrayBi(b);
                    }
                    break;

                case 11:
                    {
                        int[,] a = { { 1, 2, 3 }, { 3, 2, 1 }, { 11, 3, 16 } };

                        EscribeArrayBi(CopiaArrayBiPro(a));
                    }
                    break;

                case 12:
                    {
                        int[,] ajedrez = new int[8, 8];
                        RellenaArrayAjedrez(ajedrez);

                        EscribeArrayBi(ajedrez);
                    }
                    break;

                case 13:
                    {
                        int[,] cuadrado = new int[9,9];
                        RellenaDiagonal(cuadrado);

                        EscribeArrayBi(cuadrado);
                    }
                    break;

                case 14:
                    {
                        int[,] cuadrado = new int[5,5];
                        RellenaX(cuadrado);

                        EscribeArrayBi(cuadrado);
                    }
                    break;

                case 15:
                    {
                        int[,] a = new int[8,8];
                        RellenaCuadros(a);

                        EscribeArrayBi(a);
                    }
                    break;

                case 16:
                    {
                        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                        InvierteBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 17:
                    {
                        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                        Console.WriteLine(CalculaDeterminante(a));
                    }
                    break;

                case 18:
                    {
                        int[,] a = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };

                        if (CuadradoMagico(a))
                        {
                            Console.WriteLine("Es un cuadrado mágico");
                        }
                        else
                        {
                            Console.WriteLine("No es un cuadrado mágico");
                        }
                    }
                    break;


                case 19:
                    {
                        int[,] a = { { 4, 3, 9, 5, 6, 1, 7, 2, 8 }, { 1, 6, 7, 2, 3, 8, 4, 5, 9 }, { 8, 5, 2, 4, 9, 7, 6, 1, 3 }, { 2, 8, 6, 9, 5, 3, 1, 7, 4 }, { 7, 9, 4, 8, 1, 6, 5, 3, 2 }, { 5, 1, 3, 7, 2, 4, 9, 8, 6 }, { 3, 4, 8, 1, 7, 9, 2, 6, 5 }, { 6, 2, 1, 3, 4, 5, 8, 9, 7 }, { 9, 7, 5, 6, 8, 2, 3, 4, 1 } };

                        if (CompruebaSudoku(a))
                        {
                            Console.WriteLine("El Sudoku es correcto. ¡Felicidades!");
                        }
                        else
                        {
                            Console.WriteLine("Has hecho mal el Sudoku. ¡NOOB!");
                        }

                    }
                    break;


                default: Console.WriteLine("Ejercicio no válido"); break;
            }

            Console.ReadKey();
        }
    }
}
