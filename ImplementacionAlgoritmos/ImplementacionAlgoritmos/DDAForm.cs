﻿using System;
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
    public partial class DDAForm : Form
    {
        public static DDAForm instancia;
        public DDAForm()
        {
            InitializeComponent();
        }

        public static DDAForm ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new DDAForm();
            }
            return instancia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int xI = int.Parse(txtXi.Text);
                int yI = int.Parse(txtYi.Text);
                int xF = int.Parse(txtXf.Text);
                int yF = int.Parse(txtYf.Text);

                Bitmap bmp = new Bitmap(picGrafico.Width, picGrafico.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen lapiz = new Pen(Color.Black);

                DDAC.dibujarLinea(g, lapiz, xI, yI, xF, yF, picGrafico, bmp, listPuntos);



                picGrafico.Image = bmp;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtXi.Clear();
            txtYi.Clear();
            txtXf.Clear();
            txtYf.Clear();
            picGrafico.Image = null;
            listPuntos.Items.Clear();
        }
    }
}
