using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 Paso 1: Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    MessageBox.Show("Nombre y DNI son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Paso 2: Validar ciudad
                string ciudad = txtCiudad.Text;
                if (string.IsNullOrWhiteSpace(ciudad))
                {
                    ciudad = "No especificado";
                }

                // 🔹 Paso 3: Ruta del archivo
                string nombreArchivo = "clientes.csv";
                string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

                // 🔹 Paso 4: Crear archivo si no existe
                if (!File.Exists(rutaArchivo))
                {
                    File.WriteAllText(rutaArchivo, "DNI,Nombre,Ciudad" + Environment.NewLine);
                }

                // 🔹 Paso 5: Guardar datos
                string linea = $"{txtDNI.Text},{txtNombre.Text},{ciudad}" + Environment.NewLine;
                File.AppendAllText(rutaArchivo, linea);

                // 🔹 Paso 6: Mensaje
                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔹 Paso 7: Limpiar campos
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtCiudad.Clear();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            try
            {
                // 🔹 Paso 1: Ruta
                string nombreArchivo = "clientes.csv";
                string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

                // 🔹 Paso 2: Verificar existencia
                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("No existe el archivo.");
                    return;
                }

                // 🔹 Paso 3: Limpiar lista
                listClientes.Items.Clear();

                // 🔹 Paso 4: Leer archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                bool primera = true;

                // 🔹 Paso 5: Recorrer con foreach
                foreach (string linea in lineas)
                {
                    if (primera)
                    {
                        primera = false;
                        continue;
                    }

                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] datos = linea.Split(',');

                        if (datos.Length >= 3)
                        {
                            string dni = datos[0].Trim();
                            string nombre = datos[1].Trim();
                            string ciudad = datos[2].Trim();

                            string cliente = $"[{dni}] {nombre} - Ciudad: {ciudad}";
                            listClientes.Items.Add(cliente);
                        }
                    }
                }

                MessageBox.Show($"Se cargaron {listClientes.Items.Count} clientes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }
    }
}
