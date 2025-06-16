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
    public partial class Circunferencia : Form
    {
        public static Circunferencia instancia;
        public Circunferencia()
        {
            InitializeComponent();
        }

        public static Circunferencia ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Circunferencia();
            }
            return instancia;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            int centroUsuarioX = int.Parse(txtCentroX.Text);
            int centroUsuarioY = int.Parse(txtCentroY.Text);
            int radio = int.Parse(txtRadio.Text);

            CircunferenciaC circulo = new CircunferenciaC();
            circulo.Xc = centroUsuarioX;
            circulo.Yc = centroUsuarioY;
            circulo.R = radio;

            List<Point> puntos = circulo.CalcularPuntos();

            Bitmap bmp = new Bitmap(picLienzo.Width, picLienzo.Height);
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtCentroX.Clear();
            txtCentroY.Clear();
            txtRadio.Clear();
            picLienzo.Image = null;
        }
    }
}
