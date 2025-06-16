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
    public partial class Bresenham : Form
    {
        public static Bresenham instancia;
        public Bresenham()
        {
            InitializeComponent();
        }

        public static Bresenham ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Bresenham();
            }
            return instancia;
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los puntos desde los TextBox
                string[] puntoInicial = txtPuntoInicial.Text.Split(',');
                string[] puntoFinal = txtPuntoFinal.Text.Split(',');

                int x0 = int.Parse(puntoInicial[0]);
                int y0 = int.Parse(puntoInicial[1]);
                int x1 = int.Parse(puntoFinal[0]);
                int y1 = int.Parse(puntoFinal[1]);

                // Dibujar usando Bresenham
                BresenhamC bresenham = new BresenhamC(pictureBox, listPuntos);
                bresenham.DrawLine(x0, y0, x1, y1);
            }
            catch
            {
                MessageBox.Show("Verifica que los puntos estén en formato correcto: x,y", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            pictureBox.Invalidate(); // Limpia el gráfico
            txtPuntoInicial.Clear();
            txtPuntoFinal.Clear();
            listPuntos.Items.Clear(); 
        }
    }
}
