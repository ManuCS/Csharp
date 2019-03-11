using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaYBaraja
{
    class Carta
    {
        //Atributos

        private int numero;
        private int palo;


        //Constructores

        /// <summary>
        /// Crea una carta con el número y el palo que le pasas
        /// </summary>
        /// <param name="numero">Número de carta</param>
        /// <param name="palo">Palo de carta</param>
        public Carta(int numero, int palo)
        {
            if (numero >= 1 && numero <= 10 && palo >= 0 && palo <= 3)
            {
                this.numero = numero;
                this.palo = palo;
            }
            else
            {
                throw new Exception("Valores erróneos para la carta.");
            }
        }

        /// <summary>
        /// Crea una carta a partir de su número de identificación
        /// </summary>
        /// <param name="id">Número de identificación (de 1 a 40)</param>
        public Carta(int id)
        {
            if (id > 0 && id <= 40)
            {
                int[] numeros = { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                if (id > 0 && id <= 10)
                {
                    this.numero = numeros[id % 10];
                    this.palo = 0;
                }
                else
                {
                    if (id > 10 && id <= 20)
                    {
                        this.numero = numeros[id % 10];
                        this.palo = 1;
                    }
                    else
                    {
                        if (id > 20 && id <= 30)
                        {
                            this.numero = numeros[id % 10];
                            this.palo = 2;
                        }
                        else
                        {
                            if (id > 30 && id <= 40)
                            {
                                this.numero = numeros[id % 10];
                                this.palo = 3;
                            }
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Los valores de la carta no son correctos");
            }
        }


        //Propiedades

        /// <summary>
        /// Devuelve el valor del número
        /// </summary>
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Devuelve el valor del palo
        /// </summary>
        public int Palo
        {
            get
            {
                return this.palo;
            }
        }

        /// <summary>
        /// Devuelve el valor del número en texto
        /// </summary>
        public string NombreNumero
        {
            get
            {
                string nombre = "";

                switch (this.numero)
                {
                    case 1:
                        nombre = "as";
                        break;
                    case 2:
                        nombre = "dos";
                        break;
                    case 3:
                        nombre = "tres";
                        break;
                    case 4:
                        nombre = "cuatro";
                        break;
                    case 5:
                        nombre = "cinco";
                        break;
                    case 6:
                        nombre = "seis";
                        break;
                    case 7:
                        nombre = "siete";
                        break;
                    case 8:
                        nombre = "sota";
                        break;
                    case 9:
                        nombre = "caballo";
                        break;
                    case 10:
                        nombre = "rey";
                        break;
                }

                return nombre;
            }
        }

        /// <summary>
        /// Devuelve el valor del palo en texto
        /// </summary>
        public string NombrePalo
        {
            get
            {
                string[] nombre = { "oro", "copa", "espada", "bastos" };

                return nombre[this.palo];
            }
        }

        /// <summary>
        /// Devuelve el nombre de la carta
        /// </summary>
        public string NombreCarta
        {
            get
            {
                string nombre = NombreNumero + " de " + NombrePalo;
                return nombre;
            }
        }

        /// <summary>
        /// Devuelve el valor de la carta en el juego el Tute
        /// </summary>
        public int ValorTute
        {
            get
            {
                int[] valores = { 0, 11, 0, 10, 0, 0, 0, 0, 2, 3, 4 };

                return valores[this.numero];
            }
        }

        /// <summary>
        /// Devuelve el valor de la carta en el juego el Mus
        /// </summary>
        public int ValorMus
        {
            get
            {
                int[] valores = { 0, 1, 1, 10, 4, 5, 6, 7, 10, 10, 10 };
                return valores[this.numero];
            }
        }

        /// <summary>
        /// Devuelve el valor de la carta en el juego de 7 y media
        /// </summary>
        public decimal Valor7ymedia
        {
            get
            {
                decimal[] valores = { -1, 1, 2, 3, 4, 5, 6, 7, 0.5m, 0.5m, 0.5m };

                return valores[this.numero];
            }
        }
            
        public override string ToString()
        {
            return NombreCarta;
        }
    }
}
