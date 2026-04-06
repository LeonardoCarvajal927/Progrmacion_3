using System;
using POO2.BibliotecaDigital.Enums;
using POO2.BibliotecaDigital.Interfaces;

namespace POO2.BibliotecaDigital.Modelos
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
            Console.WriteLine("Comprobante de préstamo de audiolibro");
            MostrarInformacion();
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 400;
        }
    }
}