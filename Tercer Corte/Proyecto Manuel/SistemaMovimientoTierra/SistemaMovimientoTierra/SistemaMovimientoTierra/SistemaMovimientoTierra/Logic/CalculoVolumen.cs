using System;

namespace SistemaMovimientoTierra.Logic
{
    // Este enum define los métodos disponibles para calcular el volumen.
    // En el formulario el usuario escogerá uno de estos tres métodos.
    public enum MetodoCalculo
    {
        Simpson2D = 0,
        Trapecio2D = 1,
        Prismas = 2
    }

    public static class CalculoVolumen
    {
        /*
         VARIABLES PRINCIPALES:

         alturas:
         Matriz de alturas del terreno.
         Cada posición representa una elevación medida en un punto del terreno.

         h:
         Altura del plano de corte o nivel de referencia.
         Solo se calcula volumen cuando la altura del terreno está por encima de h.

         dx:
         Distancia horizontal entre puntos de la matriz en el eje X.

         dy:
         Distancia horizontal entre puntos de la matriz en el eje Y.

         metodo:
         Método numérico seleccionado por el usuario:
         Simpson 2D, Trapecio 2D o Prismas.
        */

        public static double Calcular(double[,] alturas, double h, double dx, double dy, MetodoCalculo metodo)
        {
            switch (metodo)
            {
                case MetodoCalculo.Simpson2D:
                    return Simpson(alturas, h, dx, dy);

                case MetodoCalculo.Trapecio2D:
                    return Trapecio(alturas, h, dx, dy);

                case MetodoCalculo.Prismas:
                    return Prismas(alturas, h, dx, dy);

                default:
                    throw new ArgumentException("Método de cálculo no reconocido.");
            }
        }

        // ============================================================
        // MÉTODO DE PRISMAS
        // ============================================================
        // Este método recorre cada celda de la matriz.
        // Cada celda se forma con cuatro puntos o esquinas.
        // Calcula la altura sobre el plano h en cada esquina,
        // saca el promedio y lo multiplica por el área dx * dy.
        //
        // Volumen por celda:
        // promedio de alturas positivas * área de la celda
        // ============================================================
        private static double Prismas(double[,] z, double h, double dx, double dy)
        {
            int filas = z.GetLength(0);
            int cols = z.GetLength(1);

            double volumen = 0;

            for (int i = 0; i < filas - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    double d00 = Math.Max(z[i, j] - h, 0);
                    double d10 = Math.Max(z[i, j + 1] - h, 0);
                    double d01 = Math.Max(z[i + 1, j] - h, 0);
                    double d11 = Math.Max(z[i + 1, j + 1] - h, 0);

                    volumen += (d00 + d10 + d01 + d11) / 4.0 * dx * dy;
                }
            }

            return volumen;
        }

        // ============================================================
        // REGLA DEL TRAPECIO 2D
        // ============================================================
        // Este método usa todos los nodos de la matriz.
        // Cada nodo recibe un peso según su posición:
        //
        // Esquina  -> peso 0.25
        // Borde    -> peso 0.50
        // Interior -> peso 1.00
        //
        // Luego suma:
        // peso * altura positiva sobre h * dx * dy
        // ============================================================
        private static double Trapecio(double[,] z, double h, double dx, double dy)
        {
            int filas = z.GetLength(0);
            int cols = z.GetLength(1);

            double volumen = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double diferencia = z[i, j] - h;

                    if (diferencia <= 0)
                    {
                        continue;
                    }

                    bool estaEnBordeFila = i == 0 || i == filas - 1;
                    bool estaEnBordeColumna = j == 0 || j == cols - 1;

                    double peso;

                    if (estaEnBordeFila && estaEnBordeColumna)
                    {
                        peso = 0.25; // Esquina
                    }
                    else if (estaEnBordeFila || estaEnBordeColumna)
                    {
                        peso = 0.50; // Borde
                    }
                    else
                    {
                        peso = 1.00; // Interior
                    }

                    volumen += peso * diferencia * dx * dy;
                }
            }

            return volumen;
        }

        // ============================================================
        // REGLA DE SIMPSON 2D
        // ============================================================
        // Este método es más preciso porque usa pesos de Simpson:
        //
        // 1, 4, 2, 4, 2, ..., 4, 1
        //
        // Simpson requiere mínimo 3 filas y 3 columnas.
        // Además, trabaja mejor con número impar de filas y columnas.
        // Si el usuario ingresa número par, el método usa internamente
        // una fila o columna menos para cumplir la condición.
        // ============================================================
        private static double Simpson(double[,] z, double h, double dx, double dy)
        {
            int filas = z.GetLength(0);
            int cols = z.GetLength(1);

            if (filas < 3 || cols < 3)
            {
                throw new ArgumentException("Simpson 2D requiere mínimo una matriz de 3x3.");
            }

            // Simpson necesita número impar de nodos.
            // Si filas o columnas son pares, se usa una menos.
            int filasUsadas = filas % 2 == 1 ? filas : filas - 1;
            int columnasUsadas = cols % 2 == 1 ? cols : cols - 1;

            double suma = 0;

            for (int i = 0; i < filasUsadas; i++)
            {
                double pesoFila = ObtenerPesoSimpson(i, filasUsadas);

                for (int j = 0; j < columnasUsadas; j++)
                {
                    double pesoColumna = ObtenerPesoSimpson(j, columnasUsadas);
                    double diferencia = z[i, j] - h;

                    if (diferencia > 0)
                    {
                        suma += pesoFila * pesoColumna * diferencia;
                    }
                }
            }

            // Factor de escala Simpson 2D:
            // (dx / 3) * (dy / 3) = dx * dy / 9
            return suma * dx * dy / 9.0;
        }

        private static double ObtenerPesoSimpson(int posicion, int totalNodos)
        {
            if (posicion == 0 || posicion == totalNodos - 1)
            {
                return 1.0;
            }

            if (posicion % 2 == 1)
            {
                return 4.0;
            }

            return 2.0;
        }
    }
}