using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class Pentagono : Form
    {
        public static Pentagono instancia;
        public Pentagono()
        {
            InitializeComponent();
        }

        public static Pentagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Pentagono();
            }
            return instancia;
        }

        private void DibujarPentagono(PentagonoC pentagono)
        {
            Bitmap bmp = new Bitmap(picBoxGrafico.Width, picBoxGrafico.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White); // Fondo blanco

            int centerX = picBoxGrafico.Width / 2;
            int centerY = picBoxGrafico.Height / 2;

            float escala = 20f; // Ajusta según tamaño del PictureBox
            float radio = (float)(pentagono.Lado / (2 * Math.Sin(Math.PI / 5)) * escala); // Radio del círculo circunscrito

            PointF[] puntos = new PointF[5];

            for (int i = 0; i < 5; i++)
            {
                double angulo = (Math.PI / 2) + (i * 2 * Math.PI / 5); // Comienza desde la parte superior
                float x = centerX + (float)(radio * Math.Cos(angulo));
                float y = centerY - (float)(radio * Math.Sin(angulo)); // Negativo porque el eje Y en pantalla va hacia abajo
                puntos[i] = new PointF(x, y);
            }

            Pen lapiz = new Pen(Color.DarkGreen, 2);
            g.DrawPolygon(lapiz, puntos);

            picBoxGrafico.Image = bmp;

            lapiz.Dispose();
            g.Dispose();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double lado = double.Parse(txtLado.Text);
                double apotema = double.Parse(txtApotema.Text);

                if (lado <= 0 || apotema <= 0)
                {
                    MessageBox.Show("Por favor, los valores deben ser mayores que cero");
                    return;
                }

                PentagonoC pentagono = new PentagonoC(lado, apotema);
                double area = pentagono.CalcularArea();
                double perimetro = pentagono.CalcularPerimetro();
                DibujarPentagono(pentagono);

                txtArea.Text = area.ToString("F2");
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos");
            }
        }
    }
}
