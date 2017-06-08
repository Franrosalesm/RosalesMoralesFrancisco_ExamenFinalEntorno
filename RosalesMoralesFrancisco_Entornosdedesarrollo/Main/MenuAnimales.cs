using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atributo al que se le asigna el número de elección de menú
            int hola;
            //Menu de opciones de cambio de animales

            Console.WriteLine("Bienvenido a la Clínica Veterinaria!!!");
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine("Elige una de las siguientes opciones");
            Console.WriteLine();

            do
            {
                hola = mostrarMenu();
                elegirOpcion(hola);

            } while (hola!=5);
        }

        public static int mostrarMenu()
        {
            Console.WriteLine("/** MENU **/");
            Console.WriteLine("1. Añadir animales de los diferentes tipos ");
            Console.WriteLine("2. Modificar los comentarios");
            Console.WriteLine("3. Pesar Animal");
            Console.WriteLine("4. Mostrar por pantalla la ficha de un animal");

            Console.WriteLine("¿Qué desea hacer?: ");

            return Console.Read();

        }
        public static void elegirOpcion(int hola)
        {
            modelos.ClinicaVeterinaria t = new modelos.ClinicaVeterinaria(); //Llamamos a la clase ClinicaVeterinaria
            //Dependiendo del dato introducido, realizará una u otra función de la Clinica Veterinaria
            switch (hola)
            {
                
                case 1:
                    t.AñadirAnimal();
                    break;
                case 2:
                    modelos.Animal a = null;
                    String nombre = null;
                    String comentarios = null;

                    break;
                case 3:
                   break;
                case 4:
                    t.ToString();

                    break;
                case 5:
                    Console.WriteLine("Fuera del menú");
                    break;
                default:
                    Console.WriteLine("[ERROR] Opción no válida.");
                    break;

            }

        }
    }
}
