using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaYBaraja
{
    class Baraja
    {
        //Atributos
        private List<Carta> listaCartas;


        //Constructores

            
        /// <summary>
        /// Crea una baraja vacía.
        /// </summary>
        public Baraja()
        {
            List<Carta> baraja = new List<Carta>();
        }

        /// <summary>
        /// Crea una baraja normal o una doble
        /// </summary>
        /// <param name="tipobaraja">1 = baraja normal, 2 = baraja doble</param>
        public Baraja(int tipobaraja)
        {
            int palo, numero;

            if (tipobaraja == 1)
            {
                listaCartas = new List<Carta>();

                for (palo = 0; palo <= 3; palo++)
                {
                    for (numero = 1; numero <= 10; numero++)
                    {
                        Carta c = new Carta(numero, palo);
                        listaCartas.Add(c);
                    }
                }
            }
            else
            {
                if(tipobaraja == 2)
                {
                    listaCartas = new List<Carta>();

                    while(listaCartas.Count < 80)
                    {
                        for (palo = 0; palo <= 3; palo++)
                        {
                            for (numero = 1; numero <= 10; numero++)
                            {
                                Carta c = new Carta(numero, palo);
                                listaCartas.Add(c);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Crea una baraja normal o doble y se barajará o no
        /// </summary>
        /// <param name="tipobaraja">Tipo de baraja que será, normal o doble</param>
        /// <param name="barajar">Si se baraja o no</param>
        public Baraja(int tipobaraja, bool barajar)
        {
            int palo, numero;

            if (tipobaraja == 1)
            {
                listaCartas = new List<Carta>();

                for (palo = 0; palo <= 3; palo++)
                {
                    for (numero = 1; numero <= 10; numero++)
                    {
                        Carta c = new Carta(numero, palo);
                        listaCartas.Add(c);
                    }
                }
            }
            else
            {
                if (tipobaraja == 2)
                {
                    listaCartas = new List<Carta>();

                    while (listaCartas.Count < 80)
                    {
                        for (palo = 0; palo <= 3; palo++)
                        {
                            for (numero = 1; numero <= 10; numero++)
                            {
                                Carta c = new Carta(numero, palo);
                                listaCartas.Add(c);
                            }
                        }
                    }
                }
            }

            if (barajar)
            {
                Barajar();
            }

        }


        //Metodos

        /// <summary>
        /// Mezcla aleatoriamente las cartas de la baraja
        /// </summary>
        public void Barajar()
        {
            Random rnd = new Random();

            int n;

            List<Carta> listaBarajar = new List<Carta>();

            while(this.listaCartas.Count > 0)
            {
                n = rnd.Next(0, this.listaCartas.Count - 1);
                listaBarajar.Add(this.listaCartas[n]);
                this.listaCartas.RemoveAt(n);
            }

            listaCartas.AddRange(listaBarajar);

        }

        /// <summary>
        /// Corta la baraja por la posición que le indiques
        /// </summary>
        /// <param name="posicion">Posición por donde se cortará la baraja</param>
        public void Cortar(int posicion)
        {
            int i;

            for(i = 0; i <= posicion; i++)
            {
                this.listaCartas.Insert(listaCartas.Count - 1, listaCartas[i]);
                this.listaCartas.RemoveAt(i);
            }
        }

        /// <summary>
        /// Roba una carta de la baraja
        /// </summary>
        /// <returns>Carta robada</returns>
        public Carta Robar()
        {
            Carta c;

            if(this.listaCartas.Count > 0)
            {
                c = listaCartas[0];
                listaCartas.RemoveAt(0);

                return c;
            }
            else
            {
                throw new Exception("No quedan cartas en la baraja.");
            }
        }

        /// <summary>
        /// Inserta una nueva carta al final de lista en función de su ID
        /// </summary>
        /// <param name="id_carta">Id de la carta</param>
        public void InsertaCartaFinal(int id_carta)
        {
            Carta c = new Carta(id_carta);

            this.listaCartas.Add(c);
        }

        /// <summary>
        /// Inserta una nueva carta al principio de la lista en función de su ID
        /// </summary>
        /// <param name="id_carta"></param>
        public void InsertaCartaPrincipio(int id_carta)
        {
            Carta c = new Carta(id_carta);

            this.listaCartas.Insert(0, c);
        }

        /// <summary>
        /// Inserta una nueva carta al final de la lista
        /// </summary>
        /// <param name="c">Carta</param>
        public void InsertaCartaFinal(Carta c)
        {
            this.listaCartas.Add(c);
        }

        /// <summary>
        /// Inserta una nueva carta al principio de la lista
        /// </summary>
        /// <param name="c">Carta</param>
        public void InsertaCartaPrincipio(Carta c)
        {
            this.listaCartas.Insert(0, c);
        }

        

        //Propiedades

        /// <summary>
        /// Devuelve el número de cartas de la baraja
        /// </summary>
        public int NumeroCartas
        {
            get
            {
                return this.listaCartas.Count;
            }
        }


        /// <summary>
        /// Nos dice si la baraja está vacia o no.
        /// </summary>
        public bool Vacia
        {
            get
            {
                if(this.listaCartas.Count == 0)
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
}
