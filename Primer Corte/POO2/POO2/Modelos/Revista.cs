using System;
using POO2.Enums;
using POO2.Interfaces;

namespace POO2.Modelos
{
    public class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public TimeSpan Duracion { get; set; }
        public string Narrador { get; set; }

        public AudioLibro(int id, string titulo, string autor, int año, TipoCategoria categoria, TimeSpan duracion, string narrador)
            : base(id, titulo, autor, año, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(10);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine("=== PRÉSTAMO AUDIOLIBRO ===");
            MostrarInformacion();
            Console.WriteLine($"Duración: {Duracion}");
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int dias)
        {
            return dias * 400;
        }
    }
}