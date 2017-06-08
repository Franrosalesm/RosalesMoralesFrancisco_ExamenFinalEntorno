using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo.modelos
{
    class ClinicaVeterinaria
    {
        //ATRIBUTOS
        private List<Animal> ListaAnimales;

        //CONSTRUCTORES
        public ClinicaVeterinaria()
        {
            this.ListaAnimales = new List<Animal>();
        }

        //METODOS
        public void AñadirAnimal()
        {

            int elegir = 0;
            do
            {
                elegir = MostrarMenuAnimales();
            }
            while (elegir < 1 && elegir > 5);

            String Nombre, fechaNacimiento, comentarios;
            double peso = 0;


            Console.WriteLine("Nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento: ");
            fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Peso: ");
            peso = Console.Read();
            Console.WriteLine("Comentarios: ");
            comentarios = Console.ReadLine();



            switch (elegir)
            {
                case 1:
                    Animal perro = new Perro(Nombre, fechaNacimiento, peso, comentarios);
                    añadiralista(perro);
                    break;

                case 2:
                    Animal reptil = new Reptil(Nombre, fechaNacimiento, peso, comentarios);
                    añadiralista(reptil);
                    break;
                case 3:
                    Animal gato = new Gato(Nombre, fechaNacimiento, peso, comentarios);
                    añadiralista(gato);
                    break;
                case 4:
                    Animal pajaro = new Pajaro(Nombre, fechaNacimiento, peso, comentarios);
                    añadiralista(pajaro);
                    break;
                case 5:
                    Console.WriteLine("Ha elegido salir del programa");
                    break;
                default:
                    Console.WriteLine("[ERROR] Opción no válida.");
                    break;

            }
        }

        private int MostrarMenuAnimales()
        {
            Console.WriteLine("/** SUBMENU - Animales **/");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Reptil");
            Console.WriteLine("3. Gato");
            Console.WriteLine("4. Pájaro");

            Console.WriteLine("5. Ninguna de las anteriores opciones!");

            Console.WriteLine("¿Qué desea crear?: ");
            return Console.Read();
        }

        private void añadiralista(Animal a)
        {
            if (!this.ListaAnimales.Contains(a))
            {
                this.ListaAnimales.Add(a);
            }
            else
            {
                Console.WriteLine("[ERROR] El animal ya está añadido!");
            }

        }

        //TOSTRING
        

        new public String toString(List<Animal> listaAnimales)
        {

            Console.WriteLine(listaAnimales);
            return null;

        }
    }
}
