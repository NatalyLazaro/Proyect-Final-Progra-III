using Colas.Clases.ColaLista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Colas.Clases.BicolaEnlazada
{
    class Bicola:ColaConLista
    {
        //insertar por el final

        public void ponerFinal(object elemento)
        {
            insertar((Point)elemento);
        }

        public void ponerFrente(object elemento)
        {
            Nodo a;
            a = new Nodo((Point)elemento);
            if (colaVacia())
            {
                fin = a;
            }
            a.siguiente = frente;
            frente = a;
        }

        public object quitarFrente()
        {
            return quitar();
        }

        //retirar elemento al final
        //metodo propio de bicola
        //es necesario hacer una iteracion de la bicola para
        //llegar del nodo anterior al final,para despues enlazar
        //y ajustar la cola
        public object quitarFinal()
        {
            object aux;
            if (!colaVacia())
            {
                if (frente == fin)//la bicola solo tiene un nodo
                {
                    aux = quitar();
                }
                else
                {
                    //como no tiene elementos vamos a iterar
                    Nodo a = frente;
                    while (a.siguiente != fin)
                    {
                        a = a.siguiente;
                    }
                    //siguiente del nodo anterior lo vamos a poner en null
                    a.siguiente = null;
                    aux = fin.elemento;
                    fin = a;
                }
            }
            else
            {
                throw new Exception("La cola esta vacia");
            }
            return aux;
        }

        //retorna el valor que se encuentra en el primer elemento de la cola
        public object frenteBicola()
        {
            return frenteCola();
        }
        //devolver el final de la cola
        public object finalBicola()
        {
            if (colaVacia())
            {
                throw new Exception("Cola Vacia");
            }
            return (fin.elemento);
        }

        //retorna si esta vacia la cola
        public bool bicolaVacia()
        {
            return colaVacia();
        }

        //borrar la bicola
        public void BorrarBicola()
        {
            borrarCola();
        }
        //conecto de elementos
        public int numElementosBicola()
        {
            int n;
            Nodo a = frente;
            if (bicolaVacia())
            {
                n = 0;
            }
            else
            {
                n = 1;
                while (a != fin)
                {
                    n++;
                    a = a.siguiente;
                }
            }
            return n;
        }


    }
}
