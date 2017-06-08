using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosalesMoralesFrancisco_Entornosdedesarrollo.Interfaz;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo.modelos
{
    abstract class Animal : Interfaz.IPesable
    {

        //ATRIBUTOS
        protected String Nombre;
        protected String FechaNacimiento;
        protected double Peso;
        protected String Comentarios;


        //CONSTRUCTOR
        public Animal ()
        {

        }
        public Animal (String Nombre, String FechaNacimiento, double Peso, String Comentarios)
        {
            this.Nombre = Nombre;
            this.FechaNacimiento = FechaNacimiento;
            this.Peso = Peso;
            this.Comentarios = Comentarios;
        }

        public Animal(string fechaNacimiento, double peso, string nombre)
        {
            FechaNacimiento = fechaNacimiento;
            Peso = peso;
            Nombre = nombre;
        }

        //GETTERS AND SETTERS

        protected String _Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        protected String _FechaNacimiento
        {
            get
            {
                return FechaNacimiento;
            }
            set
            {
                FechaNacimiento = value;
            }
        }

        protected double _Peso
        {
            get
            {
                return Peso;
            }
            set
            {
                if (Peso <= 0)
                {
                    throw new Exception("Peso incorrecto");
                }
                Peso = value;
            }
        }

        protected String _Comentarios
        {
            get
            {
                return Comentarios;
            }
            set
            {
                Comentarios = value;
            }
        }

        float IPesable.peso
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        //TOSTRING
        new public String toString()
        {
            return "Animal [nombre=" + Nombre + ", fechaNacimiento=" + FechaNacimiento + ", peso=" + Peso + ", comentarios="
                    + Comentarios + "]";
        }

        void IPesable.pesar(double peso)
        {
            throw new NotImplementedException();
        }
    }
}
