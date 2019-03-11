using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineroYMoneda
{
    class Dinero
    {

        //Atributos

        private decimal cantidad;               //Guarda la cantidad exacta del dinero.
        private TipoMoneda moneda;              //Moneda en la que esté representada la cantidad.


        //Atributo estático

        static public List<Moneda> monedas;     //Lista de monedas


        //Constructores

        /// <summary>
        /// Pone valores a cantidad y moneda.
        /// </summary>
        /// <param name="cant">Cantidad de dinero</param>
        /// <param name="mon">Tipo de moneda</param>
        public Dinero(decimal cant, TipoMoneda mon)
        {
            this.cantidad = cant;
            this.moneda = mon;
        }

        /// <summary>
        /// Pone valores a cantidad (entero) y moneda
        /// </summary>
        /// <param name="cant"></param>
        /// <param name="mon"></param>
        public Dinero(int cant, TipoMoneda mon)
        {
            this.cantidad = Convert.ToInt32(cant);
            this.moneda = mon;
        }

        /// <summary>
        /// Pone valores a cantidad(double) y moneda
        /// </summary>
        /// <param name="cant"></param>
        /// <param name="mon"></param>
        public Dinero(double cant, TipoMoneda mon)
        {
            this.cantidad = Convert.ToDecimal(cant);
            this.moneda = mon;
        }

        //Constructor estático

        /// <summary>
        /// Rellena la lista de monedas con sus datos
        /// </summary>
        static Dinero()
        {
            Moneda moneda;
            int i;

            //Enum = Euro, Dolar, Peseta, Libra
            List<TipoMoneda> tipo = new List<TipoMoneda> { TipoMoneda.Euro, TipoMoneda.Dolar, TipoMoneda.Peseta, TipoMoneda.Libra };
            List<int> ndecimal = new List<int> { 2, 2, 2, 2 };
            List<string> simbol = new List<string> { "EUR", "$", "Pt", "£" };
            List<decimal> camb = new List<decimal> { 1, 1.23m, 166.386m, 1.14m };

            monedas = new List<Moneda>();

            for (i = 0; i < 4; i++)
            {
                moneda = new Moneda(tipo[i], ndecimal[i], simbol[i], camb[i]);
                monedas.Add(moneda);
            }
        }



        //Propiedades 

        public decimal Cantidad
        {
            get
            {
                return this.cantidad;
            }

            set
            {
                this.cantidad = value;
            }
        }


        public TipoMoneda Moneda
        {
            get
            {
                return this.moneda;
            }

            set
            {
                this.moneda = value;
            }
        }


        public double ADouble
        {
            get
            {
                return Convert.ToDouble(Cantidad);
            }
        }

        public int AEntero
        {
            get
            {
                return Convert.ToInt32(Cantidad);
            }
        }


        //Métodos

        /// <summary>
        /// Devuelve la posición de una moneda en la lista de monedas
        /// </summary>
        /// <param name="tmoneda">Tipo de moneda</param>
        /// <returns>Posición de una moneda en la lista</returns>
        public int Pos(TipoMoneda tmoneda)
        {
            int pos = 1;
            int i;

            for(i = 0; i < monedas.Count; i++)
            {
                if(tmoneda == monedas[i].TMmoneda)
                {
                    pos = i;
                }
            }

            return pos;
        }

        /// <summary>
        /// Muestra el valor contenido en cantidad y el simbolo de moneda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cadena = "";

            cadena = Math.Round(Cantidad, monedas[Pos(Moneda)].Decimales) + " " + monedas[Pos(Moneda)].Simbolo;

            return cadena;
        }

        /// <summary>
        /// Devuelve el valor de nuestro dinero en la moneda que pasamos.
        /// </summary>
        /// <param name="tmoneda">Moneda a la que cambiar</param>
        /// <returns>Cantidad de nuestro dinero en dicha moneda</returns>
        public decimal ValorEn(TipoMoneda tmoneda)
        {
            decimal resultado;
            decimal ValorNueva = 1;        //Valor de la moneda nueva
            decimal ValorNuestra = 1;            //Valor de la moneda que tenemos
            int i;
            
            for(i = 0; i < monedas.Count; i++)
            {
                if(this.Moneda == monedas[i].TMmoneda)
                {
                    ValorNuestra = monedas[i].Cambio;
                }
            }

            for(i = 0; i < monedas.Count; i++)
            {
                if(tmoneda == monedas[i].TMmoneda)
                {
                    ValorNueva = monedas[i].Cambio;
                }
            }

            resultado = (this.cantidad / ValorNuestra) * ValorNueva;

            return resultado;
        }

        /// <summary>
        /// Convierte nuestro dinero a otra moneda
        /// </summary>
        /// <param name="tmoneda">moneda en la que convertiremos nuestra moneda</param>
        /// <returns>Conversión de nuestro dinero a la nueva moneda</returns>
        public Dinero ConvierteEn(TipoMoneda tmoneda)
        {
            Dinero din = new Dinero(ValorEn(tmoneda), tmoneda);

            return din;
        }

        /// <summary>
        /// Escribe la cantidad representada en la moneda que pasemos
        /// </summary>
        /// <param name="tmoneda">moneda a ser representada la cantidad</param>
        /// <returns></returns>
        public string ToString(TipoMoneda tmoneda)
        {
            string cadena = "";

            cadena = Math.Round(ValorEn(tmoneda), monedas[Pos(tmoneda)].Decimales) + " " + monedas[Pos(tmoneda)].Simbolo;

            return cadena;
        }

        
        //Operadores

        /// <summary>
        /// Suma dos cantidades de dinero, independientemente de la moneda que sean
        /// </summary>
        /// <param name="din1">Dinero1</param>
        /// <param name="din2">Dinero2</param>
        /// <returns>Suma de sus cantidades</returns>
        public static Dinero operator +(Dinero din1, Dinero din2)
        {
            Dinero resultado;
            decimal cant;

            if(din1.Moneda == din2.Moneda)
            {
                cant = din1.Cantidad + din2.Cantidad;

                resultado = new Dinero(cant, din1.Moneda);
            }
            else
            {
                cant = din1.Cantidad + din2.ValorEn(din1.Moneda);

                resultado = new Dinero(cant, din1.Moneda);
            }

            return resultado;
        }

        
        /// <summary>
        /// Resta dos cantidades de dinero.
        /// </summary>
        /// <param name="din1">Dinero1</param>
        /// <param name="din2">Dinero2</param>
        /// <returns></returns>
        public static Dinero operator -(Dinero din1, Dinero din2)
        {
            decimal cant;
            Dinero resultado;

            if(din1.Moneda == din2.Moneda)
            {
                cant = din1.Cantidad + din2.Cantidad;

                resultado = new Dinero(cant, din1.Moneda);
            }
            else
            {
                cant = din1.Cantidad + din2.ValorEn(din1.Moneda);

                resultado = new Dinero(cant, din1.Moneda);
            }

            return resultado;
        }

        /// <summary>
        /// Multiplica una cantidad de dinero por el valor que le pasemos
        /// </summary>
        /// <param name="din1">Dinero</param>
        /// <param name="valor">Valor por el que será multiplicado</param>
        /// <returns></returns>
        public static Dinero operator *(Dinero din1, decimal valor)
        {
            Dinero resultado;
            decimal cant;

            cant = din1.Cantidad * valor;

            resultado = new Dinero(cant, din1.Moneda);

            return resultado;
        }

        /// <summary>
        /// Divide una cantidad de dinero por el valor que le pasemos
        /// </summary>
        /// <param name="din1">Dinero</param>
        /// <param name="valor">Valor por el que será dividido</param>
        /// <returns></returns>
        public static Dinero operator /(Dinero din1, decimal valor)
        {
            Dinero resultado;
            decimal cant;

            cant = din1.Cantidad / valor;

            resultado = new Dinero(cant, din1.Moneda);

            return resultado;
        }

        /// <summary>
        /// Devuelve si dos cantidades de dinero son iguales o no
        /// </summary>
        /// <param name="din1">Dinero1</param>
        /// <param name="din2">Dinero2</param>
        /// <returns></returns>
        public static bool operator ==(Dinero din1, Dinero din2)
        {
            if(din1.Moneda == din2.Moneda)
            {
                if(din1.Cantidad == din2.Cantidad)
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
                din2.ConvierteEn(din1.Moneda);

                Math.Round(din1.Cantidad, 2);
                Math.Round(din2.Cantidad, 2);

                if(din1.Cantidad == din2.Cantidad)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Devuelve si dos cantidades de dinero son diferentes
        /// </summary>
        /// <param name="din1"></param>
        /// <param name="din2"></param>
        /// <returns></returns>
        public static bool operator !=(Dinero din1, Dinero din2)
        {
            if(din1 == din2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Devuelve si la primera cantidad de dinero es MENOR que la segunda
        /// </summary>
        /// <param name="din1"></param>
        /// <param name="din2"></param>
        /// <returns></returns>
        public static bool operator <(Dinero din1, Dinero din2)
        {
            if(din1.Moneda == din2.Moneda)
            {
                if(din1.Cantidad < din2.Cantidad)
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
                din2.ConvierteEn(din1.Moneda);

                Math.Round(din1.Cantidad, 2);
                Math.Round(din2.Cantidad, 2);

                if(din1.Cantidad < din2.Cantidad)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Devuelve si la primera cantidad de dinero es MAYOR que la segunda
        /// </summary>
        /// <param name="din1"></param>
        /// <param name="din2"></param>
        /// <returns></returns>
        public static bool operator >(Dinero din1, Dinero din2)
        {
            if(din1 < din2 || din1 == din2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Devuelve si la primera cantidad de dinero es MENOR o IGUAL que la segunda
        /// </summary>
        /// <param name="din1"></param>
        /// <param name="din2"></param>
        /// <returns></returns>
        public static bool operator <=(Dinero din1, Dinero din2)
        {
            if(din1 < din2 || din1 == din2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Devuelve si la primera cantidad de dinero es MAYOR o IGUAL que la segunda
        /// </summary>
        /// <param name="din1"></param>
        /// <param name="din2"></param>
        /// <returns></returns>
        public static bool operator >=(Dinero din1, Dinero din2)
        {
            if(din1 > din2  || din1 == din2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
