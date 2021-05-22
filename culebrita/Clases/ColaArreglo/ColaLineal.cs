using Colas.Clases.ColaLista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 500;
        protected int frente;

        protected object[] ListaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            ListaCola = new object[MAXTAMQ];
        }

        public int numElementos()
        {
            int cant = 0;
            for (int i=0; i < MAXTAMQ; i++)
            {
                if (ListaCola[cant] != null)
                {
                    cant++;
                }
                else
                {
                    i = MAXTAMQ;
                }
            }
            return cant;
        }
        public bool colaVacia()
        {
            return frente > fin;
        }
        public bool colaLLena()
        {
            return fin == MAXTAMQ - 1;
        }
        //operaciones para trabajar con datos en la cola
        public void insertar(object elemento)
        {
            if (!colaLLena())
            {
                ListaCola[++fin] = elemento;
            }
            else
            {
                ListaCola[frente] = elemento;
                //throw new Exception("Overflow de la cola");
            }
        }
        /*
        public object FinalCola()
        {
            return ListaCola[fin];
        }
*/
        public object quitar()
        {
            if (!colaVacia())
            {
                return ListaCola[frente++];
                
            }
            else
            {
                throw new Exception("cola Vacia");
            }
        }
        //limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin= - 1;
        }

    
        //acceso a la cola
        public object frenteCola()
        {
            if (!colaVacia())
            {
                return ListaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }
    }
}
