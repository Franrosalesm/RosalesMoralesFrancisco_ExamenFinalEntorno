using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo.modelos
{
    class Pajaro : Animal
    {

        //Atributos adicionales
        private String especie;
        private bool esCantor;
       
        //Constructor
        public Pajaro(String nombre,  bool esCantor, String FechaNacimiento, double peso, String especie) : base(FechaNacimiento, peso, nombre){

            this.esCantor = esCantor;
            this.especie = especie;

        }

        public Pajaro(string Nombre, string FechaNacimiento, double Peso, string Comentarios) : base(Nombre, FechaNacimiento, Peso, Comentarios)
        {
        }

        //Propiedades solo lectura
        public String _especie
        {
            get
            {
                return especie;
            }
        }

        public String _escantor
        {
            get
            {
                return null;
            }
        }



        //TOSTRING

        new public String toString()
        {
            String pa = base.ToString();
            pa = pa + "Ficha del Pájaro: Nombre[" + Nombre + "], " + "Cantor[" + esCantor + "], " + "Fecha de Nacimiento[" + FechaNacimiento + "], "
                + "Peso[" + Peso + "], " + "Especie[" + especie + "], " + "Comentarios[" + Comentarios + "]";

            return pa;
        }
    }
}
