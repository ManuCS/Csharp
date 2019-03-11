using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Program
    {

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
        static int DiaMes(int mes) //Ejercicio 21
        {
            int dias;
            
            while (mes < 1 || mes > 12)
            {
                Console.WriteLine("El mes es incorrecto. Introducelo de nuevo: ");
                mes = int.Parse(Console.ReadLine());
            }

            if(mes == 2)
            {
                dias = 28;
            }
            else
            {
                if(mes == 4 || mes == 6 || mes == 9 || mes == 11)
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
        static int DiaMes2(int mes, int anho) //Ejercicio 22
        {
            int dias;
            
            if(mes == 2 && Bisiesto(anho))
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
        static int DiasTranscurridos(int dia, int mes, int anho)//Ejercicio 23
        {
            int i, diastrans;
            diastrans = 0;

            for(i = 1; i < mes; i++)
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
        static int DiasTranscurridos1980(int dia, int mes, int anho)//Ejercicio 24
        {
            int i, diastrans;

            diastrans = 0;


            for(i = 1980; i < anho; i++)
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
        /// Funcion que calcula cuantos dias hay entre dos fechas introducidas por teclado, hecho de mi forma
        /// </summary>
        /// <param name="dia1">Primer dia</param>
        /// <param name="mes1">Primer mes</param>
        /// <param name="anho1">Primer año</param>
        /// <param name="dia2">Segundo dia</param>
        /// <param name="mes2">Segundo mes</param>
        /// <param name="anho2">Segundo año</param>
        /// <returns>Diferencia en dias entre dos fechas</returns>
        static int DiasEntreFechas1(int dia1, int mes1, int anho1, int dia2, int mes2, int anho2)//Ejercicio 25
        {
            int i, j, diastrans, diasmes2; //i = contador años, j = contador meses, m = contador2 meses

            //Puedo usar función DiasTranscurridos al llegar el contador al año2 

            diastrans = 0;

            if (anho1 <= anho2)
            {
                for (i = anho1; i < anho2; i++) //Suma los días de años completos que hay entre fecha1 y fecha2
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
                if (mes1 < mes2)
                {
                    if (anho1 == anho2)
                    {                                       //Resto Los dias del mes - el día introducido, para saber los dias restantes que quedan para finalizar el mes.
                        dia1 = DiaMes2(mes1, anho1) - dia1; //Para poder contar desde el primer dia del mes siguiente y después sumar este resultado.

                        for (j = mes1 + 1; j < mes2; j++) //Bucle para sumar los dias comprendidos entre el mes siguiente al mes1 y el mes anterior al mes2
                        {
                            diastrans = diastrans + (DiaMes2(j, anho2));
                        }

                        diastrans = diastrans + dia1 + dia2; //Como mes1 y mes2 no los he tenido en cuenta, sumo sus dias al total.
                    }
                    else
                    {
                        dia1 = DiaMes2(mes1, anho1) - dia1;

                        for (j = mes1 + 1; j <= 12; j++)
                        {
                            diastrans = diastrans + DiaMes2(j, anho2 - 1);
                        }

                        diasmes2 = DiasTranscurridos(dia2, mes2, anho2); //Para tener los días transcurridos desde el inicio del año2 hasta el dia2

                        diastrans = diastrans + dia1 + diasmes2;

                        if (Bisiesto(anho2 - 1))
                        {
                            diastrans = diastrans - 366;
                        }
                        else
                        {
                            diastrans = diastrans - 365;
                        }
                    }


                }
                else
                {
                    if (mes1 > mes2)
                    {
                        dia1 = DiaMes2(mes1, anho1) - dia1;

                        for (j = mes1 + 1; j <= 12; j++)
                        {
                            diastrans = diastrans + DiaMes2(j, anho2 - 1);
                        }


                        diasmes2 = DiasTranscurridos(dia2, mes2, anho2);

                        if (Bisiesto(anho2 - 1))
                        {
                            diastrans = diastrans + dia1 + diasmes2 - 366;
                        }
                        else
                        {
                            diastrans = diastrans + dia1 + diasmes2 - 365;
                        }
                    }
                }
            }
            else
            {
                if (anho1 > anho2)
                {
                    for (i = anho2; i < anho1; i++)
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
                    if (mes2 < mes1)
                    {

                        dia2 = DiaMes2(mes2, anho2) - dia2;


                        for (j = mes2 + 1; j <= 12; j++)
                        {
                            diastrans = diastrans + (DiaMes2(j, anho1 - 1));
                        }

                        diasmes2 = DiasTranscurridos(dia1, mes1, anho1);

                        diastrans = diastrans + dia2 + diasmes2;

                        if (Bisiesto(anho1 - 1))
                        {
                            diastrans = diastrans - 366;
                        }
                        else
                        {
                            diastrans = diastrans - 365;
                        }
                    }
                    else
                    {
                        if (mes2 > mes1)
                        {
                            dia2 = DiaMes2(mes2, anho2) - dia2;

                            for (j = mes2 + 1; j <= 12; j++)
                            {
                                diastrans = diastrans + DiaMes2(j, anho1 - 1);
                            }


                            diasmes2 = DiasTranscurridos(dia1, mes1, anho1);

                            if (Bisiesto(anho1 - 1))
                            {
                                diastrans = diastrans + dia1 + diasmes2 - 366;
                            }
                            else
                            {
                                diastrans = diastrans + dia1 + diasmes2 - 365;
                            }
                        }
                    }
                }
            }

            return diastrans;
        }


        /// <summary>
        /// Funcion que devuelve la diferencia en dia entre dos fechas.
        /// </summary>
        /// <param name="dia1">Primer dia</param>
        /// <param name="mes1">Primer mes</param>
        /// <param name="anho1">Primer año</param>
        /// <param name="dia2">Segundo dia</param>
        /// <param name="mes2">Segundo mes</param>
        /// <param name="anho2">Segundo año</param>
        /// <returns>Diferencia en dias entre dos fechas</returns>
        static int DiasEntreFechas2(int dia1, int mes1, int anho1, int dia2, int mes2, int anho2)//Ejercicio 25 de otra forma(más simplificado)
        {
            int diasentre;
            if (anho1 > anho2)
            {
                diasentre = DiasTranscurridos1980(dia1, mes1, anho1) - DiasTranscurridos1980(dia2, mes2, anho2);
            }
            else
            {
                diasentre = DiasTranscurridos1980(dia2, mes2, anho2) - DiasTranscurridos1980(dia1, mes1, anho1);
            }
            return diasentre;
        }


        /// <summary>
        /// Funcion que devuelve el día de la semana que será el día introducido por teclado
        /// </summary>
        /// <param name="dia">Día introducido</param>
        /// <param name="mes">Mes introducido</param>
        /// <param name="anho">año introducido</param>
        /// <returns>El día de la semana que será esa fecha en formato numérico: lunes 0, martes 1...</returns>
        static int DiaSemanaFecha(int dia, int mes, int anho)//Ejercicio 26
        {
            int diasemana; //0 Lunes, 1 Martes, 2 Miercoles, 3 Jueves, 4 viernes, 5 sabado, 6 domingo

            diasemana = DiasTranscurridos1980(dia, mes, anho) % 7;

            return diasemana;
        }

        static void Main(string[] args)
        {
            int dia, mes, anho, dia2, mes2, anho2;

            Console.WriteLine("Introduce un dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un mes: ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un año: ");
            anho = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce otro dia: ");
            //dia2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce otro mes: ");
            //mes2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce otro año: ");
            //anho2 = int.Parse(Console.ReadLine());



            //Console.WriteLine("Este mes tiene " + DiaMes(mes) + " días");
            //Console.WriteLine("Este mes tiene " + DiaMes2(mes, anho) + " días");
            //Console.WriteLine("Han transcurrido: " + DiasTranscurridos(dia, mes, anho) + " días desde que comenzó el año.");
            //Console.WriteLine("Han transcurrido: " + DiasTranscurridos1980(dia, mes, anho) + " días desde 1980.");
            //Console.WriteLine("Han transcurrido: " + DiasEntreFechas1(dia, mes, anho, dia2, mes2, anho2) + " días entre " + dia + "/" + mes + "/" + anho + " y " + dia2 + "/" + mes2 + "/" + anho2);
            //Console.WriteLine("Han transcurrido: " + DiasEntreFechas2(dia, mes, anho, dia2, mes2, anho2) + " días entre " + dia + "/" + mes + "/" + anho + " y " + dia2 + "/" + mes2 + "/" + anho2);


            //Ultimo ejercicio------------------------------------------------------------------------------------------
            //if(DiaSemanaFecha(dia, mes, anho) == 0)
            //{
            //    Console.WriteLine("El día " + dia + "/" + mes + "/" + anho + " es lunes");
            //}
            //else
            //{
            //    if(DiaSemanaFecha(dia, mes, anho) == 1)
            //    {
            //        Console.WriteLine("El día " + dia + "/" + mes + "/" + anho + " es martes");
            //    }
            //    else
            //    {
            //        if (DiaSemanaFecha(dia, mes, anho) == 2)
            //        {
            //            Console.WriteLine("El día " + dia + "/" + mes + "/" + anho + " es miércoles");
            //        }
            //        else
            //        {
            //            if (DiaSemanaFecha(dia, mes, anho) == 3)
            //            {
            //                Console.WriteLine("El día " + dia + "/" + mes + "/" + anho + " es jueves");
            //            }
            //            else
            //            {
            //                if (DiaSemanaFecha(dia, mes, anho) == 4)
            //                {
            //                    Console.WriteLine("El día " + dia + "/" + mes + "/" + anho + " es viernes");
            //                }
            //                else
            //                {
            //                    if (DiaSemanaFecha(dia, mes, anho) == 5)
            //                    {
            //                        Console.WriteLine("El día " + dia + "/" + mes + "/" + anho + " es sábado");
            //                    }
            //                    else
            //                    {
            //                        if (DiaSemanaFecha(dia, mes, anho) == 6)
            //                        {
            //                            Console.WriteLine("El día " + dia + "/"+ mes + "/"+ anho + " es domingo");
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            
            Console.ReadKey();
      
        }
    }
}
