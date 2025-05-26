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
    public partial class Rombo : Form
    {
        public static Rombo instancia;
        public Rombo()
        {
            InitializeComponent();
        }

        public static Rombo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Rombo();
            }
            return instancia;
        }


        private void DibujarRombo(RomboC rombo)
        {

            Bitmap bmp = new Bitmap(picBoxGrafico.Width, picBoxGrafico.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            int centerX = picBoxGrafico.Width / 2;
            int centerY = picBoxGrafico.Height / 2;

            float escala = 10f;

            float dMayor = (float)(rombo.DiagonalMayor / 2.0 * escala);
            float dMenor = (float)(rombo.DiagonalMenor / 2.0 * escala);

            PointF[] puntos = new PointF[4];
            puntos[0] = new PointF(centerX, centerY - dMayor);
            puntos[1] = new PointF(centerX + dMenor, centerY);
            puntos[2] = new PointF(centerX, centerY + dMayor);
            puntos[3] = new PointF(centerX - dMenor, centerY);

            Pen lapiz = new Pen(Color.Red, 2);
            g.DrawPolygon(lapiz, puntos);

            picBoxGrafico.Image = bmp;

            lapiz.Dispose();
            g.Dispose();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double diagonalMayor = double.Parse(txtDiagonalMayor.Text);
                double diagonalMenor = double.Parse(txtDiagonalMenor.Text);
                double lado = double.Parse(txtLado.Text);

                if (diagonalMayor <= 0 || diagonalMenor <= 0 || lado <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                RomboC rombo = new RomboC(diagonalMayor, diagonalMenor, lado);
                double area = rombo.CalcularArea();
                double perimetro = rombo.CalcularPerimetro();
                DibujarRombo(rombo);

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
