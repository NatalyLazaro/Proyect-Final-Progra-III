using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.Pila_Lista
{
    class PilaLista
    {
        private static int INICIAL = 19;
        private int cima;
        private List<object> listaPila;

        public PilaLista()
        {
            cima = -1;
            listaPila = new List<object>();
        }

        public void insertar(object elemento)
        {
            cima++;
            listaPila.Add(elemento);
        }

        public object quitar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            else
            {
                aux = listaPila[cima];
                listaPila.RemoveAt(cima);
                cima--;
                return aux;
            }
        }

        public object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia, No se puede sacar elemento");

            }
            return listaPila[cima];
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }
    }
}
