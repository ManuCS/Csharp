using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    class Fraccion
    {
        //Atributos

        private int numerador;
        private int denominador;


        //Constructores

        /// <summary>
        /// Crea una fraccion
        /// </summary>
        /// <param name="num">Numerador</param>
        /// <param name="den">Denominador</param>
        public Fraccion(int num, int den)
        {
            if(den != 0)
            {
                this.numerador = num;
                this.denominador = den;
            }
            else
            {
                throw new Exception("El denominador no puede ser 0.");
            }
        }

        /// <summary>
        /// Pone un numero entero como fracción con denominador = 1
        /// </summary>
        /// <param name="num">Numerador</param>
        public Fraccion(int num)
        {
            this.numerador = num;
            this.denominador = 1;
        }

        /// <summary>
        /// Representa un numero con decimales en fracción
        /// </summary>
        /// <param name="num">numerador</param>
        public Fraccion(double num)
        {
            int den = 1;

            while(num % 1 != 0)
            {
                num = num * 10;
                den = den * 10;
            }

            this.numerador = Convert.ToInt32(num);
            this.denominador = den;
        }



        //Metodos Privados

        /// <summary>
        /// Calcula el máximo común divisor de dos números.
        /// </summary>
        /// <param name="n1">Numero 1</param>
        /// <param name="n2">Numero 2</param>
        /// <returns>Máximo común divisor</returns>
        private static int MCD(int n1, int n2)
        {
            int menor, mcd;

            if(n1 >= n2 && n2 > 0 || n2 > n1 && n1 < 0)
            {
                menor = n2;
            }
            else
            {
                menor = n1;
            }

            int i = menor;

            while ((n1 % i != 0) || (n2 % i != 0))
            {
                i--;
            }

            mcd = i;
            return mcd;

        }

        /// <summary>
        /// Calcula el mínimo común múltiplo de dos números.
        /// </summary>
        /// <param name="n1">numero1</param>
        /// <param name="n2">numero2</param>
        /// <returns>Mínimo Común Múltiplo</returns>
        private static int MCM(int n1, int n2)
        {
            int mayor, i, mcm;

            if (n1 > n2)
            {
                mayor = n1;
            }
            else
            {
                mayor = n2;
            }

            i = mayor;

            while ((i % n1 != 0) || (i % n2 != 0))
            {
                i++;
            }

            mcm = i;

            return mcm;
        }


        //Métodos

        /// <summary>
        /// Simplifica una fracción
        /// </summary>
        public void Simplificar()
        {
            int mcd = MCD(this.numerador, this.denominador);

            this.numerador = this.numerador / mcd;
            this.denominador = this.denominador / mcd;
        }


        /// <summary>
        /// Representa la fracción de la forma "numerador / denominador"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string fraccion = "";

            fraccion = this.numerador + "/" + this.denominador;

            return fraccion;
        }

        
        //Propiedades

        /// <summary>
        /// Devuelve el valor de la fracción en decimales
        /// </summary>
        public double ValorDouble
        {
            get
            {
                double resultado;
                resultado = this.numerador / this.denominador;

                return resultado;
            }
        }

        /// <summary>
        /// Devuelve el valor del numerador o lo modifica
        /// </summary>
        public int Numerador
        {
            get
            {
                return this.numerador;
            }

            set
            {
                this.numerador = value;
            }
        }

        /// <summary>
        /// Devuelve el valor del denominador o lo modifica
        /// </summary>
        public int Denominador
        {
            get
            {
                return this.denominador;
            }

            set
            {
                if(value == 0)
                {
                    throw new Exception("El denominador no puede ser igual a 0");
                }
                else
                {
                    this.denominador = value;
                }
            }
        }



        //Operadores


        /// <summary>
        /// Realiza la suma de dos fracciones
        /// </summary>
        /// <param name="fr1">Fracción 1</param>
        /// <param name="fr2">Fracción 2</param>
        /// <returns>Suma de las fracciones</returns>
        public static Fraccion operator +(Fraccion fr1, Fraccion fr2)
        {
            Fraccion fr3;

            int num1, num2, mcm;

            mcm = MCM(fr1.denominador, fr2.denominador);

            num1 = fr1.numerador * (mcm / fr1.denominador);
            num2 = fr2.numerador * (mcm / fr2.denominador);

            fr3 = new Fraccion(num1 + num2, mcm);
            fr3.Simplificar();

            return fr3;
        }
        
        /// <summary>
        /// Realiza la resta de dos fracciones
        /// </summary>
        /// <param name="fr1">Fraccion1</param>
        /// <param name="fr2">Fraccion2</param>
        /// <returns>Resta</returns>
        public static Fraccion operator -(Fraccion fr1, Fraccion fr2)
        {
            Fraccion fr3;

            int num1, num2, mcm;

            mcm = MCM(fr1.denominador, fr2.denominador);

            num1 = fr1.numerador * (mcm / fr1.denominador);
            num2 = fr2.numerador * (mcm / fr2.denominador);

            fr3 = new Fraccion((num1 - num2), mcm);
            fr3.Simplificar();

            return fr3;
        }

        /// <summary>
        /// Realiza la multiplicación de dos fracciones
        /// </summary>
        /// <param name="fr1"></param>
        /// <param name="fr2"></param>
        /// <returns></returns>
        public static Fraccion operator *(Fraccion fr1, Fraccion fr2)
        {
            Fraccion fr3;
            int num, den;

            num = fr1.numerador * fr2.numerador;
            den = fr1.denominador * fr2.denominador;

            fr3 = new Fraccion(num, den);
            fr3.Simplificar();

            return fr3;
        }

        /// <summary>
        /// Realiza la división de dos fracciones
        /// </summary>
        /// <param name="fr1"></param>
        /// <param name="fr2"></param>
        /// <returns></returns>
        public static Fraccion operator /(Fraccion fr1, Fraccion fr2)
        {
            Fraccion fr3;
            int num, den;

            num = fr1.numerador * fr2.denominador;
            den = fr1.denominador * fr2.numerador;

            fr3 = new Fraccion(num, den);
            fr3.Simplificar();

            return fr3;
        }


        //Operadores lógicos

        /// <summary>
        /// Dice si una fracción es igual a otra.
        /// </summary>
        /// <param name="fr1">fraccion1</param>
        /// <param name="fr2">fraccion2</param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator ==(Fraccion fr1, Fraccion fr2)
        {
            fr1.Simplificar();
            fr2.Simplificar();

            if(fr1.numerador == fr2.numerador && fr1.denominador == fr2.denominador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Dice si la primera fracción es menor que la segunda
        /// </summary>
        /// <param name="fr1">fraccion1</param>
        /// <param name="fr2">fraccion2</param>
        /// <returns>si es menor que la segunda</returns>
        public static bool operator <(Fraccion fr1, Fraccion fr2)
        {
            double v1, v2;

            v1 = fr1.ValorDouble;
            v2 = fr2.ValorDouble;

            if(v1 < v2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Dice si una fracción es diferente a otra
        /// </summary>
        /// <param name="fr1">fraccion1</param>
        /// <param name="fr2">fraccion2</param>
        /// <returns>Si son diferentes o no</returns>
        public static bool operator !=(Fraccion fr1, Fraccion fr2)
        {
            if(fr1 == fr2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Dice si una fracción es mayor que otra
        /// </summary>
        /// <param name="fr1">fraccion1</param>
        /// <param name="fr2">fraccion2</param>
        /// <returns>si la primera fraccion es mayor que la otra o no</returns>
        public static bool operator >(Fraccion fr1, Fraccion fr2)
        {
            if(fr1 < fr2 || fr1 == fr2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Dice si una fracción es menor o igual que otra
        /// </summary>
        /// <param name="fr1">fraccion1</param>
        /// <param name="fr2">fraccion2</param>
        /// <returns>si es menor o igual que fraccion2</returns>
        public static bool operator <=(Fraccion fr1, Fraccion fr2)
        {
            if(fr1 < fr2 || fr1 == fr2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Dice si una fracción es mayor o igual que otra
        /// </summary>
        /// <param name="fr1">fraccion1</param>
        /// <param name="fr2">fraccion2</param>
        /// <returns>si una es mayor que la segunda</returns>
        public static bool operator >=(Fraccion fr1, Fraccion fr2)
        {
            if(fr1 > fr2 || fr1 == fr2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //Operador implícito

        /// <summary>
        /// Transforma un entero a una fracción
        /// </summary>
        /// <param name="entero">Número entero</param>
        public static implicit operator Fraccion(int entero)
        {
            Fraccion f = new Fraccion(entero);

            return f;
        }
    }
}
