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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rombo rombo = Rombo.ObtenerInstancia();
            rombo.MdiParent = this;
            if (!rombo.Visible)
            {
                rombo.Show();
            }
            else
            {
                rombo.BringToFront();
            }
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pentagono pentangono = Pentagono.ObtenerInstancia();
            pentangono.MdiParent = this;
            if (!pentangono.Visible)
            {
                pentangono.Show();
            }
            else
            {
                pentangono.BringToFront();
            }
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romboide romboide = Romboide.ObtenerInstancia();
            romboide.MdiParent = this;
            if (!romboide.Visible)
            {
                romboide.Show();
            }
            else
            {
                romboide.BringToFront();
            }
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trapezoide trapezoide = Trapezoide.ObtenerInstancia();
            trapezoide.MdiParent = this;
            if (!trapezoide.Visible)
            {
                trapezoide.Show();
            }
            else
            {
                trapezoide.BringToFront();
            }
        }
    }
}
