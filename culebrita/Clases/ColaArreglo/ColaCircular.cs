using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaCircular
    {
        public int fin;
        private static int MAXTAMQ = 99;
        protected int frente;

        protected object[] listaCola;

        //avanza una posicion
        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }
        //constructor
        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new object[MAXTAMQ];
        }
        public bool colaVacia()
        {
            return frente ==siguiente(fin);
        }
        public bool colaLLena()
        {
            return fin == siguiente(siguiente(fin));
        }
        //operaciones de modificacion de cola
        public void insertar(object elemento)
        {
            if (!colaLLena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        public object quitar()
        {
            if (!colaVacia())
            {
                object tm = listaCola[frente];
                frente = siguiente(frente);
                return tm;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        public void borrarCola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        public object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }


        
    }
}
