//Calculadora de Calificaciones (Clase Estudiante)

using System;

namespace Ejercicios_POO.Ejemplos
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double[] Notas { get; set; }

        public Estudiante(string nombre, string materia, double[] notas)
        {
            Nombre = nombre;
            Materia = materia;
            Notas = notas;
        }

        public double CalcularPromedio()
        {
            double suma = 0;

            for (int i = 0; i < Notas.Length; i++)
            {
                suma += Notas[i];
            }

            return suma / Notas.Length;
        }

        public string EstadoFinal()
        {
            double promedio = CalcularPromedio();

            if (promedio >= 3.0)
                return "Aprobado";
            else
                return "Reprobado";
        }
    }

    public class Ejercicio_3
    {
        public static void Ejecutar()
        {

            Console.Write("Calculadora de Calificaciones\n");

            Console.Write("\nNombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Materia: ");
            string materia = Console.ReadLine();

            double[] notas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese la nota del parcial " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            Estudiante estudiante = new Estudiante(nombre, materia, notas);

            double promedio = estudiante.CalcularPromedio();
            string estado = estudiante.EstadoFinal();

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine("Estudiante: " + estudiante.Nombre);
            Console.WriteLine("Materia: " + estudiante.Materia);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Estado final: " + estado);
        }
    }
}