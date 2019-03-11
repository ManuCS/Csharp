using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        //--------Primera Relación--------

        /// <summary>
        /// Función que devuelve el número de espacios que tiene una cadena
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Número de espacios</returns>
        static int NumeroEspacios(string cadena)//Ejercicio 1
        {
            int i, espacios;

            espacios = 0;

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == ' ')
                {
                    espacios++;
                }
            }

            return espacios;
        }

        /// <summary>
        /// Función que devuelve el número de vocales que tiene una cadena
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Número de vocales</returns>
        static int NumeroVocales(string cadena)//Ejercicio 2
        {
            int i, vocales;

            vocales = 0;

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
                {
                    vocales++;
                }
            }

            return vocales;
        }

        /// <summary>
        /// Función que devuelve si la cadena es palíndromo o no
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Devuelve si es palíndromo o no</returns>
        static bool EsPalindromo(string cadena)//Ejercicio 3
        {
            int i;
            int j = 0;
            int dif = 0;

            cadena = cadena.ToLower();

            for(i = cadena.Length - 1; i >= 0; i--)
            {
                if(cadena[i] == cadena[j])
                {
                    j++;
                }
                else
                {
                    dif++;
                    j++;
                }
            }

            if(dif == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Función que devuelve si un caracter aparece en la cadena o no
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <param name="a">Caracter</param>
        /// <returns>Si el caracter aparece en la cadena o no</returns>
        static bool Contiene(string cadena, char a)//Ejercicio 4
        {
            int i, cont;

            cont = 0;

            cadena = cadena.ToLower();

            a = char.ToLower(a);

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == a)
                {
                    cont++;
                }
            }

            if (cont == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Función que repite un caracter tantas veces como se le indique
        /// </summary>
        /// <param name="a">Caracter</param>
        /// <param name="num">Numero de veces que se repite</param>
        /// <returns>Una cadena con un caracter repetido tantas veces como se le indique</returns>
        static string RepiteCaracter(char a, int num)//Ejercicio 5
        {
            string cadena = "";
            int i;
            
            for(i = 0; i < num; i++)
            {
                cadena = cadena + a;
            }

            return cadena;        
        }

        /// <summary>
        /// Función que quita los espacios de una cadena
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Devuelve la cadena principal sin espacios</returns>
        static string QuitaEspacios(string cadena)//Ejercicio 6
        {
            int i;
            string cadena1="";

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] != ' ')
                {
                    cadena1 = cadena1 + cadena[i];
                }
                else
                {
                    cadena1 = cadena1 + "";
                }
            }

            return cadena1;
        }
        
        /// <summary>
        /// Función que elimina los espacios que haya a principio y final de la cadena
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>La cadena sin espacios al principio y final</returns>
        static string QuitaEspaciosTrim(string cadena)//Ejercicio 7
        {
            int i, espacios1, espacios2, espacios;

            espacios1 = 0;

            string cadena1 = "";

            i = 0;
            while(cadena[i] == ' ')
            {
                if(cadena[i] != ' ')
                {
                    break;
                }
                else
                {
                    espacios1++;
                    i++;
                }
            }


            espacios2 = 0;
            i = cadena.Length - 1;

            while(cadena[i] == ' ')
            {
                if(cadena[i] != ' ')
                {
                    break;
                }
                else
                {
                    espacios2++;
                    i--;
                }
            }

            espacios = cadena.Length - espacios2;

            for(i = 0; i < espacios; i++)
            {
                if(i < espacios1 - 1)
                {
                    cadena1 = cadena1 + "";
                }
                else
                {
                    if(i >= espacios1)
                    {
                        cadena1 = cadena1 + cadena[i];
                    }   
                }
            }

            return cadena1;
        }

        /// <summary>
        /// Función que que sustituye un caracter de la cadena por otro introducido
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <param name="a">Caracter original</param>
        /// <param name="b">Caracter que será el sustituto</param>
        /// <returns>Devuelve una cadena con los caracteres sustituidos</returns>
        static string SustituyeCaracter(string cadena, char a, char b)//Ejercicio 8
        {
            int i;

            string cadena1 = "";

            char a1 = char.ToLower(a);
            char a2 = char.ToUpper(a);

            char b1 = char.ToLower(b);
            char b2 = char.ToUpper(b);

            for (i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == a1)
                {
                    cadena1 = cadena1 + b1;
                }
                else
                {
                    if(cadena[i] == a2)
                    {
                        cadena1 = cadena1 + b2;
                    }
                    else
                    {
                        cadena1 = cadena1 + cadena[i];
                    }
                }
            }

            return cadena1;
        }

        /// <summary>
        /// Función que cuenta cuántas palabras hay en una cadena
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Número de palabras que hay en la cadena</returns>
        static int CuentaPalabras(string cadena)//Ejercicio 9
        {
            int i, cont;

            cont = 0;

            if (char.IsLetter(cadena[0]))
            {
                cont++;
            }

            for(i = 1; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ' && char.IsLetter(cadena[i + 1]))
                {
                    cont++;
                }
            }

            return cont;
        }

        /// <summary>
        /// Función que devuelve si una cadena está compuesta sólo por números o no.
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Si la cadena está compuesta sólo por números o no.</returns>
        static bool EsNumero(string cadena)//Ejercicio 10
        {
            int i, cont;

            cont = 0;

            for(i = 0; i < cadena.Length; i++)
            {
                if (char.IsNumber(cadena[i]))
                {
                    cont = cont + 0;
                }
                else
                {
                    cont++;
                }
            }

            if(cont == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //--------Segunda Relación--------

        /// <summary>
        /// Función que quita de la cadena todas las ocurrencias del caracter que le pasemos
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <param name="a">Caracter</param>
        /// <returns>Cadena sin las ocurrencias del caracter</returns>
        static string QuitaCaracter(string cadena, char a)//Ejercicio 11
        {
            int i;
            int a1;

            string cadena1 = "";

            if (char.IsLower(a))
            {
                a1 = char.ToUpper(a);
            }
            else
            {
                a1 = char.ToLower(a);
            }

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == a || cadena[i] == a1)
                {
                    cadena1 = cadena1 + "";
                }
                else
                {
                    cadena1 = cadena1 + cadena[i];
                }
            }

            return cadena1;
        }

        /// <summary>
        ///Función que devuelve una cadena con la primera letra de cada palabra en mayúscula
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Cadena con la primera letra de cada palabra en mayúscula</returns>
        static string MayusculasPrimera(string cadena)//Ejercicio 12
        {
            int i;

            string cadena1 = "";

            if (char.IsLetter(cadena[0]))
            {
                cadena1 = cadena1 + char.ToUpper(cadena[0]);
            }

            for(i = 1; i < cadena.Length; i++)
            {
                if (cadena[i - 1] == ' ' && char.IsLetter(cadena[i]))
                {
                    cadena1 = cadena1 + char.ToUpper(cadena[i]);
                }
                else
                {
                    cadena1 = cadena1 + cadena[i];
                }
            }

            return cadena1;
        }

        /// <summary>
        /// Función que quita los acentos.
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Cadena con los acentos quitados</returns>
        static string QuitaAcentos(string cadena)//Ejercicio 13
        {
            int i;
            string cadena1 = "";

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == 'á' || cadena[i] == 'à')
                {
                    cadena1 = cadena1 + "a";
                }
                else
                {
                    if (cadena[i] == 'é' || cadena[i] == 'è')
                    {
                        cadena1 = cadena1 + "e";
                    }
                    else
                    {
                        if (cadena[i] == 'í' || cadena[i] == 'ì')
                        {
                            cadena1 = cadena1 + "i";
                        }
                        else
                        {
                            if (cadena[i] == 'ó' || cadena[i] == 'ò')
                            {
                                cadena1 = cadena1 + "o";
                            }
                            else
                            {
                                if (cadena[i] == 'ú' || cadena[i] == 'ù')
                                {
                                    cadena1 = cadena1 + "u";
                                }
                                else
                                {
                                    if (cadena[i] == 'ñ')
                                    {
                                        cadena1 = cadena1 + "n";
                                    }
                                    else
                                    {
                                        cadena1 = cadena1 + cadena[i];
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return cadena1;
        }

        /// <summary>
        /// Función que invierte una cadena
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Cadena invertida</returns>
        static string InvierteCadena(string cadena)//Ejercicio 14
        {
            int i;
            string cadena1 = "";

            for(i = cadena.Length - 1; i >= 0; i--)
            {
                cadena1 = cadena1 + cadena[i];
            }

            return cadena1;
        }

        /// <summary>
        /// Función que cuenta cuántas veces se repite un caracter en una cadena
        /// </summary>
        /// <param name="cadena">cadena</param>
        /// <param name="a">caracter</param>
        /// <returns>número de veces que el caracter se repite en la cadena</returns>
        static int VecesCaracter(string cadena, char a)//Ejercicio 15
        {
            int i, cont;
            char a1;

            cont = 0;

            if (char.IsLower(a))
            {
                a1 = char.ToUpper(a);
            }
            else
            {
                a1 = char.ToLower(a);
            }

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == a || cadena[i] == a1)
                {
                    cont++;
                }
            }

            return cont;
        }

        /// <summary>
        /// Función que cuenta cuántas veces se repite una palabra en una cadena
        /// </summary>
        /// <param name="cadena">cadena</param>
        /// <param name="palabra">palabra</param>
        /// <returns>número de veces que se repite una palabra</returns>
        static int VecesPalabra(string cadena, string palabra)//Ejercicio 16
        {
            int cont;
            cont = 0;

            cadena = cadena.ToLower();
            palabra = palabra.ToLower();

            int idx = cadena.IndexOf(palabra);

            while(idx != -1)
            {
                cont++;
                idx = cadena.IndexOf(palabra, idx + 1);
            }

            return cont;
        }

        /// <summary>
        /// Función que sustituye una palabra de una cadena por otra
        /// </summary>
        /// <param name="cadena">cadena</param>
        /// <param name="palabra1">Palabra a sustituir</param>
        /// <param name="palabra2">Palabra sustituta</param>
        /// <returns>cadena con la palabra1 sustituida por la palabra2</returns>
        static string SustituyePalabra(string cadena, string palabra1, string palabra2)//Ejercicio 17
        {
            int i;
            string[] array;

            array = cadena.Split(' ');

            for(i = 0; i < array.Length; i++)
            {
                if(array[i] == palabra1)
                {
                    array[i] = palabra2;
                }
            }

            string cadena1;

            cadena1 = string.Join(" ", array);


            return cadena1;
        }

        /// <summary>
        /// Función que busca una subcadena dentro de una cadena y cambia la primera letra de la subcadena por un * cada vez que aparezca
        /// </summary>
        /// <param name="cadena">cadena</param>
        /// <param name="subcadena">subcadena</param>
        /// <returns>Cadena con * en la primera letra de la subcadena cada vez que ésta aparezca</returns>
        static string MarcaSubCadena(string cadena, string subcadena)//Ejercicio 18
        {
            int i;
            string resultado = "";

            int tam = subcadena.Length;

            for(i = 0; i < cadena.Length - (tam - 1); i++)
            {

                if (cadena.Substring(i, tam) == subcadena)
                {
                    resultado = resultado + "*";
                }
                else
                {
                    resultado = resultado + cadena[i];
                }
            }

            for(i = cadena.Length - (tam - 1); i < cadena.Length ; i++)
            {
                resultado = resultado + cadena[i];
            }

            return resultado;
        }

        /// <summary>
        /// Función que invierte las palabras de una cadena
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Cadena con sus palabras invertidas</returns>
        static string InviertePalabras(string cadena)//Ejercicio 19
        {
            int i;
            string resultado;
            string[] array;

            array = cadena.Split(' ');

            for(i = 0; i < array.Length; i++)
            {
                array[i] = InvierteCadena(array[i]);
            }

            resultado = string.Join(" ", array);

            return resultado;

        }

        /// <summary>
        /// Función que quita los espacios de principio y final, y los sobrantes que haya entre palabras.
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Cadena con los espacios ya quitados</returns>
        static string QuitaEspaciosSobrantes(string cadena)//Ejercicio 20
        {
            int i;
            string resultado = "";

            cadena = QuitaEspaciosTrim(cadena);

            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == ' ' && cadena[i - 1] != ' ')
                {
                    resultado = resultado + cadena[i];
                }
                else
                {
                    if(cadena[i] == ' ' && cadena[i - 1] == ' ')
                    {
                        resultado = resultado + "";
                    }
                    else
                    {
                        resultado = resultado + cadena[i];
                    }
                }
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU DE CADENAS");
            Console.WriteLine("===============");
            Console.WriteLine("--------Primera Relación--------");
            Console.WriteLine(" 1- NumeroEspacios");
            Console.WriteLine(" 2- NumeroVocales");
            Console.WriteLine(" 3- EsPalindromo");
            Console.WriteLine(" 4- Contiene");
            Console.WriteLine(" 5- RepiteCaracter");
            Console.WriteLine(" 6- QuitaEspacios");
            Console.WriteLine(" 7- QuitaEspaciosTrim");
            Console.WriteLine(" 8- SustituyeCaracter");
            Console.WriteLine(" 9- CuentaPalabras");
            Console.WriteLine(" 10- EsNumero");

            Console.WriteLine();
            Console.WriteLine("--------Segunda Relación--------");
            Console.WriteLine(" 11- QuitaCaracter");
            Console.WriteLine(" 12- MayuscuasPrimera");
            Console.WriteLine(" 13- QuitaAcentos");
            Console.WriteLine(" 14- InvierteCadena");
            Console.WriteLine(" 15- VecesCaracter");
            Console.WriteLine(" 16- VecesPalabra");
            Console.WriteLine(" 17- SustituyePalabra");
            Console.WriteLine(" 18- MarcaSubCadena");
            Console.WriteLine(" 19- InviertePalabras");
            Console.WriteLine(" 20- QuitaEspaciosSobrantes");

            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        string c = "Hola, me llamo Pepe ";
                        Console.WriteLine(c);
                        Console.WriteLine("El número de espacios es de: " + NumeroEspacios(c));
                    }
                    break;

                case 2:
                    {
                        string c = "Hola, me llamo Pepe ";
                        Console.WriteLine(c);
                        Console.WriteLine("El número de vocales es de: " + NumeroVocales(c));
                    }
                    break;

                case 3:
                    {
                        string pal = "Hola , aloh";
                        Console.WriteLine(pal);

                        if (EsPalindromo(pal))
                        {
                            Console.WriteLine("Es palindromo");
                        }
                        else
                        {
                            Console.WriteLine("No es palindromo");
                        }
                    }
                    break;

                case 4:
                    {
                        char a = 'h';
                        string cadena = "Hola, soy Harry Potter";

                        Console.WriteLine("El caracter es: " + a);
                        Console.WriteLine("La cadena es: " + cadena);

                        Console.WriteLine();

                        if(Contiene(cadena, a))
                        {
                            Console.WriteLine("El caracter aparece en la cadena");
                        }
                        else
                        {
                            Console.WriteLine("El caracter no aparece en la cadena");
                        }

                    }
                    break;

                case 5:
                    {
                        int num = 5;
                        char a = 'A';

                        Console.WriteLine(RepiteCaracter(a, num));
                    }
                    break;

                case 6:
                    {
                        string cadena = "Hola, yo soy Ron Weasly";

                        Console.WriteLine("La cadena original es: " + cadena);
                        Console.WriteLine();

                        Console.WriteLine(QuitaEspacios(cadena));
                    }
                    break;

                case 7:
                    {
                        string cadena = "      Hola, yo soy Hermione Granger    ";

                        Console.WriteLine("La cadena principal es: " + cadena);
                        Console.WriteLine();

                        Console.WriteLine(QuitaEspaciosTrim(cadena));
                    }
                    break;

                case 8:
                    {
                        string cadena = "Avada Kedavra";

                        char a = 'a';
                        char b = 'e';

                        Console.WriteLine(SustituyeCaracter(cadena, a, b));
                    }
                    break;

                case 9:
                    {
                        string cadena = "Expecto Patronum!-";

                        Console.WriteLine(CuentaPalabras(cadena));
                    }
                    break;

                case 10:
                    {
                        string cadena = "110316";

                        if (EsNumero(cadena))
                        {
                            Console.WriteLine("Está compuesta sólo por números");
                        }
                        else
                        {
                            Console.WriteLine("No está compuesta sólo por números");
                        }
                    }
                    break;

                case 11:
                    {
                        string cadena = "Travesura realizada";
                        char a = 't';

                        Console.WriteLine(QuitaCaracter(cadena, a));

                    }
                    break;

                case 12:
                    {
                        string cadena = " voldemort: origins of the heir";

                        Console.WriteLine(MayusculasPrimera(cadena));
                    }
                    break;

                case 13:
                    {
                        string cad = "Wíñgàrdìúm Leviosá";

                        Console.WriteLine(QuitaAcentos(cad));
                    }
                    break;

                case 14:
                    {
                        string cade = "epanS sureveS";

                        Console.WriteLine(InvierteCadena(cade));
                    }
                    break;

                case 15:
                    {
                        string cad = "Bellatrix Lestrange.";
                        char a = 'l';

                        Console.WriteLine(VecesCaracter(cad, a));
                    }
                    break;

                case 16:
                    {
                        string cadena = "Las tres Maldiciones Imperdonables son: Avada Kedavra, Crucio e Imperio. Crucio genera un dolor intenso. crucio";
                        string palabra = "crucio";

                        Console.WriteLine(VecesPalabra(cadena, palabra));
                    }
                    break;

                case 17:
                    {
                        string cad = "Malfoy mató a Albus Dumbledore";
                        string p1 = "Malfoy";
                        string p2 = "Snape";

                        Console.WriteLine(SustituyePalabra(cad, p1, p2));
                    }
                    break;

                case 18:
                    {
                        string cad = "el camaleón está en la cama";
                        string sub = "cama";
                        Console.WriteLine(MarcaSubCadena(cad, sub));
                    }
                    break;

                case 19:
                    {
                        string cadena = "Invierto letras porque quiero";

                        Console.WriteLine(InviertePalabras(cadena));
                    }
                    break;

                case 20:
                    {
                        string cadena = "  Ya   no tengo     espacios ";

                        Console.WriteLine(QuitaEspaciosSobrantes(cadena));
                    }
                    break;


                default: Console.WriteLine("Ejercicio no válido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
