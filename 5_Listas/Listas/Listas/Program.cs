using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        //------Primera Relación------

        /// <summary>
        /// Función que lee los valores introducidos por teclado y los mete en una lista. Para finalizar introducir -1
        /// </summary>
        /// <param name="l">Lista</param>
        static void LeeLista(List<int> l)//Ejercicio 1
        {
            int valor;

            Console.WriteLine("Introduzca valores en la lista, escriba -1 para finalizar:");
            valor = int.Parse(Console.ReadLine());

            while (valor != -1)
            {
                l.Add(valor);
                valor = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Función que lee un número determinado de enteros y los mete en una lista.
        /// </summary>
        /// <param name="l">Lista</param>
        /// <param name="n">Número de enteros</param>
        static void LeeListaN(List<int> l, int n)//Ejercicio 2
        {
            int valor, i;

            Console.WriteLine("Introduzca " + n + " valores en la lista:");

            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Introduce el valor " + i + ":");
                valor = int.Parse(Console.ReadLine());
                l.Add(valor);
            }

        }

        /// <summary>
        /// Función que escribe una lista por pantalla
        /// </summary>
        /// <param name="l">Lista</param>
        static void EscribeLista(List<int> l)//Ejercicio 3
        {
            int i;
            Console.Write("< ");
            for (i = 0; i < l.Count - 1; i++)
            {
                Console.Write(l[i] + ", ");
            }
            Console.WriteLine(l[l.Count - 1] + " >");
        }

        static void EscribeListaChar(List<char> l)
        {
            int i;
            Console.Write("< ");
            for (i = 0; i < l.Count - 1; i++)
            {
                Console.Write(l[i] + ", ");
            }
            Console.WriteLine(l[l.Count - 1] + " >");
        }

        static void EscribeListaString(List<string> l)
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
        /// Función que elimina los números negativos de una lista
        /// </summary>
        /// <param name="l">lista</param>
        static void EliminaNegativos(List<int> l)//Ejercicio 6
        {
            int i;

            for(i = 0; i < l.Count; i++)
            {
                if(l[i] < 0)
                {
                    l.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Función que clasifica los números negativos y positivos de una lista en dos listas
        /// </summary>
        /// <param name="l">Lista que contiene los números</param>
        /// <param name="l1">Lista positivos</param>
        /// <param name="l2">Lista negativos</param>
        static void ClasificaNumeros(List<int> l, List<int> l1, List<int> l2)//Ejercicio 7
        {
            int i;

            for(i = 0; i < l.Count; i++)
            {
                if(l[i] >= 0)
                {
                    l1.Add(l[i]);
                }
                else
                {
                    l2.Add(l[i]);
                }
            }

            l1.Sort();
            l2.Sort();
        }

        /// <summary>
        /// Función que elimina los números repetidos de una lista
        /// </summary>
        /// <param name="l">Lista</param>
        static void EliminaRepetidos(List<int> l)//Ejercicio 8
        {
            int i;

            List<int> l1 = new List<int>();

            for(i = 0; i < l.Count; i++)
            {
                l1.Add(l[i]);
            }

            l.Clear();

            for(i = 0; i < l1.Count; i++)
            {
                if (l.Contains(l1[i]))
                {
                    i++;
                }
                else
                {
                    l.Add(l1[i]);
                }
            }
        }

        /// <summary>
        /// Función que elimina los espacios a principio y final de una lista de caracteres
        /// </summary>
        /// <param name="l">Lista de caracteres</param>
        static void TrimLista(List<char> l)//Ejercicio 9
        {
            while(l[0] == ' ')
            {
                l.RemoveAt(0);
            }


            while(l[l.Count - 1] == ' ')
            {
                l.RemoveAt(l.Count - 1);
            }

        }

        /// <summary>
        /// Función que ordena una lista
        /// </summary>
        /// <param name="l">Lista</param>
        static void OrdenaListaSeleccion(List<int> l)//Ejercicio 10
        {
            int i;

            List<int> l1 = new List<int>();

            l1.AddRange(l);

            l.Clear();

            while(l1.Count > 0)
            {
                l.Add(l1.Min());
                l1.Remove(l1.Min());
            }

        }


        //------Segunda Relación------

        /// <summary>
        /// Función que ordena alfabeticamente una lista de cadenas
        /// </summary>
        /// <param name="l">Lista de cadenas</param>
        static void OrdenaListaPalabras(List<string> l)//Ejercicio 11
        {
            l.Sort();
        }
        
        static void OrdenaListaPalabrasV2(List<string> l)//Ejercicio 11
        {
            List<string> l1 = new List<string>();

            l1.AddRange(l);

            l.Clear();

            while(l1.Count > 0)
            {
                l.Add(l1.Min());
                l1.Remove(l1.Min());
            }
        }
        
        /// <summary>
        /// Función que ordena una lista de cadenas por su tamaño de menor a mayor.
        /// </summary>
        /// <param name="l">Lista de cadenas</param>
        static void OrdenaListaPalabras2(List<string> l)//Ejercicio 12
        {
            int i, min, pos;

            List<string> l1 = new List<string>();

            l1.AddRange(l);
            l.Clear();

            while(l1.Count > 0)
            {
                min = l1[0].Length;
                pos = 0;

                for(i = 0; i < l1.Count; i++)
                {
                    if(l1[i].Length < min)
                    {
                        min = l1[i].Length;
                        pos = i;
                    }
                }

                l.Add(l1[pos]);
                l1.RemoveAt(pos);
            }
        }


        static void EscribeArray(int[] a)
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
        /// Función que insertará en el primer array otro array a partir de la posición indicada.
        /// </summary>
        /// <param name="array1">Primer array</param>
        /// <param name="array2">Array que se insertará</param>
        /// <param name="pos">Posición de array1 en la que se insertará array2</param>
        /// <returns>Un array con array2 insertado en array1</returns>
        static int[] InsertaArrayEnArrayPro(int[] array1, int[] array2, int pos)//Ejercicio 14 
        {
            int i;

            List<int> l = new List<int>();

            for(i = 0; i < array1.Length; i++)
            {
                l.Add(array1[i]);
            }

            for(i = 0; i < array2.Length; i++)
            {
                l.Insert(pos, array2[i]);
                pos++;
            }

            int[] resultado = new int[l.Count];

            resultado = l.ToArray();


            return resultado;
        }

        /// <summary>
        /// Función que devuelve los números de la bonoloto
        /// </summary>
        /// <returns>6 números de la bonoloto</returns>
        static List<int> SorteoBonoloto()//Ejercicio 15
        {
            int i, cont, numbonoloto;

            numbonoloto = 1;
            cont = 0;

            List<int> numeros = new List<int>();
            List<int> elegidos = new List<int>();

            for(i = 0; i < 49; i++)
            {
                numeros.Add(numbonoloto);
                numbonoloto++;
            }

            Random rnd = new Random();

            int pos;

            while(cont != 6)
            {
                pos = rnd.Next(0, numeros.Count - 1);
                elegidos.Add(numeros[pos]);
                numeros.RemoveAt(pos);
                cont++;
            }

            return elegidos;
        }

        /// <summary>
        /// Función que elimina los elementos repetidos de un array
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Otro array</returns>
        static int[] EliminaRepetidosArray(int[] array)//Ejercicio 16
        {
            int i;

            List<int> l = new List<int>();

            for (i = 0; i < array.Length; i++)
            {
                l.Add(array[i]);
            }

            EliminaRepetidos(l);

            int[] resultado = new int[l.Count];

            resultado = l.ToArray();

            return resultado;
        }

        /// <summary>
        /// Función que une los conjuntos de dos listas
        /// </summary>
        /// <param name="l1">Lista1</param>
        /// <param name="l2">Lista2</param>
        /// <returns>Lista con el conjunto de la primera unido con el de la segunda</returns>
        static List<int> UnionListas(List<int> l1, List<int> l2)//ejercicio 17
        {
            List<int> res = new List<int>();

            res.AddRange(l1);
            res.AddRange(l2);

            EliminaRepetidos(res);

            return res;
        }

        /// <summary>
        /// Función que realiza la intersección de dos listas
        /// </summary>
        /// <param name="l1">Lista1</param>
        /// <param name="l2">Lista2</param>
        /// <returns>Intersección de las dos listas</returns>
        static List<int> InterseccionListas(List<int> l1,List<int> l2)//ejercicio 18
        {
            int i;

            List<int> res = new List<int>();

            List<int> l2copia = new List<int>();
            l2copia.AddRange(l2);

            for(i = 0; i < l1.Count; i++)
            {
                if (l2copia.Contains(l1[i]))
                {
                    res.Add(l1[i]);
                    l2copia.Remove(l1[i]);
                }
            }

            EliminaRepetidos(res);

            return res;
        }

        /// <summary>
        /// Función que desordena los elementos de una lista
        /// </summary>
        /// <param name="l">Lista</param>
        /// <returns>Lista con sus elementos desordenados</returns>
        static List<int> DesordenaLista(List<int> l)//Ejercicio 19
        {
            int pos;

            List<int> lcopia = new List<int>();
            lcopia.AddRange(l);
            List<int> resultado = new List<int>();

            Random rnd = new Random();

            while(lcopia.Count > 0)
            {
                pos = rnd.Next(0, lcopia.Count - 1);

                resultado.Add(lcopia[pos]);
                lcopia.RemoveAt(pos);
            }

            return resultado;
        }

        /// <summary>
        /// Función que devuelve la moda de una lista de enteros
        /// </summary>
        /// <param name="l">Lista</param>
        /// <returns>Moda de la lista</returns>
        static int ModaLista(List<int> l)//Ejercicio 20
        {
            int i, j, moda, cont, res;

            moda = 0;
            cont = 0;
            res = 0;

            for(i = 0; i < l.Count; i++)
            {
                for(j = 0; j < l.Count; j++)
                {
                    if(l[i] == l[j])
                    {
                        cont++;
                    }

                    if(moda < cont)
                    {
                        moda = cont;
                        res = l[i];
                    }
                }
                cont = 0;
            }

            return res;
        }

        /// <summary>
        /// Función que devuelve la nota de un saltador de trampolín
        /// </summary>
        /// <param name="l">Lista con notas</param>
        /// <returns>Nota final</returns>
        static double PuntuacionesTrampolin(List<double> l)//Ejercicio 21
        {
            int cont, i;
            double suma;
            cont = 0;
            suma = 0;

            List<double> lcopia = new List<double>();
            lcopia.AddRange(l);

            while (cont < 2)
            {
                lcopia.Remove(lcopia.Min());
                cont++;
            }

            cont = 0;

            while(cont < 2)
            {
                lcopia.Remove(lcopia.Max());
                cont++;
            }
        
            for(i = 0; i < lcopia.Count; i++)
            {
                suma = suma + lcopia[i];
            }

            return suma;
        }


        //------Adicionales------

        static List<int> OrdenaRepetidos(List<int> l)//Ejercicio 22 (1 adicionales)
        {
            int i, valor, cont;
            cont = 0;

            List<int> res = new List<int>();

            List<int> lcopia = new List<int>();
            lcopia.AddRange(l);


            valor = ModaLista(lcopia);
            while (lcopia.Count > 0)
            {
                for(i = 0; i < lcopia.Count; i++)
                {
                    if(lcopia[i] == valor)
                    {
                        cont++;
                    }
                }

                i = 0;
                while(i < cont)
                {
                    res.Add(valor);
                    lcopia.Remove(valor);
                }

                valor = ModaLista(lcopia);
            }

            return res;
        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU DE LISTAS");
            Console.WriteLine("==============");

            Console.WriteLine();
            Console.WriteLine("Elige una opción: ");
            Console.WriteLine("--------Primera Relación------");
            Console.WriteLine(" 1- LeeLista");
            Console.WriteLine(" 2- LeeListaN");
            Console.WriteLine(" 3- EscribeLista");
            Console.WriteLine(" 6- EliminaNegativos");
            Console.WriteLine(" 7- ClasificaNumeros");
            Console.WriteLine(" 8- EliminaRepetidos");
            Console.WriteLine(" 9- TrimLista");
            Console.WriteLine(" 10- OrdenaListaSeleccion");
            Console.WriteLine();
            Console.WriteLine("------Segunda Relación------");
            Console.WriteLine(" 11- OrdenaListaPalabras");
            Console.WriteLine(" 12- OrdenaListaPalabras2");
            Console.WriteLine(" 14- InsertaArrayEnArrayPro");
            Console.WriteLine(" 15- SorteoBonoloto");
            Console.WriteLine(" 16- EliminaRepetidosArray");
            Console.WriteLine(" 17- UnionListas");
            Console.WriteLine(" 18- InterseccionListas");
            Console.WriteLine(" 19- DesordenaLista");
            Console.WriteLine(" 20- ModaLista");
            Console.WriteLine(" 21- PuntuacionesTrampolin");
            Console.WriteLine();
            Console.WriteLine("-------Ejercicios Adicionales------");
            Console.WriteLine(" 22- OrdenaRepetidos");

            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        List<int> l = new List<int>();
                        LeeLista(l);
                    }
                    break;

                case 2:
                    {
                        List<int> l = new List<int>();
                        LeeListaN(l, 10);
                    }
                    break;

                case 3:
                    {
                        List<int> l = new List<int>();

                        LeeLista(l);
                        EscribeLista(l);
                    }
                    break;

                case 6:
                    {
                        List<int> l = new List<int>() { 1, 2, -3, 4, -5 };

                        EliminaNegativos(l);
                        EscribeLista(l);
                    }
                    break;

                case 7:
                    {
                        List<int> l = new List<int>() { 1, -1, 4, 5, -3, 2, -2, -8, -1 };
                        List<int> l1 = new List<int>();
                        List<int> l2 = new List<int>();
                        ClasificaNumeros(l, l1, l2);
                        EscribeLista(l1);
                        EscribeLista(l2);
                    }
                    break;

                case 8:
                    {
                        List<int> l = new List<int>() { 1, 1, 1, 1, 1, 2, 2, 3, 3, 3, 4 ,4 ,4 ,4 ,5, 5 ,5, 7, 8 ,6, 4 ,4 ,5 ,6, 8};

                        EliminaRepetidos(l);
                        EscribeLista(l);
                    }
                    break;

                case 9:
                    {
                        List<char> l = new List<char>() { ' ', ' ', ' ', 'a', 'b', ' ', ' ', ' ' };
                        TrimLista(l);
                        EscribeListaChar(l);
                    }
                    break;

                case 10:
                    {
                        List<int> l = new List<int>() { 5, 4, 3, 1, 2, 8, 4, 6, 4 };
                        OrdenaListaSeleccion(l);
                        EscribeLista(l);
                    }
                    break;

                case 11:
                    {
                        List<string> l = new List<string>() { "Hola", "soy", "pepe","raton", "ay" };
                        List<string> l1 = new List<string>() { "Hola", "manuel", "y", "mcarmen", "ay" };
                        OrdenaListaPalabras(l);
                        OrdenaListaPalabrasV2(l1);
                        EscribeListaString(l);
                        EscribeListaString(l1);
                    }
                    break;

                case 12:
                    {
                        List<string> l = new List<string>() { "pepe marca", "un gol haciendo malabares", "cuando se encuentra con", "juan", "y" };

                        OrdenaListaPalabras2(l);
                        EscribeListaString(l);
                    }
                    break;

                case 14:
                    {
                        int[] a1 = { 1, 7, 8, 9, 10 };
                        int[] a2 = { 2, 3, 4, 5, 6 };
                        int pos = 1;

                        EscribeArray(InsertaArrayEnArrayPro(a1, a2, pos));
                    }
                    break;

                case 15:
                    {
                        EscribeLista(SorteoBonoloto());
                    }
                    break;

                case 16:
                    {
                        int[] array = { 1, 1, 3, 1, 5, 4, 3, 2, 3, 4, 5, 6, 6, 7, 6, 4, 8 };

                        EscribeArray(EliminaRepetidosArray(array));
                    }
                    break;

                case 17:
                    {
                        List<int> l1 = new List<int>() { 2, 5, 6, 7 };
                        List<int> l2 = new List<int>() { 1, 2, 3, 4, 5};

                        EscribeLista(UnionListas(l1, l2));
                    }
                    break;

                case 18:
                    {
                        List<int> l1 = new List<int>() { 1, 2, 2, 4, 4, 33 };
                        List<int> l2 = new List<int>() { 1, 2, 3, 4, 4, 12, 22 };

                        EscribeLista(InterseccionListas(l1, l2));
                    }
                    break;

                case 19:
                    {
                        List<int> l = new List<int>() { 2, 5, 6, 7, 8, 4, 4, 5, 6, 2, 1, 3 };

                        EscribeLista(DesordenaLista(l));
                    }
                    break;

                case 20:
                    {
                        List<int> l = new List<int>() { 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4 };

                        EscribeLista(l);

                        Console.WriteLine("La moda de esta lista es: " + ModaLista(l));
                    }
                    break;

                case 21:
                    {
                        List<double> l = new List<double>() {5, 3.5, 4.2, 8, 9.75, 1.25, 7.5 };

                        Console.WriteLine(PuntuacionesTrampolin(l));
                    }
                    break;

                case 22:
                    {
                        List<int> l = new List<int>() { 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 5, 5, 5 };
                        EscribeLista(OrdenaRepetidos(l));
                    }
                    break;

                
                default:
                    Console.WriteLine("Ejercicio no válido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
