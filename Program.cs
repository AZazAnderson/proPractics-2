using System;

namespace Sesion1
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nodo primero = null, ultimo = null;
            int nuevoDato;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el nuevo dato: ");
                nuevoDato = int.Parse(Console.ReadLine());

                insertarNodoAlFinal(ref primero, ref ultimo, nuevoDato);
            }

            mostrarLista(primero);
            
        }
        static void insertarNodoAlFinal(ref Nodo primero, ref Nodo ultimo, int nuevoDato)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = nuevoDato;
            nuevoNodo.siguiente = null;

            if (primero == null)
                primero = nuevoNodo;
            else
                ultimo.siguiente = nuevoNodo;
            ultimo = nuevoNodo;

            Console.Read();
        }

        static void buscarDatoNodo(Nodo primero, int datoBuscado)
        {
            int contador = 0;

            if (primero != null)
            {
                while (primero != null)
                {
                    if (primero.dato == datoBuscado)
                        contador++;
                    primero = primero.siguiente;
                }
            }
            else
                Console.Write("\n La lista enlazada simple no tiene datos.\n");

            if (contador == 0)
                Console.Write("El dato " + datoBuscado + " no fue encontrado en la lista enlazada.");
            else
                Console.Write("El dato " + datoBuscado + " fue encontrado " + contador + " veces en la lista enlazada.");
            Console.Read();
        }


        static void modificarNodo(Nodo primero )
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            bool Encontrado = false;
            Console.Write("Ingrese el dato del nodo Modificar:");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.dato == nodoBuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado", nodoBuscado);

                        Console.Write("Ingresar un nuevo dato para este nodo: ");
                        Actual.dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n nodo modificado\n");

                        Encontrado = true;
                    }
                    Actual = Actual.siguiente;

                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado \n");
                }
            }
            else
            {
                Console.WriteLine("\n La Lista se encuentra vacia\n");
            }
        }

        static void mostrarLista(Nodo primero)
        {
            while (primero != null)
            {
                Console.Write(primero.dato + " -> ");
                primero = primero.siguiente;
            }
            Console.WriteLine("null");
            Console.Read();
        }

    }
   
}