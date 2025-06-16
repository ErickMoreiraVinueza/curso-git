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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DDAForm ddaf = DDAForm.ObtenerInstancia();
            ddaf.MdiParent = this;
            if (!ddaf.Visible)
            {
                ddaf.Show();
            }
            else
            {
                ddaf.BringToFront();
            }
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bresenham bresenhamForm = Bresenham.ObtenerInstancia();
            bresenhamForm.MdiParent = this;
            if (!bresenhamForm.Visible)
            {
                bresenhamForm.Show();
            }
            else
            {
                bresenhamForm.BringToFront();
            }
        }

        private void circunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circunferencia circunferenciaForm = Circunferencia.ObtenerInstancia();
            circunferenciaForm.MdiParent = this;
            if (!circunferenciaForm.Visible)
            {
                circunferenciaForm.Show();
            }
            else
            {
                circunferenciaForm.BringToFront();
            }
        }

        private void rellenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relleno rellenoForm = new Relleno();
            rellenoForm.MdiParent = this;
            if (!rellenoForm.Visible)
            {
                rellenoForm.Show();
            }
            else
            {
                rellenoForm.BringToFront();
            }
        }
    }
}
