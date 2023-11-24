using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenED_U3
{
    public class ListaEnlazada
    {
        public Nodo inicio;

        public bool ListaVacia()
        {
            return inicio == null;
        }
        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacia");
                return;
            }
            Nodo actual = inicio;
            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.DatosPersona.Nombre} Edad: {actual.DatosPersona.Edad}");
                actual = actual.Siguiente;
            }
        }

        public void InsertarAlFinal(Persona persona)
        {
            Nodo nuevoNodo = new Nodo() { DatosPersona = persona };
            if (ListaVacia())
            {
                nuevoNodo.Siguiente = inicio;
                inicio = nuevoNodo;
                
            }
            Nodo actual = inicio;
            while (actual != null)
            {
                actual = actual.Siguiente;
                inicio.Siguiente = actual;

            }
            inicio = nuevoNodo;
        }


    }
}
