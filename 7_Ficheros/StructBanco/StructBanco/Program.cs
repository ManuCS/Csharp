using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StructBanco
{
    class Program
    {
        struct CuentaCorriente
        {
            public string numero_cc;
            public string cliente;
            public decimal saldo;
        }


        /// <summary>
        /// Función que crea una nueva cuenta bancaria.
        /// </summary>
        /// <param name="l">Lista de cuentas corrientes</param>
        static void NuevaCuentaBanco(List<CuentaCorriente> l)//Ejercicio 1
        {
            int i, cont;
            cont = 0;
            CuentaCorriente nueva;

            Console.WriteLine("Introduce el número de la cuenta bancaria: ");
            nueva.numero_cc = Console.ReadLine();

            Console.WriteLine("Introduce el nombre del propietario: ");
            nueva.cliente = Console.ReadLine();

            Console.WriteLine("Introduce el saldo de la cuenta: ");
            nueva.saldo = decimal.Parse(Console.ReadLine());

            
            if(l.Count > 0)
            {
                for(i = 0; i < l.Count; i++)
                {
                    if(l[i].numero_cc == nueva.numero_cc)
                    {
                        cont++;
                    }
                }

                if(cont == 0)
                {
                    l.Add(nueva);
                }
                else
                {
                    Console.WriteLine("El número de la cuenta corriente está ya repetido.");
                }
            }
            else
            {
                l.Add(nueva);
            }


        }

        /// <summary>
        /// Función que elimina una cuenta bancaria.
        /// </summary>
        /// <param name="l">Lista de cuentas bancarias</param>
        static void EliminarCuentaBanco(List<CuentaCorriente> l)//Ejercicio 2
        {
            int i, cont;
            string elimina;

            cont = 0;

            Console.WriteLine("Introduce el número de cuenta que desea borrar: ");
            elimina = Console.ReadLine();

            for(i = 0; i < l.Count; i++)
            {
                if(l[i].numero_cc == elimina)
                {
                    l.Remove(l[i]);
                    cont++;
                }
            }

            if(cont == 0)
            {
                Console.WriteLine("La cuenta bancaria que desea eliminar no existe.");
            }
        }

        /// <summary>
        /// Función que realiza un ingreso o un retiro de dinero a la cuenta elegida.
        /// </summary>
        /// <param name="l">lista de cuentas bancarias</param>
        static void ActualizarSaldoBanco(List<CuentaCorriente> l)//Ejercicio 3
        {
            int i, cont;
            decimal cantidad;
            string cuenta;

            cont = 0;

            CuentaCorriente copia;

            Console.WriteLine("Introduce el número de cuenta: ");
            cuenta = Console.ReadLine();

            Console.WriteLine("Introduce la cantidad que desea ingresar(+) o retirar(-): ");
            cantidad = decimal.Parse(Console.ReadLine());

            for(i = 0; i < l.Count; i++)
            {
                if(l[i].numero_cc == cuenta)
                {
                    copia = l[i];
                    copia.saldo = l[i].saldo + cantidad;
                    l[i] = copia;
                    cont++;
                    Console.WriteLine("El saldo es de: " + l[i].saldo);
                }
            }

            if (cont == 0)
            {
                Console.WriteLine("La cuenta introducida no existe.");
            }

        }

        /// <summary>
        /// Función que imprime por pantalla las cuentas bancarias existentes y sus datos
        /// </summary>
        /// <param name="l">Lista de cuentas corrientes</param>
        static void ImprimirCuentasBanco(List<CuentaCorriente> l)//Ejercicio 4
        {
            int i;

            if(l.Count == 0)
            {
                Console.WriteLine("No existe ninguna cuenta corriente");
            }
            else
            {
                for (i = 0; i < l.Count; i++)
                {
                    Console.WriteLine("Numero de cuenta: " + l[i].numero_cc);
                    Console.WriteLine("Nombre propietario: " + l[i].cliente);
                    Console.WriteLine("Saldo: " + l[i].saldo);
                    Console.WriteLine("---------------------------------------");
                }
            }
        }

        /// <summary>
        /// Función que guarda las cuentas bancarias en un fichero
        /// </summary>
        /// <param name="l">lista de cuentas bancarias</param>
        /// <param name="fichero">Fichero con las cuentas bancarias</param>
        static void GuardarFicheroBanco(List<CuentaCorriente> l, string fichero)//Ejercicio 5
        {
            int i, n;
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            n = l.Count();

            bw.Write(n);

            for (i = 0; i < l.Count; i++)
            {
                bw.Write(l[i].numero_cc);
                bw.Write(l[i].cliente);
                bw.Write(l[i].saldo);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Función que lee un fichero de cuentas corrientes de un banco
        /// </summary>
        /// <param name="l">Lista de cuentas de un banco</param>
        /// <param name="fichero">Fichero de cuentas de un banco</param>
        static void LeerFicheroBanco(List<CuentaCorriente> l, string fichero = "banco.cc")//Ejercicio 6
        {
            GuardarFicheroBanco(l, fichero);
            l.Clear();

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine("Numero cuentas bancarias: " + br.ReadInt32());

            while (fs.Position < fs.Length)
            {
                Console.WriteLine("Numero de cuenta: " + br.ReadString());
                Console.WriteLine("Titular: " + br.ReadString());
                Console.WriteLine("Saldo: " + br.ReadDecimal());
                Console.WriteLine("--------------------------------");
            }


            br.Close();
            fs.Close();
        }



        //Relacion 2---------------

        /// <summary>
        /// Función que guarda las cuentas bancarias en un fichero txt
        /// </summary>
        /// <param name="l">Lista con las cuentas bancarias</param>
        /// <param name="fichero">Fichero txt</param>
        static void GuardarFicheroBancoTXT(List<CuentaCorriente> l, string fichero)//Ejercicio 7
        {
            int i, n;
            StreamWriter sw = new StreamWriter(fichero);

            n = l.Count;

            sw.WriteLine("Numero de cuentas: " + n);
            sw.WriteLine();

            if (l.Count == 0)
            {
                Console.WriteLine("No existe ninguna cuenta corriente");
            }
            else
            {
                for (i = 0; i < l.Count; i++)
                {
                    sw.WriteLine("Numero de cuenta: " + l[i].numero_cc);
                    sw.WriteLine("Nombre propietario: " + l[i].cliente);
                    sw.WriteLine("Saldo: " + l[i].saldo);
                    sw.WriteLine("---------------------------------------");
                }
            }

            sw.Close();
        }

        /// <summary>
        /// Función que lee un fichero txt de cuentas corrientes de un banco
        /// </summary>
        /// <param name="l">lista cuentas de un banco</param>
        /// <param name="fichero">fichero txt</param>
        static void LeerFicheroBancoTXT(List<CuentaCorriente> l, string fichero)//Ejercicio 8
        {
            GuardarFicheroBancoTXT(l, fichero);

            l.Clear();

            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        /// <summary>
        /// Función que guarda los datos del banco en un fichero CSV
        /// </summary>
        /// <param name="l">Lista de cuentas bancarias</param>
        /// <param name="fichero">Fichero CSV</param>
        static void GuardarFicheroBancoCSV(List<CuentaCorriente> l, string fichero)//Ejercicio 9
        {
            int i;

            StreamWriter sw = new StreamWriter(fichero);

            for(i = 0; i < l.Count; i++)
            {
                sw.Write(l[i].numero_cc + ";" + l[i].cliente + ";" + l[i].saldo);
                sw.WriteLine();
            }

            sw.Close();
        }

        /// <summary>
        /// Función que lee los datos del banco de un fichero CSV
        /// </summary>
        /// <param name="fichero">Fichero CSV</param>
        static void LeerFicheroBancoCSV(string fichero)//Ejercicio 10
        {
            CuentaCorriente nueva;

            List<CuentaCorriente> l = new List<CuentaCorriente>();

            string s;
            string[] cad;

            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                cad = s.Split(';');

                nueva.numero_cc = cad[0];
                nueva.cliente = cad[1];
                nueva.saldo = Convert.ToDecimal(cad[2]);

                l.Add(nueva);
            }

            ImprimirCuentasBanco(l);
        }


        static void Main(string[] args)
        {
            List<CuentaCorriente> CuentaCorriente = new List<CuentaCorriente>();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine(" 1- NuevaCuentaBanco");
                Console.WriteLine(" 2- EliminarCuentaBanco");
                Console.WriteLine(" 3- ActualizarSaldoBanco");
                Console.WriteLine(" 4- ImprimirCuentasBanco");
                Console.WriteLine(" 5- GuardarFicheroBanco");
                Console.WriteLine(" 6- LeerFicheroBanco");
                Console.WriteLine(" 7- GuardarFicheroBancoTXT");
                Console.WriteLine(" 8- LeerFicheroBancoTXT");
                Console.WriteLine(" 9- GuardaFicheroBancoCSV");
                Console.WriteLine(" 10- LeerFicheroBancoCSV");
                Console.WriteLine("Salir = 0");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            NuevaCuentaBanco(CuentaCorriente);
                        }
                        break;

                    case 2:
                        {
                            EliminarCuentaBanco(CuentaCorriente);
                        }
                        break;

                    case 3:
                        {
                            ActualizarSaldoBanco(CuentaCorriente);
                        }
                        break;

                    case 4:
                        {
                            ImprimirCuentasBanco(CuentaCorriente);
                        }
                        break;

                    case 5:
                        {
                            string fichero = "cuentas.bin";
                            GuardarFicheroBanco(CuentaCorriente, fichero);
                        }
                        break;

                    case 6:
                        {
                            LeerFicheroBanco(CuentaCorriente);
                        }
                        break;

                    case 7:
                        {
                            string fichero = "cuentas.txt";
                            GuardarFicheroBancoTXT(CuentaCorriente, fichero);
                        }
                        break;

                    case 8:
                        {
                            string fichero = "cuentasbanco.txt";
                            LeerFicheroBancoTXT(CuentaCorriente, fichero);
                        }
                        break;

                    case 9:
                        {
                            string fichero = "cuentas.csv";
                            GuardarFicheroBancoCSV(CuentaCorriente, fichero);
                        }
                        break;

                    case 10:
                        {
                            string fichero = "cuentas.csv";
                            LeerFicheroBancoCSV(fichero);
                        }
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
