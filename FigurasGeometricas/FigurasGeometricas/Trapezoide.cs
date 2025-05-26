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
    public partial class Trapezoide : Form
    {
        public static Trapezoide instancia;
        public Trapezoide()
        {
            InitializeComponent();
        }

        public static Trapezoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Trapezoide();
            }
            return instancia;
        }

        private void DibujarTrapezoide(TrapezoideC trapezoide)
        {
            Bitmap bmp = new Bitmap(picBoxGrafico.Width, picBoxGrafico.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            float escala = 20f;
            float baseMayor = (float)(trapezoide.BaseMayor * escala);
            float baseMenor = (float)(trapezoide.BaseMenor * escala);
            float altura = (float)(trapezoide.Altura * escala);

            int centerX = picBoxGrafico.Width / 2;
            int centerY = picBoxGrafico.Height / 2;

            PointF[] puntos = new PointF[4];

            // Esquina inferior izquierda
            puntos[0] = new PointF(centerX - baseMayor / 2, centerY + altura / 2);
            // Esquina inferior derecha
            puntos[1] = new PointF(centerX + baseMayor / 2, centerY + altura / 2);
            // Esquina superior derecha
            puntos[2] = new PointF(centerX + baseMenor / 2, centerY - altura / 2);
            // Esquina superior izquierda
            puntos[3] = new PointF(centerX - baseMenor / 2, centerY - altura / 2);

            Pen lapiz = new Pen(Color.Purple, 2);
            g.DrawPolygon(lapiz, puntos);

            picBoxGrafico.Image = bmp;

            lapiz.Dispose();
            g.Dispose();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseMayor = double.Parse(txtBaseMayor.Text);
                double baseMenor = double.Parse(txtBaseMenor.Text);
                double ladoIzquierdo = double.Parse(txtLadoIzq.Text);
                double ladoDerecho = double.Parse(txtLadoDer.Text);
                double altura = double.Parse(txtAltura.Text);

                if (baseMayor <= 0 || baseMenor <= 0 || ladoIzquierdo <= 0 || ladoDerecho <= 0 || altura <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                TrapezoideC trapezoide = new TrapezoideC(baseMayor, baseMenor, ladoIzquierdo, ladoDerecho, altura);
                double area = trapezoide.CalcularArea();
                double perimetro = trapezoide.CalcularPerimetro();
                DibujarTrapezoide(trapezoide);

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
