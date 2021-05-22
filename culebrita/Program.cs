using Colas.Clases.BicolaEnlazada;
using Colas.Clases.ColaArreglo;
using Colas.Clases.ColaLista;
using culebrita.Snake;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace culebrita
{
    class Program
    {

        //convertirlo en un programa orietado a objetos - Listo
        //emitir beep cuando coma la comida - Listo
        //incrementar la velocidad conforme vaya avanzando
        //modificar el uso de queue y reemplazarlo con cada una de las estructuras de de cola vista en clase - Listo
        //Elaborar Video explicando el funcionamiento del código y del programa.
        static void Main()
        {
            SnakeColaCircular cirular = new SnakeColaCircular();
            SnakeBicola bicola = new SnakeBicola();
            SnakeColaConLista conLista = new SnakeColaConLista();
            SnakeColaLineal lineal = new SnakeColaLineal();
            //bicola.Game();
            //cirular.Game();
            //conLista.Game();
            //lineal.Game();

            Console.WriteLine("\t\tBIENVENIDO A SNAKE\n");
            Console.WriteLine("Un juego que trae recuerdos de nuestra infancia");
            Console.WriteLine("Sus controles son los botones de Flechas\n");
            Console.WriteLine("Puede Elegir el tipo de estructura a Utilizar");
            Console.WriteLine("1.Bicola");
            Console.WriteLine("2.Cola Con Lista");
            Console.WriteLine("3.Cola Circular");
            Console.WriteLine("4.Cola Lineal");
            Console.WriteLine("Escriba el numero de su obción");
            int opcion = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        bicola.Game(); break;
                    case 2:
                        Console.Clear();
                        conLista.Game(); break;
                    case 3:
                        Console.Clear();
                        cirular.Game(); break;
                    case 4:
                        Console.Clear();
                        lineal.Game(); break;
                    default:
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                }
            } while (opcion <= 4);
        }
    }//end class
}




