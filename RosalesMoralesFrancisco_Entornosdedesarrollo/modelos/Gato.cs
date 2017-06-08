using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo.modelos
{
    class Gato : Animal
    {

        //ATRIBUTOS ADICIONALES
        protected String raza;
        protected String microchip;

        //CONSTRUCTOR
        public Gato(String nombre, String raza, String FechaNacimiento, double peso, String microchip) : base(FechaNacimiento, peso, nombre){

            this.microchip = microchip;
            this.raza = raza;

        }

        public Gato(string Nombre, string FechaNacimiento, double Peso, string Comentarios) : base(Nombre, FechaNacimiento, Peso, Comentarios)
        {
        }

        //PROPIEDADES SOLO LECTURA
        public String _raza
        {
            get
            {
                return raza;
            }
        }

        public String _microchip
        {
            get
            {
                return microchip;
            }
        }

        //TOSTRING

        new public String toString()
        {
            String g = base.ToString();
            g = g + "Ficha del Gato: Nombre[" + Nombre + "], " + "Raza[" + raza + "], " + "Fecha de Nacimiento[" + FechaNacimiento + "], "
                + "Peso[" + Peso + "], " + "Microchip[" + microchip + "], " + "Comentarios[" + Comentarios + "]";

            return g;
        }
    }
}
