using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoYAlumno
{
    class Alumno
    {
        //Atributos

        private string nombre;
        private int edad;
        private decimal calificacion;


        //Constructores

        /// <summary>
        /// Crea a un alumno a partir de los datos introducidos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="calificacion"></param>
        public Alumno(string nombre, int edad, decimal calificacion)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.calificacion = calificacion;
        }

        
        //Propiedades

        /// <summary>
        /// Permite leer el nombre o cambiarlo
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if(value != "")
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception("El nombre no puede estar vacío.");
                }
            }
        }

        /// <summary>
        /// Lee la edad o la modifica
        /// </summary>
        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                if(value >= 17 && value <= 100)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("La edad no puede ser menor de 17 ni mayor de 100");
                }
            }
        }

        /// <summary>
        /// Lee la calificación o la modifica
        /// </summary>
        public decimal Calificacion
        {
            get
            {
                return calificacion;
            }

            set
            {
                if(value >= 0 && value <= 10)
                {
                    calificacion = value;
                }
                else
                {
                    throw new Exception("La calificación no puede ser menor que 0 ni mayor que 10");
                }
            }
        }


        // Métodos 

        /// <summary>
        /// Imprime los datos del alumno
        /// </summary>
        /// <param name="a">alumno</param>
        /// <returns>datos del alumno</returns>
        public string Imprime(Alumno a)
        {
            string alumno;

            alumno = a.nombre + " " + a.edad + " " + a.calificacion;

            return alumno;
        }

        
    }
}
