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
    public partial class Romboide : Form
    {
        public static Romboide instancia;
        public Romboide()
        {
            InitializeComponent();
        }

        public static Romboide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Romboide();
            }
            return instancia;
        }

        private void DibujarRomboide(RomboideC romboide)
        {
            Bitmap bmp = new Bitmap(picBoxGrafico.Width, picBoxGrafico.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            float escala = 20f;
            float baseEscalada = (float)(romboide.Base * escala);
            float alturaEscalada = (float)(romboide.Altura * escala);
            float desplazamiento = baseEscalada / 4f; // Ajuste visual para inclinar el romboide

            int centerX = picBoxGrafico.Width / 2;
            int centerY = picBoxGrafico.Height / 2;

            PointF[] puntos = new PointF[4];

            // Esquina inferior izquierda
            puntos[0] = new PointF(centerX - baseEscalada / 2, centerY + alturaEscalada / 2);
            // Esquina inferior derecha
            puntos[1] = new PointF(centerX + baseEscalada / 2, centerY + alturaEscalada / 2);
            // Esquina superior derecha (desplazada)
            puntos[2] = new PointF(centerX + baseEscalada / 2 - desplazamiento, centerY - alturaEscalada / 2);
            // Esquina superior izquierda (desplazada)
            puntos[3] = new PointF(centerX - baseEscalada / 2 - desplazamiento, centerY - alturaEscalada / 2);

            Pen lapiz = new Pen(Color.OrangeRed, 2);
            g.DrawPolygon(lapiz, puntos);

            picBoxGrafico.Image = bmp;

            lapiz.Dispose();
            g.Dispose();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseRomboide = double.Parse(txtBase.Text);
                double altura = double.Parse(txtAltura.Text);
                double ladoLateral = double.Parse(txtLadoLateral.Text);

                if (baseRomboide <= 0 || altura <= 0 || ladoLateral <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                RomboideC romboide = new RomboideC(baseRomboide, altura, ladoLateral);
                double area = romboide.CalcularArea();
                double perimetro = romboide.CalcularPerimetro();
                DibujarRomboide(romboide);

                txtArea.Text = area.ToString("F2");
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
    }
}
