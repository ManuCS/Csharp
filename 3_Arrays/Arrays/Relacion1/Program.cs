using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion1
{
    class Program
    {
        //------------------Relación1-----------------------
        /// <summary>
        /// Escribe un array de enteros de 5 elementos
        /// </summary>
        /// <param name="a">array de 5 elementos</param>
        static void EscribeArray5(int[] a)//Ejercicio 1
        {
            int i;

            if(a.Length == 5)
            {
                Console.Write("[");
                for(i = 0; i < 4; i++)
                {
                    Console.Write(a[i] + ",");
                }

                Console.Write(a[i] + "]");
            }
            else
            {
                Console.WriteLine("El array no tiene 5 elementos");
            }
        }

        /// <summary>
        /// Escribe un array de enteros del tamaño que sea.
        /// </summary>
        /// <param name="a">array de enteros</param>
        static void EscribeArray(int[] a)//Ejercicio 2
        {
            int i;

            Console.Write("[");
            for(i = 0; i < (a.Length - 1); i++)
            {
                Console.Write(a[i] + ",");
            }

            Console.Write(a[i] + "]");
        }

        /// <summary>
        /// Lee un array de enteros de 5 elementos
        /// </summary>
        /// <param name="a">Array de 5 elementos</param>
        static void LeeArray5(int[] a) //Ejercicio 3
        {
            int i;

            Console.WriteLine("Escribe un array de 5 elementos: ");

            for (i = 0; i < 5; i++)
            {
                Console.Write("Escribe el elemento " + i + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Lee array de enteros de cualquier tamaño
        /// </summary>
        /// <param name="a">Array ya definido</param>
        static void LeeArray(int[] a)//Ejercicio 4
        {
            int i;

            Console.WriteLine("Escribe un array de " + a.Length + " elementos:");

            for(i = 0; i < a.Length; i++)
            {
                Console.Write("Escribe el elemento " + i + ": ");

                a[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Array que pone 0 en todas las posiciones de un array de 5 enteros
        /// </summary>
        /// <param name="a">Array</param>
        static void PonCeros5(int[] a)//Ejercicio 5
        {
            int i;

            for (i = 0; i < 5; i++)
            {
                a[i] = 0;
            }

        }

        /// <summary>
        /// Array que pone 0 en todas las posiciones de un array de enteros
        /// </summary>
        /// <param name="a">Array</param>
        static void PonCero(int[] a)//Ejercicio 6
        {
            int i;

            for(i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }

        /// <summary>
        /// Funcion que devuelve la suma de las posiciones de un array de 5 enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Devuelve la suma de las posiciones de un array de 5 enteros</returns>
        static int SumaArray5(int[] a)//Ejercicio 7
        {
            int i, suma;

            suma = 0;

            for (i = 0; i < 5; i++)
            {
                suma = suma + a[i];
            }

            return suma;
        }

        /// <summary>
        /// Funcion que devuelve la suma de las posiciones de un array de enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Suma de las posiciones de un array de enteros</returns>
        static int SumaArray(int[] a)//Ejercicio 8
        {
            int i, suma;
            suma = 0;

            for(i = 0; i < a.Length; i++)
            {
                suma = suma + a[i];
            }

            return suma;
        }

        /// <summary>
        /// Funcion que devuelve la media de las posiciones de un array de 5 enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Suma de las posiciones de un array de 5 enteros</returns>
        static int MediaArray5(int[] a)//Ejercicio 9
        {
            int media;

            media = SumaArray5(a) / 5;

            return media;
        }

        /// <summary>
        /// Función que devuelve la media de las posiciones de un array de enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Devuelve la media de las posiciones de "a"</returns>
        static int MediaArray(int[] a)//Ejercicio 10
        {
            int media;

            media = SumaArray(a) / a.Length;

            return media;
        }
        
        //------------------Relación2-----------------------
    
        /// <summary>
        /// Función que rellena un array de enteros con números del 1 en adelante
        /// </summary>
        /// <param name="a">Array</param>
        static void RellenaEnOrden(int[] a)//Ejercicio 11
        {
            int i, cont;
            cont = 1;

            for(i = 0; i < a.Length; i++)
            {
                a[i] = cont;
                cont++;
            }
        }

        /// <summary>
        /// Función que rellena un array de enteros con números en orden descendiente desde el tamaño de array hasta 1
        /// </summary>
        /// <param name="a">Array</param>
        static void RellenaEnOrdenDesc(int[] a)//Ejercicio 12
        {
            int i, cont;

            cont = a.Length;

            for(i = 0; i < a.Length; i++)
            {
                a[i] = cont;
                cont--;
            }
        }

        /// <summary>
        /// Función que rellena un array de enteros con números aleatorios
        /// </summary>
        /// <param name="a">Array</param>
        static void RellenaAleatorio(int[] a)//Ejercicio 13
        {
            int i;
            Random num = new Random();

            for(i = 0; i < a.Length; i++)
            {
                a[i] = num.Next(0, 9);
            }
        }

        /// <summary>
        /// Función que dice si un array está ordenado de forma ascendente o no.
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns></returns>
        static bool EstaOrdenado(int[] a)//Ejercicio 14
        {
            int i, cuentafallo;//cuentafallo aumenta si un valor es menor que el anterior

            cuentafallo = 0;

            for(i = 0; i < a.Length - 1; i++)
            {
                if(a[i] > a[i + 1])
                {
                    cuentafallo++;
                }
            }

            if(cuentafallo == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Funcion que devuelve cuántos números impares hay en el array
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Número total de números impares</returns>
        static int NumeroImpares(int[] a)//Ejercicio 15
        {
            int i, impares;
            impares = 0;

            for(i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 != 0)
                {
                    impares++;
                }
            }

            return impares;
        }

        /// <summary>
        /// Funcion que devuelve el mínimo valor de un array de enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Mínimo valor de un array de enteros</returns>
        static int MinArray(int[] a)//Ejercicio 16
        {
            int i, min = a[0];

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Función que devuelve el máximo valor de un array de enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>máximo valor</returns>
        static int MaxArray(int[] a)//Ejercicio 17
        {
            int i, max = a[0];

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Función que devuelve el número de aprobados entre valores de un array de enteros
        /// </summary>
        /// <param name="a">Array de enteros(notas)</param>
        /// <returns>Número de aprobados</returns>
        static int NumeroAprobados(int [] a)//Ejercicio 18
        {
            int i, aprobados;

            aprobados = 0;

            for(i = 0; i < a.Length; i++)
            {
                if(a[i] >= 5 && a[i] <= 10)
                {
                    aprobados++;
                }
            }

            return aprobados;

        }

        /// <summary>
        /// Función que devuelve cuantos elementos de un array de enteros hay por encima de un valor límite que le pasamos
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Número de elementos que supera el límite</returns>
        static int PorEncimaDe(int [] a, int lim)//Ejercicio 19
        {
            int i, porencima;

            porencima = 0;

            for(i = 0; i < a.Length; i++)
            {
                if(a[i] >= lim)
                {
                    porencima++;
                }
            }

            return porencima;
        }

        /// <summary>
        /// Función que devuelve el número de ceros que hay en un array de enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Número de ceros</returns>
        static int CuantosCeros(int[] a)//Ejercicio 20
        {
            int i, ceros;

            ceros = 0;

            for(i = 0; i < a.Length; i++)
            {
                if(a[i] == 0)
                {
                    ceros++;
                }
            }

            return ceros;
        }


        //------------------Relación3-----------------------

        /// <summary>
        /// Funcion que copia el contenido del primer array en el segundo.
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        static void CopiaArray(int[] a, int[] b)//Ejercicio 21
        {
            int i;

            if(a.Length != b.Length)
            {
                Console.WriteLine("El tamaño de los arrays es diferente.");
            }
            else
            {
                for(i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
            } 
        }

        /// <summary>
        /// Funcion que copia el array1 invertido en el segundo
        /// </summary>
        /// <param name="a">array1</param>
        /// <param name="b">array2</param>
        static void CopiaArrayInvertido(int[] a, int[] b)//Ejercicio 22
        {
            int i, j;

            j = a.Length - 1;

            if(a.Length != b.Length)
            {
                Console.WriteLine("El tamaño de los arrays es diferente.");
            }
            else
            {
                for(i = 0; i < b.Length; i++)
                {
                    b[i] = a[j];
                    j--;
                }
            }
        }

        /// <summary>
        /// Funcion que suma arrays a y b y el resultado lo almacena en c
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <param name="c">Array3</param>
        static void SumaArrays(int[] a, int[] b, int[] c)//Ejercicio 23
        {
            int i;

            if(a.Length == b.Length && a.Length == c.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    c[i] = a[i] + b[i];
                }
                EscribeArray(c);
            }
            else
            {
                Console.WriteLine("El tamaño de los arrays es diferente.");
            }
        }


        /// <summary>
        /// Funcion que resta arrays a y b y el resultado lo almacena en c
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <param name="c">Array3</param>
        static void RestaArrays(int[] a, int[] b, int[] c)//Ejercicio 24
        {
            int i;

            if (a.Length == b.Length && a.Length == c.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    c[i] = a[i] - b[i];
                }
                EscribeArray(c);
            }
            else
            {
                Console.WriteLine("El tamaño de los arrays es diferente.");
            }
        }


        /// <summary>
        /// Funcion que multiplica arrays a y b y el resultado lo almacena en c
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <param name="c">Array3</param>
        static void MultiplicaArrays(int[] a, int[] b, int[] c)//Ejercicio 24
        {
            int i;

            if (a.Length == b.Length && a.Length == c.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    c[i] = a[i] * b[i];
                }
                EscribeArray(c);
            }
            else
            {
                Console.WriteLine("El tamaño de los arrays es diferente.");
            }
        }


        /// <summary>
        /// Funcion que multiplica arrays a y b y el resultado lo almacena en c
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <param name="c">Array3</param>
        static void DivideArrays(int[] a, int[] b, int[] c)//Ejercicio 24
        {
            int i;

            if (a.Length == b.Length && a.Length == c.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    if(b[i] == 0)
                    {
                        Console.WriteLine("Elemento del segundo array vale 0. Ningún valor del segundo array puede valer 0.");
                    }
                    else
                    {
                        c[i] = a[i] / b[i];
                    }
                }
                EscribeArray(c);
            }
            else
            {
                Console.WriteLine("El tamaño de los arrays es diferente.");
            }
        }

        /// <summary>
        /// Función que invierte una array
        /// </summary>
        /// <param name="a">array</param>
        static void InvierteArray(int[] a)//Ejercicio 25
        {
            int[] b = new int[a.Length];

            CopiaArrayInvertido(a, b);
            CopiaArray(b, a);
        }

        /// <summary>
        /// Función que dice si dos arrays son iguales o no.
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <returns>Verdadero si son iguales, o falso si no.</returns>
        static bool ComparaArrays(int[] a, int[] b)//Ejercicio 26
        {
            int i, diferentes;

            diferentes = 0;

            if(a.Length == b.Length)
            {
                for(i = 0; i < a.Length; i++)
                {
                    if(a[i] != b[i])
                    {
                        diferentes++;
                    }
                }
                
                if(diferentes == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        static void EscribeArrayBool(bool[] a)//Para comprobar ejercicio 27
        {
            int i;

            Console.Write("[");
            for (i = 0; i < (a.Length - 1); i++)
            {
                Console.Write(a[i] + ",");
            }

            Console.Write(a[i] + "]");
        }

        /// <summary>
        /// Función a la que pasamos las notas de los alumnos en Array1 y completa con true o false las posiciones de Array2 si es aprobado o no.
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        static void PonNotasArray(double[] a, bool[] b)//Ejercicio 27
        {
            int i;

            for(i = 0; i < a.Length; i++)
            {
                if (a[i] >= 5 && a[i] <= 10)
                {
                    b[i] = true;
                }
                else
                {
                    b[i] = false;
                }
            }
        }

        /// <summary>
        /// Funcion que concatena los datos de Array1 y Array2 de tamaño 5 en Array3
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <param name="c">Array3</param>
        static void ConcatenaArrays55(int[] a, int[] b, int[]c)//Ejercicio 28
        {
            int i, j;
            j = 5;
            for(i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            for(i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }
        }

        /// <summary>
        /// Función que concatena los datos de Array1 y Array2 en Array3 de cualquier tamaño
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <param name="c">Array3</param>
        static void ConcatenaArrays(int[] a, int[] b, int[] c)//Ejercicio 29
        {
            int i, j;

            j = b.Length;

            if(c.Length == a.Length + b.Length)
            {
                for(i = 0; i < a.Length; i++)
                {
                    c[i] = a[i];
                }


                for(i = 0; i < b.Length; i++)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            else
            {
                Console.WriteLine("La suma del tamaño del Array1 y del Array2 no es igual al tamaño del Array3.");
            }
        }

        /// <summary>
        /// Función que devuelve si un array contiene un número introducido o no.
        /// </summary>
        /// <param name="a">Array</param>
        /// <param name="num">Número que contiene o no.</param>
        /// <returns>True-> Si contiene el número / false -> si no lo contiene</returns>
        static bool Contiene(int[] a, int num)//Ejercicio 30
        {
            int i, cont;

            cont = 0;

            for(i = 0; i < a.Length; i++)
            {
                if(a[i] == num)
                {
                    cont++;
                }
            }

            if (cont > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //------------------Relación4-----------------------

        /// <summary>
        /// Funcion a la que le pasas dos arrays de enteros y devuelve un array cuyo tamaño es la suma de los dos y que contiene sus elementos.
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <returns>Array3, con datos concatenados de Array1 y Array2</returns>
        static int[] ConcatenaArraysPro(int[] a, int[] b)//Ejercicio 31
        {
            int i, j, tam;

            tam = a.Length + b.Length;

            int[] c = new int[tam];



            for(i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            j = a.Length;

            for(i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }

            return c;
        }

        /// <summary>
        /// Función que le pasas un array de enteros y devuelve un array del mismo tamaño con los mismos datos
        /// </summary>
        /// <param name="a">Array1</param>
        /// <returns>Array2</returns>
        static int [] CopiaArrayPro(int[] a)//Ejercicio 32
        {
            int i;

            int[] b = new int[a.Length];

            for(i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }

            return b;
        }

        /// <summary>
        /// Funcion que inserta un valor en una posicion de un array de enteros
        /// </summary>
        /// <param name="a">Array</param>
        /// <param name="num">Numero a introducir</param>
        /// <param name="pos">Posición en la que se va a introducir</param>
        static void InsertaEnArray(ref int[] a, ref int num, ref int pos)//Ejercicio 33
        {
            int i, j, tam;

            j = 0;

            tam = a.Length + 1;

            int[] b = CopiaArrayPro(a);
            Array.Resize(ref a, tam);

            for (i = 0; i < a.Length; i++)
            {
                if (i == pos)
                {
                    a[i] = num;
                }
                else
                {
                    a[i] = b[j];
                    j++;
                }
            }

        }

        /// <summary>
        /// Función que borra el elemento de la posición indicada.
        /// </summary>
        /// <param name="a">Array</param>
        /// <param name="pos">Posición la cual se borrará el elemento.</param>
        static void BorraDeArray(ref int[] a, ref int pos)//Ejercicio 34
        {
            int i, j, tam;

            j = 0;

            tam = a.Length - 1; 

            int[] b = a;

            Array.Resize(ref a, tam);

            for (i = 0; i <= pos; i++)
            {
                if(i != pos)
                {
                    a[i] = b[j];
                    j++;
                }
                else
                {
                    j++;
                }
            }

            for(i = pos; i < tam; i++)
            {
                a[i] = b[j];
                j++;
            }
        }

        /// <summary>
        /// Función que borra del array un valor introducido. Si se repite, solo se borra el primero.
        /// </summary>
        /// <param name="a">Array</param>
        /// <param name="valor">Valor a eliminar</param>
        static void Elimina1ElementoArray(ref int[] a, ref int valor)//Ejercicio 35
        {
            int i, pos, tam;
            
            pos = 0;

            tam = a.Length - 1;

            int[] b = a;

            Array.Resize(ref a, tam);

            if (Contiene(b, valor))
            {
                i = 0;

                while (b[i] != valor)
                {
                    i++;
                    pos++;
                }

                for (i = 0; i < pos; i++)
                {
                    if (b[i] != valor)
                    {
                        a[i] = b[i];
                    }
                }

                for(i = pos; i < tam; i++)
                {
                    a[i] = b[i + 1];
                }
            }
            else
            {
                Console.WriteLine("El array no contiene el valor introducido.");
            }

        }

        /// <summary>
        /// Función que borra del array los valores que sean iguales al valor introducido
        /// </summary>
        /// <param name="a">Array</param>
        /// <param name="valor">Valor</param>
        static void EliminaElementosArray(ref int[] a, ref int valor)//Ejercicio 36
        {
            int i, j, contador, tam;

            contador = 0;

            int[] b = a;

            for (i = 0; i < a.Length; i++)
            {
                if (b[i] == valor)
                {
                    contador++;
                }
            }

            tam = a.Length - contador;

            Array.Resize(ref a, tam);
            
            if (Contiene(b, valor))
            {
                j = 0;
                for(i = 0; i < b.Length; i++)
                {
                    if(b[i] != valor)
                    {
                        a[j] = b[i];
                        j++;
                    }
                }
            }
            else
            {
                Console.WriteLine("El array no contiene el valor.");
            }
        }

        /// <summary>
        /// Función que inserta un Array2 en la posición indicada del Array1
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="b">Array2</param>
        /// <param name="valor">Posición de Array1 donde se introducirá Array2</param>
        static void InsertaArrayEnArray(ref int[] a, ref int[] b, ref int valor)//Ejercicio 37
        {
            int i, j, k, tam;//j = contador de la copia de Array1 / k = contador del Array2

            tam = a.Length + b.Length;

            int[] c = a; //Copia de Array1

            Array.Resize(ref a, tam);

           
            int copiab = valor + b.Length; //Posición hasta la cual se insertará Array2 y inicio de volver a introducir Array1


            j = 0;


            if (Contiene(a, valor))
            {
                for (i = 0; i < valor; i++)
                {
                    a[i] = c[j];
                    j++;
                }

                k = 0;
                for (i = valor; i < copiab; i++)
                {
                    a[i] = b[k];
                    k++;
                }

                for (i = copiab; i < tam; i++)
                {
                    a[i] = c[j];
                    j++;
                }
            }
            else
            {
                Console.WriteLine("La posición indicada se sale de la longitud del Array1");
            }


        }

        /// <summary>
        /// Función que devuelve un subarray de un array.
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="pos1">Posición 1</param>
        /// <param name="pos2">Posición 2</param>
        /// <returns>devuelve el subarray</returns>
        static int[] SubArray(int[] a, int pos1, int pos2)//Ejercicio 38
        {
            int i, j, tam;

            tam = pos2 - (pos1 - 1);

            j = 0;

            int[] sub = new int[tam];

            for(i = pos1; i <= pos2; i++)
            {
                sub[j] = a[i];
                j++;
            }

            return sub;
        }

        /// <summary>
        /// Función que recorta el array por las posiciones que le pasamos.
        /// </summary>
        /// <param name="a">Array1</param>
        /// <param name="pos1">Posición 1</param>
        /// <param name="pos2">Posición 2</param>
        static void RecortaArray(ref int[] a, ref int pos1, ref int pos2)//Ejercicio 39
        {
            int i, j, tam;
            
            tam = pos2 - (pos1 - 1);
            
            int[] b = a;

            Array.Resize(ref a, tam);

            j = 0;

            for(i = pos1; i <= pos2; i++)
            {
                a[j] = b[i];
                j++;
            }

        }

        //------------------------------------------------
        //Ejercicio 40

        static int PosMinArray(int[] a)
        {
            int i, min, posicion;

            min = a[0];
            
            posicion = 0;

            for(i = 0; i < a.Length; i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                    posicion = i;
                }
            }

            return posicion;
        }

        /// <summary>
        /// Funcion que ordena un array de menor a mayor.
        /// </summary>
        /// <param name="a">Array</param>
        /// <returns>Devuelve otro array con los elementos del primer array ordenados de menor a mayor</returns>
        static int[] OrdenaSeleccion(int[] a)//Ejercicio 40
        {
            int i, min, j;

            int[] b = new int[a.Length];

            min = a[0];
            j = 0;
            
            for(i = 0; i < b.Length; i++)
            {
                b[i] = a[PosMinArray(a)];

                Elimina1ElementoArray(ref a, ref a[PosMinArray(a)]);
            }
            
            return b;
        }


        

        static bool CompruebaTarjeta(int[] a)
        {
            if(a.Length != 16)
            {
                return false;
            }
            else
            {

            }
        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU DE ARRAYS");
            Console.WriteLine("==============");

            //Ejercicios 
            Console.WriteLine("---------Primera Relación---------");
            Console.WriteLine("Ejercicio 1- EscribeArray5");
            Console.WriteLine("Ejercicio 2- EscribeArray");
            Console.WriteLine("Ejercicio 3- LeeArray5");
            Console.WriteLine("Ejercicio 4- LeeArray");
            Console.WriteLine("Ejercicio 5- PonCeros5");
            Console.WriteLine("Ejercicio 6- PonCero");
            Console.WriteLine("Ejercicio 7- SumaArray5");
            Console.WriteLine("Ejercicio 8- SumaArray");
            Console.WriteLine("Ejercicio 9- MediaArray5");
            Console.WriteLine("Ejercicio 10- MediaArray");
            Console.WriteLine();
            Console.WriteLine("--------Segunda Relación---------");
            Console.WriteLine("Ejercicio 11- RellenaEnOrden");
            Console.WriteLine("Ejercicio 12- RellenaEnOrdenDesc");
            Console.WriteLine("Ejercicio 13- RellenaAleatorio");
            Console.WriteLine("Ejercicio 14- EstaOrdenado");
            Console.WriteLine("Ejercicio 15- NumeroImpares");
            Console.WriteLine("Ejercicio 16- MinArray");
            Console.WriteLine("Ejercicio 17- MaxArray");
            Console.WriteLine("Ejercicio 18- NumeroAprobados");
            Console.WriteLine("Ejercicio 19- PorEncimaDe");
            Console.WriteLine("Ejercicio 20- CuantosCeros");
            Console.WriteLine();
            Console.WriteLine("--------Tercera Relación---------");
            Console.WriteLine("Ejercicio 21- CopiaArray");
            Console.WriteLine("Ejercicio 22- CopiaArrayInvertido");
            Console.WriteLine("Ejercicio 23- SumaArrays");
            Console.WriteLine("Ejercicio 24- RestaArrays, MultiplicaArrays y DivideArrays");
            Console.WriteLine("Ejercicio 25- InvierteArray");
            Console.WriteLine("Ejercicio 26- ComparaArray");
            Console.WriteLine("Ejercicio 27- PonNotasArray");
            Console.WriteLine("Ejercicio 28- ConcatenaArrays55");
            Console.WriteLine("Ejercicio 29- ConcatenaArrays");
            Console.WriteLine("Ejercicio 30- Cotiene");
            Console.WriteLine();
            Console.WriteLine("//--------Cuarta Relación--------");
            Console.WriteLine("Ejercicio 31- ConcatenaArraysPro");
            Console.WriteLine("Ejercicio 32- CopiaArrayPro");
            Console.WriteLine("Ejercicio 33- InsertaEnArray");
            Console.WriteLine("Ejercicio 34- BorraDeArray");
            Console.WriteLine("Ejercicio 35- Elimina1ElementoArray");
            Console.WriteLine("Ejercicio 36- EliminaElementosArray");
            Console.WriteLine("Ejercicio 37- InsertaArrayEnArray");
            Console.WriteLine("Ejercicio 38- SubArray");
            Console.WriteLine("Ejercicio 39- RecortaArray");
            Console.WriteLine("Ejercicio 40- OrdenaSeleccion");

            //Elegir opción
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        int[] a = { 10, 20, 30, 40, 50};
                        EscribeArray5(a);
                    }
                    break;

                case 2:
                    {
                        int[] a = { 10, 20, 30 };
                        EscribeArray(a);
                    }
                    break;

                case 3:
                    {
                        int[] a;
                        a = new int[5];
                        LeeArray5(a);
                        EscribeArray(a);
                    }
                    break;

                case 4:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);
                        EscribeArray(a);
                    }
                    break;

                case 5:
                    {
                        int[] a = {10, 20, 30, 40, 50 };
                        Console.WriteLine("Este es el array:");
                        EscribeArray5(a);
                        Console.WriteLine();
                        Console.WriteLine("Este es el array después de poner 0s:");
                        PonCeros5(a);
                        EscribeArray5(a);
                    }
                    break;

                case 6:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a); 
                    
                        Console.WriteLine("Este es el array:");
                        EscribeArray(a);

                        Console.WriteLine();

                        Console.WriteLine("Este es el array después de poner 0s:");
                        PonCero(a);
                        EscribeArray(a);
                    }
                    break;

                case 7:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);

                        Console.WriteLine("Este es el array:");
                        EscribeArray(a);

                        Console.WriteLine();

                        Console.WriteLine("La suma de las posiciones del array es: " + SumaArray5(a));
                    }
                    break;

                case 8:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("Este es el array:");
                        EscribeArray(a);

                        Console.WriteLine();

                        Console.WriteLine("La suma de las posiciones del array es: " + SumaArray(a));
                    }
                    break;

                case 9:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);

                        Console.WriteLine("Este es el array:");
                        EscribeArray(a);

                        Console.WriteLine();

                        Console.WriteLine("La media de las posiciones del array es: " + MediaArray5(a));
                    }
                    break;

                case 10:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("Este es el array:");
                        EscribeArray(a);

                        Console.WriteLine();

                        Console.WriteLine("La media de las posiciones del array es: " + MediaArray(a));
                    }
                    break;

                case 11:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];

                        RellenaEnOrden(a);
                        EscribeArray(a);
                    }
                    break;

                case 12:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];

                        RellenaEnOrdenDesc(a);
                        EscribeArray(a);
                    }
                    break;

                case 13:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];

                        RellenaAleatorio(a);
                        EscribeArray(a);
                    }
                    break;

                case 14:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        if (EstaOrdenado(a))
                        {
                            Console.WriteLine("El array está ordenado de forma ascendente");
                        }
                        else
                        {
                            Console.WriteLine("El array no está ordenado.");
                        }
                    }
                    break;

                case 15:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("El array tiene " + NumeroImpares(a) + " números impares.");
                    }
                    break;

                case 16:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("El valor mínimo del array es: " + MinArray(a));
                    }
                    break;

                case 17:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("El valor máximo del array es: " + MaxArray(a));
                    }
                    break;

                case 18:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("El número de aprobados es: " + NumeroAprobados(a));
                    }
                    break;

                case 19:
                    {
                        int tam, limite;

                        Console.WriteLine(("Introduce un valor límite: "));
                        limite = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("Hay " + PorEncimaDe(a, limite) + " elementos iguales o por encima de " + limite);
                    }
                    break;

                case 20:
                    {
                        int tam;
                        Console.WriteLine("Introduce un tamaño para el array:");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);

                        Console.WriteLine("Este array tiene " + CuantosCeros(a) + " ceros.");
                    }
                    break;

                case 21:
                    {
                        int tam1, tam2;

                        Console.WriteLine("Introduce un tamaño para el array1:");
                        tam1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el array2:");
                        tam2 = int.Parse(Console.ReadLine());


                        int[] a = new int[tam1];
                        LeeArray(a);
                        
                        int[] b = new int[tam2];
                        LeeArray(b);

                        CopiaArray(a, b);
                        EscribeArray(b);
                    }
                    break;

                case 22:
                    {
                        int tam1, tam2;

                        Console.WriteLine("Introduce un tamaño para el array1:");
                        tam1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el array2:");
                        tam2 = int.Parse(Console.ReadLine());


                        int[] a = new int[tam1];
                        LeeArray(a);

                        int[] b = new int[tam2];
                        LeeArray(b);

                        CopiaArrayInvertido(a, b);
                        EscribeArray(b);
                    }
                    break;

                case 23:
                    {
                        int tam1, tam2, tam3;

                        Console.WriteLine("Introduce un tamaño para el array1:");
                        tam1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el array2:");
                        tam2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el arra3:");
                        tam3 = int.Parse(Console.ReadLine());

                        int[] a = new int[tam1];
                        LeeArray(a);

                        int[] b = new int[tam2];
                        LeeArray(b);

                        int[] c = new int[tam3];
                        LeeArray(c);

                        SumaArrays(a, b, c);
                    }
                    break;

                case 24:
                    {
                        int tam1, tam2, tam3;

                        Console.WriteLine("Introduce un tamaño para el array1:");
                        tam1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el array2:");
                        tam2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el array3:");
                        tam3 = int.Parse(Console.ReadLine());

                        int[] a = new int[tam1];
                        LeeArray(a);

                        int[] b = new int[tam2];
                        LeeArray(b);

                        int[] c = new int[tam3];
                        LeeArray(c);

                        Console.WriteLine("La resta es igual a: ");
                        RestaArrays(a, b, c);
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("La multiplicación es igual a: ");
                        MultiplicaArrays(a, b, c);
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("La división es igual a: ");
                        DivideArrays(a, b, c);
                    }
                    break;

                case 25:
                    {
                        int tam;

                        Console.WriteLine("Introduce un tamaño para el array: ");
                        tam = int.Parse(Console.ReadLine());

                        int[] a = new int[tam];
                        LeeArray(a);
                        InvierteArray(a);
                        Console.WriteLine("El array invertido queda asi: ");
                        EscribeArray(a);
                    }
                    break;

                case 26:
                    {
                        int tam1, tam2;

                        Console.WriteLine("Introduce un tamaño para el array1:");
                        tam1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce un tamaño para el array2:");
                        tam2 = int.Parse(Console.ReadLine());


                        int[] a = new int[tam1];
                        LeeArray(a);

                        int[] b = new int[tam2];
                        LeeArray(b);

                        if (ComparaArrays(a,b))
                        {
                            Console.WriteLine("Los arrays son iguales.");
                        }
                        else
                        {
                            Console.WriteLine("Los arrays son diferentes.");
                        }
                    }
                    break;

                case 27:
                    {  
                        double[] a = { 1.5, 2.5, 9, 5, 7 };
                        bool[] b = new bool[5];

                        PonNotasArray(a, b);
                        EscribeArrayBool(b);
                    }
                    break;

                case 28:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] b = { 6, 7, 8, 9, 10 };
                        int[] c = new int[10];

                        ConcatenaArrays55(a, b, c);
                        EscribeArray(c);
                    }
                    break;

                case 29:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6 };
                        int[] b = { 6, 7, 8, 9, 10 };
                        int[] c = new int[10];

                        ConcatenaArrays(a, b, c);
                        EscribeArray(c);
                    }
                    break;

                case 30:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 25, 50 };
                        int num = 5;

                        if(Contiene(a, num))
                        {
                            Console.WriteLine("El array contiene el número " + num);
                        }
                        else
                        {
                            Console.WriteLine("El array no contiene el número "+ num);
                        }
                    }
                    break;

                case 31:
                    {
                        int[] a = { 1, 2, 3 };
                        int[] b = { 4, 5, 6, 7, 2 };
                        int[] c;

                        c = ConcatenaArraysPro(a, b);

                        EscribeArray(c);
                    }
                    break;

                case 32:
                    {
                        int[] a = { 1, 2, 3, 8, 25 };
                        int[] b;
                        b = CopiaArrayPro(a);

                        EscribeArray(b);
                    }
                    break;

                case 33:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int pos = 2;
                        int num = 26;

                        InsertaEnArray(ref a, ref num, ref pos);

                        EscribeArray(a);
                    }
                    break;

                case 34:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int pos = 2;

                        BorraDeArray(ref a, ref pos);

                        EscribeArray(a);
                    }
                    break;

                case 35:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int valor = 1;

                        Elimina1ElementoArray(ref a, ref valor);

                        EscribeArray(a);
                    }
                    break;

                case 36:
                    {
                        int[] a = { 1, 2, 3, 1, 5 };
                        int valor = 1;

                        EliminaElementosArray(ref a, ref valor);

                        EscribeArray(a);
                    }
                    break;

                case 37:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] b = { 6, 7, 8 };
                        int valor = 2;

                        InsertaArrayEnArray(ref a, ref b, ref valor);

                        EscribeArray(a);
                    }
                    break;

                case 38:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6 };

                        int pos1 = 1;
                        int pos2 = 5;

                        EscribeArray(SubArray(a, pos1, pos2));
                    }
                    break;

                case 39:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
                        int pos1 = 0;
                        int pos2 = 1;

                        RecortaArray(ref a, ref pos1, ref pos2);

                        EscribeArray(a);
                    }
                    break;

                case 40:
                    {
                        int[] a = { 0, 5, 0, 1, 1 };
                        
                        EscribeArray(OrdenaSeleccion(a));
                    }
                    break;

                default: Console.WriteLine("Ejercicio no válido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
