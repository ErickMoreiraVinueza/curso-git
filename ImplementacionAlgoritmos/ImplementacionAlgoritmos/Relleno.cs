using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionAlgoritmos
{
    public partial class Relleno : Form
    {
        public static Relleno instancia;
        private Bitmap bmp;
        private Color colorRelleno = Color.Yellow;

        public Relleno()
        {
            InitializeComponent();
            this.Load += Relleno_Load;
            picLienzo.MouseClick += picLienzo_MouseClick;
            btnResetear.Click += btnResetear_Click;
        }

        public static Relleno ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Relleno();
            }
            return instancia;
        }

        private void DibujarCircunferenciaDefecto()
        {
            CircunferenciaC circulo = new CircunferenciaC
            {
                Xc = 5,
                Yc = 5,
                R = 90
            };

            List<Point> puntos = circulo.CalcularPuntos();

            bmp = new Bitmap(picLienzo.Width, picLienzo.Height);
            int Xc = picLienzo.Width / 2;
            int Yc = picLienzo.Height / 2;

            foreach (Point punto in puntos)
            {
                int pantallaX = Xc + punto.X;
                int pantallaY = Yc - punto.Y;

                if (pantallaX >= 0 && pantallaX < bmp.Width && pantallaY >= 0 && pantallaY < bmp.Height)
                {
                    bmp.SetPixel(pantallaX, pantallaY, Color.Black);
                }
            }

            picLienzo.Image = bmp;
        }

        private void Relleno_Load(object sender, EventArgs e)
        {
            CircunferenciaC circulo = new CircunferenciaC
            {
                Xc = 5,
                Yc = 5,
                R = 90
            };

            List<Point> puntos = circulo.CalcularPuntos();

            bmp = new Bitmap(picLienzo.Width, picLienzo.Height);
            int Xc = picLienzo.Width / 2;
            int Yc = picLienzo.Height / 2;

            foreach (Point punto in puntos)
            {
                int pantallaX = Xc + punto.X;
                int pantallaY = Yc - punto.Y;

                if (pantallaX >= 0 && pantallaX < bmp.Width && pantallaY >= 0 && pantallaY < bmp.Height)
                {
                    bmp.SetPixel(pantallaX, pantallaY, Color.Black);
                }
            }

            picLienzo.Image = bmp;
        }

        private async void picLienzo_MouseClick(object sender, MouseEventArgs e)
        {
            Color colorObjetivo = bmp.GetPixel(e.X, e.Y);

            if (colorObjetivo.ToArgb() != colorRelleno.ToArgb() && colorObjetivo.ToArgb() != Color.Black.ToArgb())
            {
                RellenoC relleno = new RellenoC();
                await relleno.FloodFillAsync(bmp, picLienzo, e.X, e.Y, colorObjetivo, colorRelleno, delayMs: 1);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            DibujarCircunferenciaDefecto();
        }
    }
}
