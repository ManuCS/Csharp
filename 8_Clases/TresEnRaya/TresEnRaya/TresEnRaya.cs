using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class TresEnRaya
    {
        //Atributos

        private int[,] array;


        //Constructores

        /// <summary>
        /// Inicializa el array y lo pone todo a 0
        /// </summary>
        public TresEnRaya()
        {
            int i, j;
            array = new int[3, 3];

            for(i = 0; i < array.GetLength(0); i++)
            {
                for(j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 0;
                }
            }

        }


        //Metodos

        /// <summary>
        /// Pone una X, si es posible, en la posición que el jugador1 indique
        /// </summary>
        /// <param name="pos1">posicion1</param>
        /// <param name="pos2">posicion2</param>
        public void MueveJugador1(int pos1, int pos2)
        {
            if(pos1 < 0 || pos1 > 2 || pos2 < 0 || pos2 > 2)
            {
                throw new Exception("Las posiciones solo pueden ser: '0', '1' y '2'.");
            }
            else
            {
                if(MovimientoValido(pos1, pos2))
                {
                    array[pos1, pos2] = 1;
                }
            }
        }

        /// <summary>
        /// Pone una O, si es posible, en la posición que el jugador2 indique
        /// </summary>
        /// <param name="pos1">posicion1</param>
        /// <param name="pos2">posicion2</param>
        public void MueveJugador2(int pos1, int pos2)
        {
            if (pos1 < 0 || pos1 > 2 || pos2 < 0 || pos2 > 2)
            {
                throw new Exception("Las posiciones solo pueden ser: '0', '1' y '2'.");
            }
            else
            {
                if (MovimientoValido(pos1, pos2))
                {
                    array[pos1, pos2] = 2;
                }
            }
        }

        /// <summary>
        /// Comprueba si el movimiento es válido
        /// </summary>
        /// <param name="pos1">posicion 1 del array bidimiensional</param>
        /// <param name="pos2">posicion 2 del array bidimiensional</param>
        /// <returns>Verdadero si es valido, falso si no.</returns>
        public bool MovimientoValido(int pos1, int pos2)
        {
            if(array[pos1, pos2] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void MueveOrdenador1()
        {

        }
    }
}
