using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Semana5.ColasYPilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Colas();
            Pilas();
        }

        static void Colas() {
            //Cola
            Queue<string> cola_personas = new Queue<string>();
            cola_personas.Enqueue("Genaro");
            cola_personas.Enqueue("Juanito");
            cola_personas.Enqueue("Ronaldo");

            cola_personas.Clear();
            Console.WriteLine(cola_personas.Count);

            cola_personas.Enqueue("Genaro");
            cola_personas.Enqueue("Juanito");
            cola_personas.Enqueue("Ronaldo");
            Console.WriteLine(cola_personas.Peek());
            Console.WriteLine(cola_personas.Contains("Ronaldo"));

            Console.WriteLine("Inicio de Skip");
            var cola_prueba = cola_personas.Skip(2);
            Console.WriteLine(cola_prueba.Count());
            for (int i = 0; cola_prueba.Count() > i; i++)
            {
                //Console.WriteLine(cola_personas.Dequeue());
                Console.WriteLine(cola_prueba.ToList()[i]);
            }
            Console.WriteLine("Final de Skip");

            while (cola_personas.Count > 0)
            {
                Console.WriteLine(cola_personas.Dequeue());
            }

            Console.ReadLine();
        }

        static void Pilas() { 
            Stack<string> libros = new Stack<string>();
            libros.Push("Cien años de soledad");
            libros.Push("La historia de la corrupción en el Perú");
            libros.Push("La biblia");

            Console.WriteLine(libros.Peek());

            while (libros.Count > 0)
            {
                Console.WriteLine(libros.Pop());
            }            

            Console.ReadLine();            
        }

        //Programar un sistema de colas que permita a los usuarios tener un orden de espera 
        //Considerar que los adultos mayores tienen prioridad y deben ser atentidos lo más pronto posible
        //Los datos que debemos almacenar son id_paciente y su nombre 
        //PROHIBIDO USAR ARREGLOS Y LISTAS

        static void u812125() { 
        }
    }
}
