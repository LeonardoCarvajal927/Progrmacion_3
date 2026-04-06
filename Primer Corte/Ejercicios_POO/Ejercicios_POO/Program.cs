using System;
using Ejercicios_POO.Ejemplos;

namespace Ejercicios_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Ejercicio 1. ");
                Console.WriteLine("2. Ejercicio 2. ");
                Console.WriteLine("2. Ejercicio 3. ");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Ejercicio_1.Ejecutar();
                        break;

                    case 2:
                        Ejercicio_2.Ejecutar();
                        break;

                    case 3:
                        Ejercicio_3.Ejecutar();
                        break;

                    case 4:

                        Console.WriteLine("Cerrando programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 3);
        }
    }
}