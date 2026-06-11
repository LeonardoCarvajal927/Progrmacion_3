using HelixToolkit.Wpf;
using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmGraficaTerreno : Form
    {
        private double[,] alturas;

        public FrmGraficaTerreno(double[,] matrizAlturas)
        {
            InitializeComponent();
            alturas = matrizAlturas;
        }

        private void FrmGraficaTerreno_Load(object sender, EventArgs e)
        {
            CrearGrafica3D();
        }

        private void CrearGrafica3D()
        {
            HelixViewport3D viewport = new HelixViewport3D();

            viewport.ShowFrameRate = false;
            viewport.ShowCoordinateSystem = true;
            viewport.Background = System.Windows.Media.Brushes.White;

            // Permite interacción con el mouse.
            viewport.IsHitTestVisible = true;
            viewport.Focusable = true;

            // Configuración para que se pueda mover como una vista 3D normal.
            viewport.RotateGesture = new MouseGesture(MouseAction.LeftClick);
            viewport.PanGesture = new MouseGesture(MouseAction.LeftClick, System.Windows.Input.ModifierKeys.Shift);
            viewport.ZoomExtentsWhenLoaded = true;

            viewport.Camera = new PerspectiveCamera
            {
                Position = new Point3D(6, -8, 6),
                LookDirection = new Vector3D(-6, 8, -6),
                UpDirection = new Vector3D(0, 0, 1),
                FieldOfView = 45
            };

            SunLight luz = new SunLight();
            viewport.Children.Add(luz);

            MeshBuilder meshBuilder = new MeshBuilder(false, false);

            int filas = alturas.GetLength(0);
            int columnas = alturas.GetLength(1);

            /*
             La matriz de alturas se convierte en una superficie 3D.

             X = columna de la matriz
             Y = fila de la matriz
             Z = altura del terreno
            */

            for (int i = 0; i < filas - 1; i++)
            {
                for (int j = 0; j < columnas - 1; j++)
                {
                    Point3D p1 = new Point3D(j, i, alturas[i, j]);
                    Point3D p2 = new Point3D(j + 1, i, alturas[i, j + 1]);
                    Point3D p3 = new Point3D(j + 1, i + 1, alturas[i + 1, j + 1]);
                    Point3D p4 = new Point3D(j, i + 1, alturas[i + 1, j]);

                    meshBuilder.AddQuad(p1, p2, p3, p4);
                }
            }

            GeometryModel3D modeloTerreno = new GeometryModel3D();

            modeloTerreno.Geometry = meshBuilder.ToMesh();
            modeloTerreno.Material = MaterialHelper.CreateMaterial(System.Windows.Media.Colors.SandyBrown);
            modeloTerreno.BackMaterial = MaterialHelper.CreateMaterial(System.Windows.Media.Colors.SandyBrown);

            ModelVisual3D visual = new ModelVisual3D();
            visual.Content = modeloTerreno;

            viewport.Children.Add(visual);

            GridLinesVisual3D grilla = new GridLinesVisual3D();

            grilla.Width = columnas;
            grilla.Length = filas;
            grilla.MinorDistance = 1;
            grilla.MajorDistance = 1;
            grilla.Thickness = 0.02;
            grilla.Fill = System.Windows.Media.Brushes.Gray;

            viewport.Children.Add(grilla);

            ElementHost host = new ElementHost();

            host.Dock = DockStyle.Fill;
            host.Child = viewport;

            pnlGrafica.Controls.Clear();
            pnlGrafica.Controls.Add(host);

            // Le damos el foco a la gráfica para que reciba eventos del mouse.
            host.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}