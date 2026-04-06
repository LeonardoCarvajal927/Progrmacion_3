//Generador de Correos Corporativos: Pide al usuario su nombre y apellido. El programa debe generar un correo 
//con el formato nombre.apellido@empresa.com (todo en minúsculas).

using System;

namespace Ejercicios.Ejemplos
{
    public class Ejercicio_4
    {
        public static void Ejecutar()
        {
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine().ToLower();

            Console.Write("Ingresa tu apellido: ");
            string apellido = Console.ReadLine().ToLower();

            string correo = nombre + "." + apellido + "@empresa.com";

            Console.WriteLine("\nCorreo generado:");
            Console.WriteLine(correo);
        }
    }
}