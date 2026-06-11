namespace SistemaMovimientoTierra.Models
{
    public class Coordenada
    {
        public int Punto { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Coordenada()
        {
        }

        public Coordenada(int punto, double x, double y, double z)
        {
            Punto = punto;
            X = x;
            Y = y;
            Z = z;
        }
    }
}