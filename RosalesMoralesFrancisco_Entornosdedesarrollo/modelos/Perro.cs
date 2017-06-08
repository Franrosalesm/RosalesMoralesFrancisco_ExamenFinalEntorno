using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo.modelos
{
    class Perro : Animal
    {

        //ATRIBUTOS ADICIONALES
        private String raza;
        private String microchip;

        //CONSTRUCTOR
        public Perro(String nombre, String raza, String FechaNacimiento, double peso, String microchip) : base(FechaNacimiento, peso, nombre){

            this.microchip = microchip;
            this.raza = raza;

            }

        public Perro(string Nombre, string FechaNacimiento, double Peso, string Comentarios) : base(Nombre, FechaNacimiento, Peso, Comentarios)
        {
        }

        //Propiedades solo lectura
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
            String p = base.ToString();
            p = p + "Ficha del Perro: Nombre["+Nombre+"], "+"Raza["+raza+"], "+"Fecha de Nacimiento["+FechaNacimiento+"], "
                +"Peso["+Peso+"], "+"Microchip["+microchip+"], "+"Comentarios["+Comentarios+"]" ;

            return p;
        }
    }
}
