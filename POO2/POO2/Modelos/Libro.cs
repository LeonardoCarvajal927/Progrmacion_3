using System;
using POO2.Enums;
using POO2.Interfaces;

namespace POO2.Modelos
{
    public class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public string ISBN { get; set; }

        public Libro(int id, string titulo, string autor, int año, TipoCategoria categoria, int paginas, string isbn)
            : base(id, titulo, autor, año, categoria)
        {
            NumeroPaginas = paginas;
            ISBN = isbn;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(15);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine("=== PRÉSTAMO LIBRO ===");
            MostrarInformacion();
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Páginas: {NumeroPaginas}");
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int dias)
        {
            return dias * 500;
        }
    }
}