using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Colas.Clases.ColaLista
{
    class Nodo
    {
        public Point elemento;
        public Nodo siguiente;
       

        public Nodo(Point x)
        {
            elemento = x;
            siguiente = null;
        }
    }
}
