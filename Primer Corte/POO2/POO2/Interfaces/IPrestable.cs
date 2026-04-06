using System;

namespace POO2.Interfaces
{
    public interface IPrestable
    {
        DateTime CalcularFechaDevolucion();
        void GenerarComprobantePrestamo();
        decimal CalcularMultaPorRetraso(int diasRetraso);
    }
}
