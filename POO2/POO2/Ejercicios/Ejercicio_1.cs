using System;
using System.Collections.Generic;
using POO2.Modelos;
using POO2.Enums;
using POO2.Interfaces;

namespace POO2.Ejercicios
{
    public class Ejercicio_1
    {
        static List<IPrestable> materiales = new List<IPrestable>();

        public static void Ejecutar()
        {
            int opcion;

            do
            {
                Console.WriteLine("=== BIBLIOTECA DIGITAL ===");
                Console.WriteLine("1. Agregar Libro");
                Console.WriteLine("2. Agregar Revista");
                Console.WriteLine("3. Agregar AudioLibro");
                Console.WriteLine("4. Mostrar préstamos");
                Console.WriteLine("5. Volver al menú");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        AgregarLibro();
                        break;

                    case 2:
                        AgregarRevista();
                        break;

                    case 3:
                        AgregarAudioLibro();
                        break;

                    case 4:
                        MostrarMateriales();
                        break;
                }

            } while (opcion != 5);
        }

        static void AgregarLibro()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine("Categoría:");
            Console.WriteLine("0 Ficcion");
            Console.WriteLine("1 NoFiccion");
            Console.WriteLine("2 Ciencia");
            Console.WriteLine("3 Historia");
            Console.WriteLine("4 Tecnologia");

            TipoCategoria categoria = (TipoCategoria)int.Parse(Console.ReadLine());

            Console.Write("Número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();

            materiales.Add(new Libro(id, titulo, autor, año, categoria, paginas, isbn));

            Console.WriteLine("Libro agregado correctamente.");
        }

        static void AgregarRevista()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Categoría (0-4): ");
            TipoCategoria categoria = (TipoCategoria)int.Parse(Console.ReadLine());

            Console.Write("Número de edición: ");
            int edicion = int.Parse(Console.ReadLine());

            Console.Write("Periodicidad: ");
            string periodicidad = Console.ReadLine();

            materiales.Add(new Revista(id, titulo, autor, año, categoria, edicion, periodicidad));

            Console.WriteLine("Revista agregada correctamente.");
        }

        static void AgregarAudioLibro()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Categoría (0-4): ");
            TipoCategoria categoria = (TipoCategoria)int.Parse(Console.ReadLine());

            Console.Write("Duración en horas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Narrador: ");
            string narrador = Console.ReadLine();

            materiales.Add(new AudioLibro(id, titulo, autor, año, categoria, TimeSpan.FromHours(horas), narrador));

            Console.WriteLine("AudioLibro agregado correctamente.");
        }

        static void MostrarMateriales()
        {
            Console.WriteLine("=== LISTA DE MATERIALES ===");

            foreach (var item in materiales)
            {
                item.GenerarComprobantePrestamo();
                Console.WriteLine("-------------------------");
            }
        }
    }
}