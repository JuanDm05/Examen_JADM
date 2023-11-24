using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_JADM
{
    public class Nodo
    {
        public Persona DatosPersona;
        public Nodo Siguiente;

        public Nodo(Persona persona)
        {
            DatosPersona = persona;
            Siguiente = null;
        }
    }
}
