using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo.modelos
{
    class Reptil : Animal
    {
        //ATRIBUTOS ADICIONALES
        private String especie;
        private bool venenoso=false;

        public Reptil(string Nombre, string FechaNacimiento, double Peso, string Comentarios) : base(Nombre, FechaNacimiento, Peso, Comentarios)
        {
        }

        //CONSTRUCTOR
        public Reptil(String nombre, String especie, String FechaNacimiento, double peso, bool venenoso) : base(FechaNacimiento, peso, nombre){

            this.especie = especie;
            this.venenoso = venenoso;

        }

        

        //PROPIEDADES SOLO LECTURA
        public String _especie
        {
            get
            {
                return especie;
            }
        }

        public String _venenoso
        {
            get
            {
                return null;
            }
        }

        //TOSTRING

        new public String toString()
        {
            String r = base.ToString();
            r = r + "Ficha del Reptil: Nombre[" + Nombre + "], " + "Venenoso[" + venenoso + "], " + "Fecha de Nacimiento[" + FechaNacimiento + "], "
                + "Peso[" + Peso + "], " + "Especie[" + especie + "], " + "Comentarios[" + Comentarios + "]";

            return r;
        }
    }
}
