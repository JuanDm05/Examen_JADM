using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_JADM
{
    public class Listas
    {
        public Nodo Principal;
        public Nodo Ultimo;

        public Listas()
        {
            Principal = null;
            Ultimo = null;
        }

        public void InsertarPersona(Persona persona)
        {
            Nodo Nuevo = new Nodo(persona);
            if (Principal == null)
            {
                Principal = Nuevo;
                Principal.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;

            }
        }
        public void MostrarPersona()
        {
            Nodo Actual = Principal;
            if (Principal != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine($"El nombre de la persona es {Actual.DatosPersona.nombre} Y tiene {Actual.DatosPersona.edad} años");
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
        public void EncontrarPersona(string nombre, int edad)
        {
            Nodo Actual = Principal;
            bool encontrado = false;
            if (Principal != null) 
            {
                while(Actual!= null && encontrado!= true)
                {
                    if(Actual.DatosPersona.nombre == nombre && Actual.DatosPersona.edad == edad)
                    {
                        Console.WriteLine("La persona {0} con edad {1} si se encontro en esta lista ", nombre, edad);
                    encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("La persona no esta en esta lista ");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
        public void ordenar()
        {
          
            if(Principal == null )
            {
                Console.WriteLine("Lista vacia");
            }
            else { 
            Nodo Actual = Principal;
            while(Actual != null)
            {
                Nodo Siguiente = Actual.Siguiente;
                while(Siguiente != null)
                {
                    if(Actual.DatosPersona.edad > Siguiente.DatosPersona.edad)
                    {
                        Persona temp = Siguiente.DatosPersona;
                        Siguiente.DatosPersona = Actual.DatosPersona;
                        Actual.DatosPersona = temp;


                    }
                    Siguiente = Siguiente.Siguiente;

                }
                Actual= Actual.Siguiente;
            }
            MostrarPersona();
            }
        }

    }    
}

