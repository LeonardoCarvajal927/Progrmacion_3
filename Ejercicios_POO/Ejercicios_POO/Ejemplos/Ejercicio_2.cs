//Control de Inventario (Clase Producto)

using System;

namespace Ejercicios_POO.Ejemplos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }

        public Producto(string nombre, string codigo, decimal precio, int stockInicial)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            CantidadStock = stockInicial;
        }

        public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadStock += cantidad;
                Console.WriteLine("Stock agregado correctamente.");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser mayor a 0.");
            }
        }

        public decimal VenderProducto(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a 0.");
                return 0;
            }

            if (cantidad > CantidadStock)
            {
                Console.WriteLine("No hay suficiente stock disponible.");
                return 0;
            }

            CantidadStock -= cantidad;
            decimal totalVenta = Precio * cantidad;

            Console.WriteLine("Venta realizada correctamente.");
            return totalVenta;
        }

        public void MostrarInfo()
        {

            Console.WriteLine("Control de Inventario \n ");
            Console.WriteLine("\n--- Información del Producto ---");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Precio: $" + Precio);
            Console.WriteLine("Stock actual: " + CantidadStock);
        }
    }

    public class Ejercicio_2
    {
        public static void Ejecutar()
        {
            Console.Write("Control de Invenario\n");

            Console.Write("\nNombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Código del producto: ");
            string codigo = Console.ReadLine();

            Console.Write("Precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Stock inicial: ");
            int stock = int.Parse(Console.ReadLine());

            Producto producto = new Producto(nombre, codigo, precio, stock);

            int opcion;

            do
            {
                
                Console.WriteLine("1. Agregar stock");
                Console.WriteLine("2. Vender producto");
                Console.WriteLine("3. Mostrar información");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Cantidad a agregar: ");
                        int agregar = int.Parse(Console.ReadLine());
                        producto.AgregarStock(agregar);
                        break;

                    case 2:
                        Console.Write("Cantidad a vender: ");
                        int vender = int.Parse(Console.ReadLine());
                        decimal total = producto.VenderProducto(vender);
                        if (total > 0)
                        {
                            Console.WriteLine("Total de la venta: $" + total);
                        }
                        break;

                    case 3:
                        producto.MostrarInfo();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}