using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Colas.Clases.ColaLista
{
    class ColaConLista
    {
        public Nodo frente;
        protected Nodo fin;
        public int tm = 0;
        //constructor:crear cola vacia
        public ColaConLista()
        {
            frente = fin = null;
        }


      

        //verificar si la cola esta vacia
        public bool colaVacia()
        {
            return (frente == null);
        }
        //insertar:pone elemento por el final de la cola
        public void insertar(Point elemento)
        {
            Nodo a;
            tm++;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                frente = a;

            }
            else
            {
                fin.siguiente = a;

            }
            fin = a;
        }

        //quitar un elemento
        public Object quitar()
        {
            tm--;
            Object aux;
            if (!colaVacia())
            {
                aux = frente.elemento;
                frente = frente.siguiente;
            }
            else
            {
                throw new Exception("Error pq la cola esta vacia");
            }
            return aux;
        }

        //vaciar la cola o liberar todos los nodos
        public void borrarCola()
        {
            for (; frente != null;)
            {
                frente = frente.siguiente;
            }
        }

        //devolver el valor que esta al frente de la cola
        public Object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error: la cola esta vacia");
            }
            return (frente.elemento);
        }

        public bool Any(Point elemento)
        {
            Nodo n = frente;
           
            bool bandera = false;
            while (n.siguiente != null && !bandera)
            {
                n = n.siguiente;
                if (n.elemento.X == elemento.X && n.elemento.Y == elemento.Y)
                {
                    bandera = true;
                }
            }
            return bandera;
        }


    }
}
