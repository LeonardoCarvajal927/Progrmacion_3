//Simulador de Semáforo Inteligente: Pide al usuario que ingrese el color actual del semáforo 
//(Verde, Amarillo, Rojo). Si es verde, imprime "Sigue adelante"; si es amarillo, "Prepárate para frenar"; y si es rojo, 
//"¡Detente!".

using System;

namespace Ejercicios.Ejemplos
{
    public class Ejercicio_5
    {
        public static void Ejecutar()
        {
            Console.Write("Ingresa el color del semáforo (Verde, Amarillo, Rojo): ");
            string color = Console.ReadLine().ToLower();

            if (color == "verde")
            {
                Console.WriteLine("Sigue adelante");
            }
            else if (color == "amarillo")
            {
                Console.WriteLine("Prepárate para frenar");
            }
            else if (color == "rojo")
            {
                Console.WriteLine("¡Detente!");
            }
            else
            {
                Console.WriteLine("Color no válido");
            }
        }
    }
}
