using Parcail_01.Models;
using Parcial_01.Models;
using Parcial_01.Services;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Se instancia el servicio de gestión
        var service = new StockService();
        int opcion;

        // Menú principal
        do
        {
            Console.WriteLine("1. Crear | 2. Listar | 3. Modificar | 4. Eliminar | 0. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Crear nueva herramienta
                    var h = new Herramienta();

                    Console.Write("ID: ");
                    h.Id = int.Parse(Console.ReadLine());

                    Console.Write("Descripcion: ");
                    h.Descripcion = Console.ReadLine();

                    Console.Write("Precio: ");
                    h.Precio = double.Parse(Console.ReadLine());

                    Console.Write("Tipo (0 Manual, 1 Electrica, 2 Medicion): ");
                    h.Tipo = (TipoHerramienta)int.Parse(Console.ReadLine());

                    service.Crear(h);

                    Console.WriteLine("[SUCCESS] Guardado en stock.csv");
                    break;

                case 2:
                    // Listar herramientas
                    foreach (var item in service.Listar())
                    {
                        Console.WriteLine($"ID {item.Id} | Desc: {item.Descripcion} | ${item.Precio} | {item.Tipo}");
                    }
                    break;

                case 3:
                    // Modificar herramienta
                    var m = new Herramienta();

                    Console.Write("ID: ");
                    m.Id = int.Parse(Console.ReadLine());

                    Console.Write("Descripcion: ");
                    m.Descripcion = Console.ReadLine();

                    Console.Write("Precio: ");
                    m.Precio = double.Parse(Console.ReadLine());

                    Console.Write("Tipo: ");
                    m.Tipo = (TipoHerramienta)int.Parse(Console.ReadLine());

                    service.Modificar(m);
                    break;

                case 4:
                    // Eliminar herramienta
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    service.Eliminar(id);
                    break;
            }

        } while (opcion != 0);
    }
}
