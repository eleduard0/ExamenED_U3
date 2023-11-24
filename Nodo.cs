using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenED_U3
{
    public class Nodo
    {
        private Nodo _Siguiente;
        private Persona _DatosPersona;

        public Nodo Siguiente { get => _Siguiente; set => _Siguiente = value; }
        public Persona DatosPersona { get => _DatosPersona; set => _DatosPersona = value; }

        public Nodo()
        {
            Siguiente = null;
            
        }
    }
}
