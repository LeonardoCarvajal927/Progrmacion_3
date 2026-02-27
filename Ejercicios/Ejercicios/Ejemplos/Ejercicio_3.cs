using System;

namespace Ejercicios.Ejemplos
{
    public class Ejercicio_3
    {
        public static void Ejecutar()
        {
           
            int aforoMaximo = 50;

            
            Console.Write("¿Cuántas personas hay actualmente dentro?: ");
            int personasActuales = int.Parse(Console.ReadLine());

            
            Console.Write("¿Cuántas personas quieren entrar?: ");
            int personasEntrar = int.Parse(Console.ReadLine());

            
            int espaciosDisponibles = aforoMaximo - personasActuales;

            Console.WriteLine("\n--- RESULTADO ---");

            if (personasEntrar <= espaciosDisponibles)
            {
                Console.WriteLine("Bienvenidos  Hay espacio suficiente para todos.");
            }
            else
            {
                int personasQueDebenSalir = personasEntrar - espaciosDisponibles;

                Console.WriteLine("No hay suficiente cupo ");
                Console.WriteLine("Deben salir " + personasQueDebenSalir +
                                  " persona(s) para que puedan entrar.");
            }
        }
    }
}