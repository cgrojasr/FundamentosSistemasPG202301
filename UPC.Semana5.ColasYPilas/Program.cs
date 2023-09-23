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
            //Pilas();
            u202019858();
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
            libros.Push("Cien años de soledadd");
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

        public class Paciente_u202019858
        {
            public int id_paciente { get; set; }
            public string nombre { get; set; }
            public int edad { get; set; }
        }
        static void u202019858(){
            var pacientes = new Queue<Paciente_u202019858>();
            while (true){
                Console.Clear();
                Console.WriteLine("1.- Agregar paciente");
                Console.WriteLine("2.- Atender paciente");
                Console.WriteLine("3.- Salir");
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.Write("Opcion: "); int op= int.Parse(Console.ReadLine());

                //Agregar
                if (op==1){
                    var paciente = new Paciente_u202019858();
                    Console.WriteLine("-------------------------------");
                    Console.Write("Nombre: "); paciente.nombre = Console.ReadLine();
                    Console.Write("Edad: "); paciente.edad = int.Parse(Console.ReadLine());
                    paciente.id_paciente = pacientes.Count()+1;
                    pacientes.Enqueue(paciente);
                }
                //Atender
                else if (op == 2){
                    Console.WriteLine("-------------------------------");
                    ///---
                    pacientes = new Queue<Paciente_u202019858>(pacientes.OrderByDescending(paciente => paciente.edad));
                    ///---
                    while (pacientes.Count > 0){
                        var paciente = pacientes.Dequeue();
                        Console.WriteLine("Id: " + paciente.id_paciente+", Paciente: " +paciente.nombre+ ", Edad: " + paciente.edad);
                    }
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Presione una tecla para continuar . . .");Console.ReadKey();
                }
                //Salir
                else if (op == 3){
                    break;
                }
            }
        }
    }
}
