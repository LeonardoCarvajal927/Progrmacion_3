using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmGraficaCoordenadas : Form
    {
        private List<Coordenada> coordenadas;
        private GLControl glControl1;

        private float rotX = 25f;
        private float rotY = -40f;
        private float zoom = -4.0f;
        private float panX = 0f;
        private float panY = 0f;

        private Point ultimoMouse;
        private bool mouseIzquierdoPresionado = false;
        private bool mouseDerechoPresionado = false;

        public FrmGraficaCoordenadas(List<Coordenada> listaCoordenadas)
        {
            InitializeComponent();

            coordenadas = new List<Coordenada>(listaCoordenadas);

            CrearGLControl();

            this.KeyPreview = true;
        }

        private void CrearGLControl()
        {
            glControl1 = new GLControl(new GraphicsMode(32, 24, 0, 4));

            glControl1.Dock = DockStyle.Fill;

            glControl1.Load += GlControl_Load;
            glControl1.Paint += GlControl_Paint;
            glControl1.Resize += GlControl_Resize;

            glControl1.MouseDown += GlControl_MouseDown;
            glControl1.MouseUp += GlControl_MouseUp;
            glControl1.MouseMove += GlControl_MouseMove;
            glControl1.MouseWheel += GlControl_MouseWheel;
            glControl1.DoubleClick += GlControl_DoubleClick;

            pnlGrafica.Controls.Clear();
            pnlGrafica.Controls.Add(glControl1);
        }

        private void GlControl_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.FromArgb(20, 20, 35));
            GL.Enable(EnableCap.DepthTest);
            GL.PointSize(8f);

            ConfigurarVista();
        }

        private void GlControl_Resize(object sender, EventArgs e)
        {
            ConfigurarVista();
            glControl1.Invalidate();
        }

        private void ConfigurarVista()
        {
            if (glControl1.Width == 0 || glControl1.Height == 0)
            {
                return;
            }

            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);

            Matrix4 perspectiva = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4,
                glControl1.Width / (float)glControl1.Height,
                0.1f,
                100f);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspectiva);
        }

        private void GlControl_Paint(object sender, PaintEventArgs e)
        {
            if (coordenadas == null || coordenadas.Count < 4)
            {
                return;
            }

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            GL.Translate(panX, panY, zoom);
            GL.Rotate(rotX, 1.0f, 0.0f, 0.0f);
            GL.Rotate(rotY, 0.0f, 1.0f, 0.0f);

            DibujarEjes();
            DibujarGrillaBase();
            DibujarTerreno();
            DibujarPuntos();

            glControl1.SwapBuffers();

            DibujarTexto2D();
        }

        private void DibujarEjes()
        {
            GL.LineWidth(3f);

            GL.Begin(PrimitiveType.Lines);

            // Eje X rojo
            GL.Color3(Color.Red);
            GL.Vertex3(-1.2f, 0f, 0f);
            GL.Vertex3(1.4f, 0f, 0f);

            // Eje Y verde
            GL.Color3(Color.LimeGreen);
            GL.Vertex3(0f, 0f, -1.2f);
            GL.Vertex3(0f, 0f, 1.4f);

            // Eje Z azul
            GL.Color3(Color.CornflowerBlue);
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(0f, 1.4f, 0f);

            GL.End();
        }

        private void DibujarGrillaBase()
        {
            GL.LineWidth(1f);
            GL.Color3(Color.DimGray);

            GL.Begin(PrimitiveType.Lines);

            for (float i = -1.0f; i <= 1.01f; i += 0.2f)
            {
                GL.Vertex3(-1.0f, 0f, i);
                GL.Vertex3(1.0f, 0f, i);

                GL.Vertex3(i, 0f, -1.0f);
                GL.Vertex3(i, 0f, 1.0f);
            }

            GL.End();
        }

        private void DibujarTerreno()
        {
            double xMin = coordenadas.Min(c => c.X);
            double xMax = coordenadas.Max(c => c.X);
            double yMin = coordenadas.Min(c => c.Y);
            double yMax = coordenadas.Max(c => c.Y);
            double zMin = coordenadas.Min(c => c.Z);
            double zMax = coordenadas.Max(c => c.Z);

            double rangoX = xMax - xMin;
            double rangoY = yMax - yMin;
            double rangoZ = zMax - zMin;

            if (rangoX == 0) rangoX = 1;
            if (rangoY == 0) rangoY = 1;
            if (rangoZ == 0) rangoZ = 1;

            int divisiones = 30;

            GL.LineWidth(1.5f);

            for (int fila = 0; fila < divisiones; fila++)
            {
                GL.Begin(PrimitiveType.TriangleStrip);

                for (int columna = 0; columna <= divisiones; columna++)
                {
                    double x1 = xMin + columna * (rangoX / divisiones);
                    double y1 = yMin + fila * (rangoY / divisiones);
                    double z1 = InterpolarAltura(x1, y1);

                    double x2 = xMin + columna * (rangoX / divisiones);
                    double y2 = yMin + (fila + 1) * (rangoY / divisiones);
                    double z2 = InterpolarAltura(x2, y2);

                    Vector3 p1 = NormalizarPunto(x1, y1, z1, xMin, yMin, zMin, rangoX, rangoY, rangoZ);
                    Vector3 p2 = NormalizarPunto(x2, y2, z2, xMin, yMin, zMin, rangoX, rangoY, rangoZ);

                    Color color1 = ObtenerColorAltura((float)((z1 - zMin) / rangoZ));
                    Color color2 = ObtenerColorAltura((float)((z2 - zMin) / rangoZ));

                    GL.Color3(color1);
                    GL.Vertex3(p1);

                    GL.Color3(color2);
                    GL.Vertex3(p2);
                }

                GL.End();
            }

            // Malla encima del terreno
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            GL.Color3(Color.Black);

            for (int fila = 0; fila < divisiones; fila++)
            {
                GL.Begin(PrimitiveType.TriangleStrip);

                for (int columna = 0; columna <= divisiones; columna++)
                {
                    double x1 = xMin + columna * (rangoX / divisiones);
                    double y1 = yMin + fila * (rangoY / divisiones);
                    double z1 = InterpolarAltura(x1, y1);

                    double x2 = xMin + columna * (rangoX / divisiones);
                    double y2 = yMin + (fila + 1) * (rangoY / divisiones);
                    double z2 = InterpolarAltura(x2, y2);

                    Vector3 p1 = NormalizarPunto(x1, y1, z1, xMin, yMin, zMin, rangoX, rangoY, rangoZ);
                    Vector3 p2 = NormalizarPunto(x2, y2, z2, xMin, yMin, zMin, rangoX, rangoY, rangoZ);

                    GL.Vertex3(p1);
                    GL.Vertex3(p2);
                }

                GL.End();
            }

            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
        }

        private void DibujarPuntos()
        {
            double xMin = coordenadas.Min(c => c.X);
            double xMax = coordenadas.Max(c => c.X);
            double yMin = coordenadas.Min(c => c.Y);
            double yMax = coordenadas.Max(c => c.Y);
            double zMin = coordenadas.Min(c => c.Z);
            double zMax = coordenadas.Max(c => c.Z);

            double rangoX = xMax - xMin;
            double rangoY = yMax - yMin;
            double rangoZ = zMax - zMin;

            if (rangoX == 0) rangoX = 1;
            if (rangoY == 0) rangoY = 1;
            if (rangoZ == 0) rangoZ = 1;

            GL.PointSize(9f);
            GL.Begin(PrimitiveType.Points);

            GL.Color3(Color.White);

            foreach (Coordenada c in coordenadas)
            {
                Vector3 punto = NormalizarPunto(c.X, c.Y, c.Z, xMin, yMin, zMin, rangoX, rangoY, rangoZ);
                GL.Vertex3(punto);
            }

            GL.End();
        }

        private Vector3 NormalizarPunto(double x, double y, double z,
                                        double xMin, double yMin, double zMin,
                                        double rangoX, double rangoY, double rangoZ)
        {
            float nx = (float)(((x - xMin) / rangoX) - 0.5) * 2.0f;
            float nz = (float)(((y - yMin) / rangoY) - 0.5) * 2.0f;
            float ny = (float)(((z - zMin) / rangoZ)) * 1.2f;

            return new Vector3(nx, ny, nz);
        }

        private double InterpolarAltura(double x, double y)
        {
            double sumaPesos = 0;
            double sumaAlturas = 0;

            foreach (Coordenada punto in coordenadas)
            {
                double distancia = Math.Sqrt(
                    Math.Pow(punto.X - x, 2) +
                    Math.Pow(punto.Y - y, 2));

                if (distancia < 0.0001)
                {
                    return punto.Z;
                }

                double peso = 1.0 / (distancia * distancia);

                sumaPesos += peso;
                sumaAlturas += peso * punto.Z;
            }

            return sumaAlturas / sumaPesos;
        }

        private Color ObtenerColorAltura(float t)
        {
            if (t < 0.25f)
            {
                return Color.Blue;
            }

            if (t < 0.50f)
            {
                return Color.LimeGreen;
            }

            if (t < 0.75f)
            {
                return Color.Yellow;
            }

            return Color.OrangeRed;
        }

        private void DibujarTexto2D()
        {
            using (Graphics g = glControl1.CreateGraphics())
            {
                Font fuente = new Font("Arial", 11, FontStyle.Bold);
                Font fuentePequena = new Font("Arial", 9);

                g.DrawString("X", fuente, Brushes.Red, glControl1.Width / 2 + 170, glControl1.Height / 2);
                g.DrawString("Y", fuente, Brushes.LimeGreen, glControl1.Width / 2 + 20, glControl1.Height / 2 + 130);
                g.DrawString("Z Altura", fuente, Brushes.CornflowerBlue, glControl1.Width / 2 - 30, 15);

                g.DrawString("Izquierdo: rotar | Derecho: mover | Rueda: zoom | Doble clic o R: resetear",
                    fuentePequena,
                    Brushes.LightGray,
                    10,
                    glControl1.Height - 25);

                fuente.Dispose();
                fuentePequena.Dispose();
            }
        }

        private void GlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ultimoMouse = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                mouseIzquierdoPresionado = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                mouseDerechoPresionado = true;
            }
        }

        private void GlControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseIzquierdoPresionado = false;
            }

            if (e.Button == MouseButtons.Right)
            {
                mouseDerechoPresionado = false;
            }
        }

        private void GlControl_MouseMove(object sender, MouseEventArgs e)
        {
            float dx = e.X - ultimoMouse.X;
            float dy = e.Y - ultimoMouse.Y;

            if (mouseIzquierdoPresionado)
            {
                rotY += dx * 0.5f;
                rotX += dy * 0.5f;
            }

            if (mouseDerechoPresionado)
            {
                panX += dx * 0.005f;
                panY -= dy * 0.005f;
            }

            ultimoMouse = e.Location;

            glControl1.Invalidate();
        }

        private void GlControl_MouseWheel(object sender, MouseEventArgs e)
        {
            zoom += e.Delta * 0.002f;

            if (zoom > -1.5f)
            {
                zoom = -1.5f;
            }

            if (zoom < -12f)
            {
                zoom = -12f;
            }

            glControl1.Invalidate();
        }

        private void GlControl_DoubleClick(object sender, EventArgs e)
        {
            ResetearVista();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.R)
            {
                ResetearVista();
            }
        }

        private void ResetearVista()
        {
            rotX = 25f;
            rotY = -40f;
            zoom = -4.0f;
            panX = 0f;
            panY = 0f;

            glControl1.Invalidate();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}