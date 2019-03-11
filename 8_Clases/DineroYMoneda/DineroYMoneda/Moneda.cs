using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineroYMoneda
{

    enum TipoMoneda
    {
        Euro, Dolar, Peseta, Libra
    }

    class Moneda
    {
        //Atributos

        private TipoMoneda tmoneda;
        private int decimales;              //Cuantos decimales se usan para cada moneda
        private string simbolo;             //Simbolo que se usa para la moneda(€,$...)
        private decimal cambioEuro;         //Cantidad de una moneda que corresponde a 1€




        //Constructor

        /// <summary>
        /// Lee los valores y los pone en sus atributos
        /// </summary>
        /// <param name="tmon">Tipo de moneda</param>
        /// <param name="decim">Numero de decimales de esa moneda</param>
        /// <param name="simbol">Simbolo de la moneda</param>
        /// <param name="camb">Cambio de euro a esa moneda</param>
        public Moneda(TipoMoneda tmon, int decim, string simbol, decimal camb)
        {
            this.tmoneda = tmon;

            if (decim >= 0 && decim <= 4)
            {
                this.decimales = decim;
            }
            else
            {
                throw new Exception("No puede tener menos de 0 decimales, ni más de 3.");
            }

            if (simbol == "")
            {
                throw new Exception("Debe haber un símbolo para la moneda. No puede tener un valor vacío.");
            }
            else
            {
                this.simbolo = simbol;
            }

            if (camb < 0)
            {
                throw new Exception("El cambio de moneda no puede ser negativo.");
            }
            else
            {
                this.cambioEuro = camb;
            }

        }


        //Propiedades

        /// <summary>
        /// Devuelve el tipo de moneda
        /// </summary>
        public TipoMoneda TMmoneda
        {
            get
            {
                return this.tmoneda;
            }
        }

        /// <summary>
        /// Devuelve los decimales de la moneda
        /// </summary>
        public int Decimales
        {
            get
            {
                return this.decimales;
            }
        }

        /// <summary>
        /// Devuelve el simbolo de la moneda
        /// </summary>
        public string Simbolo
        {
            get
            {
                return this.simbolo;
            }
        }

        /// <summary>
        /// Devuelve el valor del cambio de euro a la moneda, o lo modifica.
        /// </summary>
        public decimal Cambio
        {
            get
            {
                return this.cambioEuro;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("El valor no puede ser negativo");
                }
                else
                {
                    this.cambioEuro = value;
                }
            }
        }

    }
}
