using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horas
{
    class Program
    {
        /// <summary>
        /// Funcion que pasa una hora introducida por teclado a segundos
        /// </summary>
        /// <param name="h">parametro hora</param>
        /// <param name="min">parametro minutos</param>
        /// <param name="seg">parametro segundos</param>
        /// <returns>Devuelve la hora introducida en segundos</returns>
        static int HoraASegundos(int h, int min, int seg) //Ejercicio 30 
        {
            int totalseg, horaseg, minseg;

            horaseg = h * 3600;
            minseg = min * 60;

            totalseg = horaseg + minseg + seg;

            return totalseg;
        }

        /// <summary>
        /// Funcion que escribe la hora introducida en formato hh:mm:ss
        /// </summary>
        /// <param name="h">parametro hora </param>
        /// <param name="min">minuto</param>
        /// <param name="seg">segundos</param>
        /// <returns>Devuelve la hora introducida en formato hh:mm:ss</returns>
        static string EscribeHoraBonita(int h, int min, int seg) //Ejercicio 31
        {
            string hora;


            hora = h + ":" + min + ":" + seg;

            return hora;
        }

        /// <summary>
        /// Función que escribe un número de segundos escritos por teclado en formato HH:MM:SS
        /// </summary>
        /// <param name="seg">Segundos</param>
        /// <returns>Devuelve los segundos en formato HH:MM:SS</returns>
        static string EscribeSegundosBonito(int seg) //Ejercicio 32
        {
            int h, min, segfinal;

            h = seg / 3600;
            min = (seg / 60) - (h * 60);
            segfinal = seg % 60;

            return EscribeHoraBonita(h, min, segfinal);
        }


        /// <summary>
        /// Funcion que devuelve los segundos transcurridos entre dos fechas introducidas por teclado
        /// </summary>
        /// <param name="h1">Primera hora</param>
        /// <param name="min1">Minutos de la primera hora</param>
        /// <param name="seg1">Segundos de la primera hora</param>
        /// <param name="h2">Segunda hora</param>
        /// <param name="min2">Minutos de la segunda hora </param>
        /// <param name="seg2">Segundos de la segunda hora</param>
        /// <returns>Devuelve la diferencia en segundos entre las dos horas</returns>
        static int SegundosTranscurridos(int h1, int min1, int seg1, int h2, int min2, int seg2) //Ejercicio 33
        {
            int hora1, hora2, segtrans;

            hora1 = HoraASegundos(h1, min1, seg1);
            hora2 = HoraASegundos(h2, min2, seg2);

            if(hora1 >= hora2)
            {
                segtrans = hora1 - hora2;
            }
            else
            {
                segtrans = hora2 - hora1;
            }

            return segtrans;
        }


        //************************* EJERCICIO 34********************************************

        /// <summary>
        /// Funcion que indica si un año es bisiesto
        /// </summary>
        /// <param name="anho">parametro pasado por teclado que será un año</param>
        /// <returns>devuelve si el año es bisiesto o no</returns>
        static bool Bisiesto(int anho)
        {
            int year;

            year = anho;

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) //Debe ser divisible entre 4 Y ((no ser divisible entre 100) ó (ser divisible entre 400)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Funcion que devuelve los días que tiene un mes
        /// </summary>
        /// <param name="mes">parametro introducido por teclado en funcion del mes: enero = 1...</param>
        /// <returns>Los días que tiene el mes.</returns>
        static int DiaMes(int mes)
        {
            int dias;

            while (mes < 1 || mes > 12)
            {
                Console.WriteLine("El mes es incorrecto. Introducelo de nuevo: ");
                mes = int.Parse(Console.ReadLine());
            }

            if (mes == 2)
            {
                dias = 28;
            }
            else
            {
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    dias = 30;
                }
                else
                {
                    dias = 31;
                }
            }

            return dias;
        }

        /// <summary>
        /// Funcion DiaMes2 a la que le pasamos un mes y un año y nos devuelve los días que tiene
        /// </summary>
        /// <param name="mes">Mes en formato numerico</param>
        /// <param name="anho">año, para comprobar si es bisiesto o no</param>
        /// <returns>Los dias que tiene el mes introducido</returns>
        static int DiaMes2(int mes, int anho)
        {
            int dias;

            if (mes == 2 && Bisiesto(anho))
            {
                dias = 29;
                return dias;
            }
            else
            {
                return DiaMes(mes);
            }
        }

        /// <summary>
        /// Funcion que devuelve el numero de días que han transcurrido desde que comenzó el año introducido
        /// </summary>
        /// <param name="dia">Dia que introducimos por teclado</param>
        /// <param name="mes">Mes que introducimos por teclado</param>
        /// <param name="anho">Año que introducimos por teclado</param>
        /// <returns>Devuelve los dias transcurridos desde que comenzó el año</returns>
        static int DiasTranscurridos(int dia, int mes, int anho)
        {
            int i, diastrans;
            diastrans = 0;

            for (i = 1; i < mes; i++)
            {
                diastrans = diastrans + DiaMes2(i, anho);
            }

            diastrans = diastrans + dia;

            return diastrans;
        }

        /// <summary>
        /// Funcion que devuelve los dias transcurridos desde 1980
        /// </summary>
        /// <param name="dia">Dia que introducimos por teclado</param>
        /// <param name="mes">Mes que introducimos por teclado</param>
        /// <param name="anho">Año que introducimos por teclado</param>
        /// <returns>Devuelve los dias transcurridos desde 1980 hasta la fecha introducida</returns>
        static int DiasTranscurridos1980(int dia, int mes, int anho)
        {
            int i, diastrans;

            diastrans = 0;


            for (i = 1980; i < anho; i++)
            {
                if (Bisiesto(i))
                {
                    diastrans = diastrans + 366;
                }
                else
                {
                    diastrans = diastrans + 365;
                }
            }

            diastrans = diastrans + DiasTranscurridos(dia, mes, anho);

            return diastrans;
        }

        /// <summary>
        /// Función que devuelve los segundos transcurridos desde el 1 de enero de 1980 hasta una fecha y una hora indicadas por teclado
        /// </summary>
        /// <param name="dia">dia</param>
        /// <param name="mes">mes</param>
        /// <param name="anho">año</param>
        /// <param name="h">hora</param>
        /// <param name="min">minutos</param>
        /// <param name="seg">segundos</param>
        /// <returns>Segundos transcurridos desde el 1 de enero de 1980 hasta una fecha y una hora indicadas por teclado</returns>
        static int SegundosTranscurridos1980(int dia, int mes, int anho, int h, int min, int seg)
        {
            int dias, segtrans;

            dias = DiasTranscurridos1980(dia, mes, anho);

            segtrans = dias * (24 * 3600);

            return segtrans;
        }

        static void Main(string[] args)
        {
            int h, min, seg, h1, min1, seg1, dia, mes, anho;

            //Console.WriteLine("Introduce una hora: ");
            //h = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce una cantidad de minutos: ");
            //min = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce una cantidad de segundos: ");
            //seg = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce otra hora: ");
            //h1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce otra cantidad de minutos: ");
            //min1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce otra cantidad de segundos: ");
            //seg1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce un día: ");
            //dia = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce un mes: ");
            //mes = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce un año: ");
            //anho = int.Parse(Console.ReadLine());

            //EJERCICIO 30
            //Console.WriteLine(h + ":" + min + ":" + seg + " son: " + HoraASegundos(h, min, seg) + " segundos."); 

            //EJERCICIO 31
            //Console.WriteLine(EscribeHoraBonita(h, min, seg));

            //EJERCICIO 32 
            //Console.WriteLine(EscribeSegundosBonito(seg));

            //EJERCICIO 33
            //Console.WriteLine("Han transcurrido " + SegundosTranscurridos(h, min, seg, h1, min1, seg1));

            //EJERCICIO 34
            //Console.WriteLine("Han transcurrido " + SegundosTranscurridos1980(dia, mes, anho, h, min, seg) + " segundos desde 1980 hasta el " + dia + "/" + mes + "/" + anho + " a las " + EscribeHoraBonita(h, min, seg));


            Console.ReadKey();
        }
    }
}
