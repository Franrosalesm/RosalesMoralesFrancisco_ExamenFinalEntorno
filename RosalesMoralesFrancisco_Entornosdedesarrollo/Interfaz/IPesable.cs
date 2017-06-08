using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesMoralesFrancisco_Entornosdedesarrollo.Interfaz
{
    //Interfaz que implementa Animal
    interface IPesable 
    {
        float peso { get; set; }
        void pesar(double peso);
    }
}
