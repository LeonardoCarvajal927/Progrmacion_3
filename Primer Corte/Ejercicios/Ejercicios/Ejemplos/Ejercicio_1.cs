//Perfil de Usuario Gamer: Crea un programa que pida al usuario su Nickname, nivel de experiencia (1-100)
//y si tiene suscripción Premium (booleano). Al final, muestra un mensaje personalizado que le
//dé la bienvenida a su nivel correspondiente.

using System;

namespace Ejercicios.Ejemplos
{
    public class Ejercicio_1
    {
        public static void Ejecutar()
        {
            Console.Write("Ingresa tu nombre de jugador: ");
            string name = Console.ReadLine();

            Console.Write("Ingresa tu nivel de experiencia (1-100): ");
            int nivel = int.Parse(Console.ReadLine());

            Console.Write("¿Tienes suscripción Premium? (true/false): ");
            bool premium = bool.Parse(Console.ReadLine());

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine("Bienvenido " + name +
                              ", tu nivel es " + nivel + ".");

            if (premium)
            {
                Console.WriteLine("Eres usuario PREMIUM ¡Disfruta tus beneficios!");
            }
            else
            {
                Console.WriteLine("Usuario estándar. ¡Sigue subiendo de nivel!");
            }
        }
    }
}