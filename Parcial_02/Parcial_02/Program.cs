using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada de datos
        Console.Write("Monto de la vivienda: ");
        double monto = double.Parse(Console.ReadLine()!);

        Console.Write("Interes mensual (%): ");
        double interes = double.Parse(Console.ReadLine()!) / 100;

        Console.Write("Plazo en meses: ");
        int meses = int.Parse(Console.ReadLine()!);

        // Cálculo de la cuota mensual
        double cuota = monto * (interes * Math.Pow(1 + interes, meses)) / (Math.Pow(1 + interes, meses) - 1);

        // Variables de control
        double saldo = monto;
        double totalPagado = 0;
        double totalIntereses = 0;

        // Fecha actual
        DateTime fecha = DateTime.Now;

        Console.WriteLine("\n--Tabla de Pagos--\n");

        // Ciclo para generar la tabla mes a mes
        for (int i = 1; i <= meses; i++)
        {
            // Cálculo de interés y capital del mes
            double interesMes = saldo * interes;
            double capital = cuota - interesMes;

            // Ajuste en el último mes para evitar errores de decimales
            if (i == meses)
            {
                capital = saldo;
                cuota = capital + interesMes;
            }

            // Actualizar saldo y acumulados
            saldo -= capital;
            totalPagado += cuota;
            totalIntereses += interesMes;

            // Mostrar información del mes
            Console.WriteLine($"Mes {i} | {fecha.AddMonths(i).ToShortDateString()}" +
                $" | Cap: ${Math.Round(capital, 2)} | Int: ${Math.Round(interesMes, 2)} " +
                $"| Saldo: ${Math.Round(saldo, 2)}");
        }

        // Mostrar resumen final
        Console.WriteLine("\n---Resumen---\n");
        Console.WriteLine($"Total Pagado: ${Math.Round(totalPagado, 2)}" +
            $" | Intereses: ${Math.Round(totalIntereses, 2)}");
    }
}