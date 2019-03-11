using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVeterinaria
{
    /// <summary>
    /// Razas de perro
    /// </summary>
    enum RazaPerro
    {
        PastorAleman, Husky, FoxTerrier, Dalmata, SanBernardo
    }

    /// <summary>
    /// Razas de gato
    /// </summary>
    enum RazaGato
    {
        Comun, Siames, Persa, Angora, ScottishFold
    }

    /// <summary>
    /// Especies de pájaro
    /// </summary>
    enum EspeciePajaro
    {
        Canario, Periquito, Agapornis
    }

    /// <summary>
    /// Especies de reptil
    /// </summary>
    enum EspecieReptil
    {
        Tortuga, Iguana, DragonDeComodo
    }


    //Clase abstracta ANIMAL

    abstract class Animal
    {
        //Atributos

        protected String nombre;
        protected DateTime fechanacimineto;
        protected Double peso;
        protected String comentario;

        //Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public DateTime FechaNacimineto
        {
            get
            {
                return fechanacimineto;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                if (value > 0)
                {
                    peso = value;
                }
                else
                {
                    throw new Exception("las cagao");
                }
            }
        }

        public string Comentario
        {
            get
            {
                return comentario;
            }
            set
            {
                comentario = value;
            }
        }


        //Método abstracto

        /// <summary>
        /// Obliga a que las clases que heredan de Animal implementen ToString
        /// </summary>
        /// <returns></returns>
        public override abstract string ToString();
    }



    //Clase PERRO (hereda de animal)

    class Perro : Animal
    {
        //Atributos adicionales

        private RazaPerro raza;
        private string microchip;


        //Constructor

        public Perro(string Nombre, RazaPerro Raza, DateTime FechaNacimiento, double Peso, string Microchip)
        {
            this.nombre = Nombre;
            this.raza = Raza;
            this.fechanacimineto = FechaNacimiento;
            this.peso = Peso;
            this.microchip = Microchip;
        }


        //Propiedades de atributos adicionales

        public RazaPerro Raza
        {
            get
            {
                return raza;
            }
        }

        public string Microchip
        {
            get
            {
                return microchip;
            }
        }


        //Métodos

        /// <summary>
        /// Muestra por pantalla una fichita con todos los atributos de perro
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ficha = "";

            ficha = "Ficha de Perro\n" + "".PadLeft(80, '-') + "\n Nombre: " + this.nombre + "\n Raza: " + this.raza + "\n Fecha de Nacimiento: " + this.fechanacimineto + "\n Peso: " + this.peso + " kg \n Microchip: " + microchip + "\n Comentarios: " + comentario + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
    }



    //Clase GATO (hereda de animal)

    class Gato : Animal
    {
        //Atributos adicionales

        private RazaGato raza;
        private string microchip;

        //Constructor
        public Gato(string Nombre, RazaGato Raza, DateTime FechaNacimiento, double Peso, string Microchip)
        {
            this.nombre = Nombre;
            this.raza = Raza;
            this.fechanacimineto = FechaNacimiento;
            this.peso = Peso;
            this.microchip = Microchip;
        }

        //Propiedades de atributos adicionales
        public RazaGato Raza
        {
            get
            {
                return raza;
            }
        }

        public string Microchip
        {
            get
            {
                return microchip;
            }
        }


        //Método

        /// <summary>
        /// Muestra por pantalla una fichita con todos los atributos de gato
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ficha = "";

            ficha = "Ficha de Gato\n" + "".PadLeft(80, '-') + " \n Nombre: " + this.nombre + "\n Raza: " + this.raza + "\n Fecha de Nacimiento: " + this.fechanacimineto + "\n Peso: " + this.peso + " kg \n Microchip: " + microchip + "\n Comentarios: " + comentario + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
    }


    //Clase PAJARO (hereda de animal)


    class Pajaro : Animal
    {
        //Atributos adicionales

        private EspeciePajaro especie;
        private bool cantor;

        //Constructor
        public Pajaro(string Nombre, EspeciePajaro Especie, DateTime FechaNacimiento, double Peso, bool Cantor)
        {
            this.nombre = Nombre;
            this.especie = Especie;
            this.fechanacimineto = FechaNacimiento;
            this.peso = Peso;
            this.cantor = Cantor;
        }

        //Propiedades

        public EspeciePajaro Especie
        {
            get
            {
                return especie;
            }
        }

        public bool Cantor
        {
            get
            {
                return cantor;
            }
        }

        //Método

        /// <summary>
        /// Muestra por pantalla una fichita con todos los atributos de pájaro
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ficha = "";

            ficha = "Ficha de Pajaro\n" + "".PadLeft(80, '-') + " \n Nombre: " + this.nombre + "\n Especie: " + this.especie + "\n Fecha de Nacimiento: " + this.fechanacimineto + "\n Peso: " + this.peso + " kg \n Cantor: " + cantor + "\n Comentarios: " + comentario + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
    }


    //Clase REPTIL (hereda de animal)


    class Reptil : Animal
    {
        //Atributos adicionales
        private EspecieReptil especie;
        private bool venenoso;

        //Constructor
        public Reptil(string Nombre, EspecieReptil Especie, DateTime FechaNacimiento, double Peso, bool Venenoso)
        {
            this.nombre = Nombre;
            this.especie = Especie;
            this.fechanacimineto = FechaNacimiento;
            this.peso = Peso;
            this.venenoso = Venenoso;
        }

        //Propiedades

        public EspecieReptil Especie
        {
            get
            {
                return especie;
            }
        }

        public bool Venenoso
        {
            get
            {
                return venenoso;
            }
        }

        //Método

        /// <summary>
        /// Muestra por pantalla una fichita con todos los atributos de reptil
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ficha = "";

            ficha = "Ficha de Reptil\n" + "".PadLeft(80, '-') + " \n Nombre: " + this.nombre + "\n Especie: " + this.especie + "\n Fecha de Nacimiento: " + this.fechanacimineto + "\n Peso: " + this.peso + " kg \n Venenoso: " + venenoso + "\n Comentarios: " + comentario + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
    }


    //Clase Clínica Veterinaria

    class Clinica
    {
        //Atributos

        //Meteremos todos los animales
        private List<Animal> listaAnimales;

        //Constructor
        public Clinica()
        {
            listaAnimales = new List<Animal>();
        }


        //Métodos

        /// <summary>
        /// Añade un animal a la lista
        /// </summary>
        /// <param name="animal"></param>
        public void InsertaAnimal(Animal animal)
        {
            listaAnimales.Add(animal);
        }

        /// <summary>
        /// Le pasas el nombre del animal y devuelve su ficha de Animal
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Animal BuscaAnimal(string nombre)
        {
            int i;
            Animal buscado = null;

            for (i = 0; i < listaAnimales.Count; i++)
            {
                if (listaAnimales[i].Nombre == nombre)
                {
                    buscado = listaAnimales[i];
                }
            }
            return buscado;
        }


        /// <summary>
        /// Modifica el comentario del animal
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="comentario"></param>
        public void ModificaComentarioAnimal(string nombre, string comentario)
        {
            int i;
            for (i = 0; i < listaAnimales.Count; i++)
            {
                if (listaAnimales[i].Nombre == nombre)
                {
                    listaAnimales[i].Comentario = comentario;
                }
            }
        }

        /// <summary>
        /// Muestra la lista de todas las fichas de los animales
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cadena = "";
            int i;
            for (i = 0; i < listaAnimales.Count; i++)
            {
                cadena = cadena + listaAnimales[i] + " \n\n ";
            }
            return cadena;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            bool pregunta = false;
            bool pregunta2 = true;
            int eleccion;

            string nombre;
            RazaPerro rperro;
            RazaGato rgato;
            EspeciePajaro epajaro;
            EspecieReptil ereptil;
            DateTime fecha;
            double loquepesa;
            string microchip;
            bool venenosocantor;
            string comentario;

            DateTime d = new DateTime(2011, 1, 1);
            Perro perro1 = new Perro("pepe", RazaPerro.Husky, d, 20, "123456abc");
            Perro perro2 = new Perro("juan", RazaPerro.Dalmata, d, 10, "99999a");
            Gato gato1 = new Gato("garfi", RazaGato.Comun, d, 5, "gato1234");
            Reptil reptil1 = new Reptil("lagarto", EspecieReptil.DragonDeComodo, d, 10, true);

            Clinica clinica = new Clinica();
            clinica.InsertaAnimal(perro1);
            clinica.InsertaAnimal(perro2);
            clinica.InsertaAnimal(gato1);
            clinica.InsertaAnimal(reptil1);

            Console.WriteLine("Bienvenido a la clinica veterinaria");
            Console.WriteLine("desea introducir un nuevo animal ? (TRUE OR FALSE)");
            pregunta = bool.Parse(Console.ReadLine());
            if (pregunta == true)
            {
                while (pregunta2 == true)
                {
                    Console.WriteLine("Que  tipo de animal desea introducir\n Perro-> 1\n Gato-> 2\n pajaro-> 3\n Reptil-> 4");
                    eleccion = int.Parse(Console.ReadLine());
                    switch (eleccion)
                    {
                        case 1:
                            {
                                Console.WriteLine("Introduce el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Introduce la raza\n PastorAleman-> 1\n Husky-> 2\n FoxTerrier->3\n Dalmata->4\n SanBernardo-> 5");
                                rperro = (RazaPerro)(int.Parse(Console.ReadLine()) - 1);
                                Console.WriteLine("Introduce la fecha de nacimiento");
                                fecha = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el peso");
                                loquepesa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el microchip");
                                microchip = Console.ReadLine();
                                Perro nuevo = new Perro(nombre, rperro, fecha, loquepesa, microchip);
                                clinica.InsertaAnimal(nuevo);
                                Console.WriteLine("A continuacion escriba un comentario si lo desea");
                                comentario = Console.ReadLine();
                                clinica.ModificaComentarioAnimal(nombre, comentario);
                                Console.WriteLine("");
                                Console.WriteLine(nuevo);
                                Console.WriteLine("");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Introduce el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Introduce la raza\n Comun-> 1\n Siames-> 2\n Persa->3\n Angora->4\n ScottishFold-> 5");
                                rgato = (RazaGato)(int.Parse(Console.ReadLine()) - 1);
                                Console.WriteLine("Introduce la fecha de nacimiento");
                                fecha = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el peso");
                                loquepesa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el microchip");
                                microchip = Console.ReadLine();
                                Gato nuevo = new Gato(nombre, rgato, fecha, loquepesa, microchip);
                                clinica.InsertaAnimal(nuevo);
                                Console.WriteLine("A continuacion escriba un comentario si lo desea");
                                comentario = Console.ReadLine();
                                clinica.ModificaComentarioAnimal(nombre, comentario);
                                Console.WriteLine("");
                                Console.WriteLine(nuevo);
                                Console.WriteLine("");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Introduce el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Introduce la raza\n Canario-> 1\n Periquito-> 2\n Agapornis->3");
                                epajaro = (EspeciePajaro)(int.Parse(Console.ReadLine()) - 1);
                                Console.WriteLine("Introduce la fecha de nacimiento");
                                fecha = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el peso");
                                loquepesa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce si es cantor(TRUE OR FALSE)");
                                venenosocantor = bool.Parse(Console.ReadLine());
                                Pajaro nuevo = new Pajaro(nombre, epajaro, fecha, loquepesa, venenosocantor);
                                clinica.InsertaAnimal(nuevo);
                                Console.WriteLine("A continuacion escriba un comentario si lo desea");
                                comentario = Console.ReadLine();
                                clinica.ModificaComentarioAnimal(nombre, comentario);
                                Console.WriteLine("");
                                Console.WriteLine(nuevo);
                                Console.WriteLine("");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Introduce el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Introduce la raza\n Tortuga-> 1\n Iguana-> 2\n Dragon de comodo->3");
                                ereptil = (EspecieReptil)(int.Parse(Console.ReadLine()) - 1);
                                Console.WriteLine("Introduce la fecha de nacimiento");
                                fecha = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el peso");
                                loquepesa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce si es venenoso (TRUE OR FALSE)");
                                venenosocantor = bool.Parse(Console.ReadLine());
                                Reptil nuevo = new Reptil(nombre, ereptil, fecha, loquepesa, venenosocantor);
                                clinica.InsertaAnimal(nuevo);
                                Console.WriteLine("A continuacion escriba un comentario si lo desea");
                                comentario = Console.ReadLine();
                                clinica.ModificaComentarioAnimal(nombre, comentario);
                                Console.WriteLine("");
                                Console.WriteLine(nuevo);
                                Console.WriteLine("");
                                break;
                            }
                        default:
                            break;
                    }
                    Console.WriteLine("Desea introducir otra animal ? (TRUE OR FALSE)");
                    pregunta2 = bool.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Desea buscar un animalito en nuestra base de datos ? (TRUE OR FALSE)");
            pregunta = bool.Parse(Console.ReadLine());
            if (pregunta)
            {
                pregunta2 = true;
                while (pregunta2)
                {
                    Console.WriteLine("Introduzca el nombre del animal");
                    nombre = Console.ReadLine();
                    Console.WriteLine(clinica.BuscaAnimal(nombre));
                    Console.WriteLine("desea actualizar el comentario ? (TRUE OR FALSE)");
                    pregunta = bool.Parse(Console.ReadLine());
                    if (pregunta)
                    {
                        Console.WriteLine("Escriba el comentario");
                        comentario = Console.ReadLine();
                        clinica.ModificaComentarioAnimal(nombre, comentario);
                    }
                    Console.WriteLine("Desea buscar otro animalito ? (TRUE OR FALSE)");
                    pregunta2 = bool.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Quieres imprimir la lista con nuestros animalitos(TRUE OR FALSE)");
            pregunta = bool.Parse(Console.ReadLine());
            if (pregunta)
            {
                Console.WriteLine(clinica);
            }

            Console.WriteLine("Gracias por su visita");

            Console.ReadKey();
        }
    }
}
