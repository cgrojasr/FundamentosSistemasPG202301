using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Fundamentos.Console
{
    internal class Program
    {
        static Pais[] arregloPaises;

        static int cantidadPaises = 0;

        static void Main(string[] args)
        {
            //var arrColores = new String[10];
            //arrColores[0] = "Yellow";
            //arrColores[1] = "Blue";
            //arrColores[2] = "Red";
            //arrColores[4] = "Green";
            //arrColores[5] = "Green";
            //arrColores[6] = "Green";
            //arrColores[7] = "Brown";
            //arrColores[9] = "Black";

            //var arrAhorro = new decimal[5];

            //var arrRespuestaExamen = new bool[40];


            //System.Console.WriteLine("El primer elemento del arreglo");
            //System.Console.WriteLine(arrColores.First());
            //System.Console.WriteLine(arrColores.ElementAt(4));
            //System.Console.WriteLine("Recorrido de un arreglo");
            //var arrResultado = arrColores.Where(x=>x != null).Where(x => x.Contains("l")).ToArray();
            //for (int i = 0; i < arrResultado.Length; i++) {
            //    System.Console.WriteLine(arrResultado[i]);
            //}

            //System.Console.WriteLine("Ordenamiento del arreglo");
            //var arrOrdenado = arrColores.Where(x => x != null).OrderBy(x => x).ToArray();
            //for (int i = 0; i < arrOrdenado.Length; i++)
            //{
            //    System.Console.WriteLine(arrOrdenado[i]);
            //}

            //System.Console.WriteLine("Eliminando por contenido del dato");
            //arrColores = arrColores.Where(x => x != null && x != "Green").ToArray();
            //for (int i = 0; i < arrColores.Length; i++)
            //{
            //    System.Console.WriteLine(arrColores[i]);
            //}

            //System.Console.WriteLine("Eliminando por índice");
            //arrColores[4] = null;
            //for (int i = 0; i < arrColores.Length; i++)
            //{
            //    System.Console.WriteLine(arrColores[i]);
            //}

            var arrEstudiantes = ListarEstudiantes();
            Imprimir(arrEstudiantes);

            var objNuevoEstudiante = new Estudiante()
            {
                id_estudiante = arrEstudiantes.Count() + 1,
                nombre = "Chiquito Flores",
                fecha_nacimiento = new DateTime(1975, 1, 1),
                matriculado = false
            };

            arrEstudiantes = Registrar(arrEstudiantes, objNuevoEstudiante);
            Imprimir(arrEstudiantes);

            System.Console.ReadLine();

            //Ejercicio resuelto
            //    int largo = 0;



            //    while (largo < 3)

            //    {

            //        System.Console.Write("Ingrese la cantidad de paises que desea agregar al arreglo (minimo 3): ");

            //        String cantidad = System.Console.ReadLine();

            //        largo = int.Parse(cantidad);



            //        if (largo < 3)

            //        {

            //            System.Console.WriteLine("Debe ingresar al menos 3 estudiantes.");

            //        }

            //    }



            //    arregloPaises = new Pais[largo];



            //    for (int i = 0; i < largo; i++)

            //    {

            //        System.Console.WriteLine("Ingrese los detalles del nuevo Pais:");

            //        System.Console.Write("Nombre: ");

            //        string nombre = System.Console.ReadLine();

            //        System.Console.Write("Color de bandera: ");

            //        string colorbandera = System.Console.ReadLine();



            //        AgregarPais(new Pais(nombre, colorbandera));

            //    }



            //    System.Console.WriteLine("\nArreglo de Paises actualizado:");

            //    MostrarPaises();

            //    System.Console.ReadLine();
            //}

        }

            static Estudiante[] ListarEstudiantes()
        {
            var arrEstudiantes = new Estudiante[3];
            var objEstudiante = new Estudiante();
            objEstudiante.id_estudiante = 1;
            objEstudiante.nombre = "Cristiano Ronaldo";
            objEstudiante.fecha_nacimiento = new DateTime(1980, 1, 10);
            objEstudiante.matriculado = true;
            arrEstudiantes[0] = objEstudiante;
            objEstudiante = new Estudiante();
            objEstudiante.id_estudiante = 2;
            objEstudiante.nombre = "Lionel Messi";
            objEstudiante.fecha_nacimiento = new DateTime(1982, 10, 01);
            objEstudiante.matriculado = true;
            arrEstudiantes[1] = objEstudiante;
            objEstudiante = new Estudiante();
            objEstudiante.id_estudiante = 3;
            objEstudiante.nombre = "Waldir Saenz";
            objEstudiante.fecha_nacimiento = new DateTime(1970, 08, 05);
            objEstudiante.matriculado = false;
            arrEstudiantes[2] = objEstudiante;

            return arrEstudiantes;
        }

        static Estudiante[] Registrar(Estudiante[] arrEstudiante, Estudiante objEstudiante)
        {
            //Array.Resize(ref arrEstudiante, arrEstudiante.Count() + 1);
            arrEstudiante = arrEstudiante.Append(objEstudiante).ToArray();
            return arrEstudiante;
        }

        static void Imprimir(Estudiante[] arrEstudiantes)
        {
            for (int i = 0; i < arrEstudiantes.Count(); i++)
            {
                if (arrEstudiantes[i] != null)
                {
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].id_estudiante);
                    System.Console.WriteLine("Nombre: " + arrEstudiantes[i].nombre);
                    System.Console.WriteLine("Fecha de nacimiento: " + arrEstudiantes[i].fecha_nacimiento);
                    System.Console.WriteLine("Estado matricula: " + arrEstudiantes[i].matriculado);
                }
            }
        }

        class Estudiante
        {
            public int id_estudiante { get; set; }
            public string nombre { get; set; }
            public DateTime fecha_nacimiento { get; set; }
            public bool matriculado { get; set; }
        }

        static void AgregarPais(Pais pais)

        {

            if (cantidadPaises < arregloPaises.Length)

            {

                arregloPaises[cantidadPaises] = pais;

                cantidadPaises++;

                System.Console.WriteLine("Pais " + pais.Nombre + " con color de bandera " + pais.Colorbandera + " agregado al arreglo.");

            }

        }



        static void MostrarPaises()

        {

            System.Console.WriteLine("Arreglo de Paises:");

            for (int i = 0; i < cantidadPaises; i++)

            {

                System.Console.WriteLine("Nombre: " + arregloPaises[i].Nombre + " Color de bandera: " + arregloPaises[i].Colorbandera);

            }

        }



        class Pais

        {

            public string Nombre { get; set; }

            public string Colorbandera { get; set; }



            public Pais(string nombre, string colorbandera)

            {

                Nombre = nombre;

                Colorbandera = colorbandera;

            }
        }
    }
}
