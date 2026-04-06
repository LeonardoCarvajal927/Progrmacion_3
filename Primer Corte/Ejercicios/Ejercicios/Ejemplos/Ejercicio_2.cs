//Calculadora de Propina Solidaria: Pide el total de una cuenta en un restaurante. Pregunta qué porcentaje
//de propina desea dejar (10%, 15% o 20%). Si el total con propina supera los $100.000, muestra un mensaje
//agradeciendo su generosidad.

using System;

namespace Ejercicios.Ejemplos
{
    public class Ejercicio_2
    {
        public static void Ejecutar()
        {
            
            Console.Write("Ingresa el total de la cuenta: ");
            double total = double.Parse(Console.ReadLine());

            
            Console.Write("¿Qué porcentaje de propina deseas dejar? (10%, 15% o 20%): ");
            int porcentaje = int.Parse(Console.ReadLine());

            
            double propina = total * porcentaje / 100;

           
            double totalFinal = total + propina;

            
            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine("Propina: $" + propina);
            Console.WriteLine("Total a pagar: $" + totalFinal);

            
            if (totalFinal > 100000)
            {
                Console.WriteLine("¡Gracias por tu generosidad! ");
            }
        }
    }
}
