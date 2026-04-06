using Parcail_01.Models;
using Parcial_01.Models;


namespace Parcial_01.Services
{
    // Clase encargada de gestionar el stock y la persistencia en CSV
    public class StockService
    {
        private List<Herramienta> lista = new List<Herramienta>(); 
        private string path = "stock.csv"; 

        // Constructor que carga los datos al iniciar el programa
        public StockService()
        {
            if (File.Exists(path))
            {
                var lineas = File.ReadAllLines(path);
                foreach (var l in lineas)
                {
                    var p = l.Split(',');

                    // Se convierte cada línea del CSV en un objeto Herramienta
                    lista.Add(new Herramienta
                    {
                        Id = int.Parse(p[0]),
                        Descripcion = p[1],
                        Precio = double.Parse(p[2]),
                        Tipo = (TipoHerramienta)int.Parse(p[3])
                    });
                }
            }
        }

        // Método privado para guardar los datos en el archivo CSV
        private void Guardar()
        {
            var lineas = lista.Select(x => $"{x.Id},{x.Descripcion},{x.Precio},{(int)x.Tipo}");
            File.WriteAllLines(path, lineas);
        }

        // Método para crear una nueva herramienta
        public void Crear(Herramienta item)
        {
            lista.Add(item);
            Guardar();
        }

        // Método para listar todas las herramientas
        public List<Herramienta> Listar()
        {
            return lista;
        }

        // Método para modificar una herramienta existente
        public void Modificar(Herramienta item)
        {
            var obj = lista.FirstOrDefault(x => x.Id == item.Id);

            if (obj != null)
            {
                obj.Descripcion = item.Descripcion;
                obj.Precio = item.Precio;
                obj.Tipo = item.Tipo;
                Guardar();
            }
        }

        // Método para eliminar una herramienta por ID
        public void Eliminar(int id)
        {
            var obj = lista.FirstOrDefault(x => x.Id == id);

            if (obj != null)
            {
                lista.Remove(obj);
                Guardar();
            }
        }
    }
}
