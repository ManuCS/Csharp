using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    class Program
    {
        static void Main(string[] args)
        {//Escribir todos los números primos entre 2 y 1000

            int numero, i, idivisores;

            idivisores = 0;

            Console.WriteLine("Los números primos del 2 a 1000 son: ");

            for(numero = 2; numero <= 1000; numero++) //numeros del 2 al 1000
            {
                for(i = 1; i <= numero; i++) //Este for realiza la cuenta de cuántos divisores tiene el número
                {
                    if(numero % i == 0)
                    {
                        idivisores++;
                    }
                }

                if (idivisores == 2) //Salgo del for que decide cuantos divisores tiene el número y evaluo. Si tiene 2 divisores es Primo, lo imprimo en pantalla
                {
                    Console.WriteLine(numero);
                }

                idivisores = 0;  //Pongo de nuevo el contador de divisores a 0 para poder evaluar el número siguiente
            }

            

            Console.ReadKey();
        }
    }
}
