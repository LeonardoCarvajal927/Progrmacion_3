using System;
using POO2.Ejercicios;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Sistema Biblioteca Digital");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Ejercicio_1.Ejecutar();
                        break;

                    case 2:
                        Console.WriteLine("Ejercicio 2 no implementado.");
                        break;

                    case 3:
                        Console.WriteLine("Ejercicio 3 no implementado.");
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 4);
        }
    }
}