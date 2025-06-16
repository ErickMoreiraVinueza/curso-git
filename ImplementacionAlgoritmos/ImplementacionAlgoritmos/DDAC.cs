using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionAlgoritmos
{
    internal class DDAC
    {
        
        public static void dibujarLinea(Graphics g, Pen lapiz, int xI, int yI, int xF, int yF, PictureBox picGrafico, Bitmap bmp, ListBox listPuntos)
        {
            //Para el centro de la pantalla
            int centroX = (int)g.VisibleClipBounds.Width / 2;
            int centroY = (int)g.VisibleClipBounds.Height / 2;

            int Deltax = xF - xI;
            int Deltay = yF - yI;
            float m = (float)Deltay / Deltax;
            int k = Math.Max(Math.Abs(Deltax), Math.Abs(Deltay));

            float x = xI;
            float y = yI;

            if (Math.Abs(m) <= 1)
            {
                float incrementoY = m;
                float incrementoX = Math.Sign(Deltax);


                for (int i = 0; i <= k; i++)
                {
                    g.FillRectangle(lapiz.Brush, (int)Math.Round(centroX + x), (int)Math.Round(centroY - y), 2, 2);
                    picGrafico.Image = bmp;
                    picGrafico.Refresh();
                    Thread.Sleep(500);
                    Console.WriteLine($"Punto: ({(int)Math.Round(x)}, {(int)Math.Round(y)})");
                    listPuntos.Items.Add($"({(int)Math.Round(x)}, {(int)Math.Round(y)})");
                    listPuntos.Refresh();
                    x += incrementoX;
                    y += incrementoY;

                }
            }
            else
            {
                float incrementoX = 1 / m;
                float incrementoY = Math.Sign(Deltay);

                for (int i = 0; i <= k; i++)
                {
                    g.FillRectangle(lapiz.Brush, (int)Math.Round(centroX + x), (int)Math.Round(centroY - y), 2, 2);
                    picGrafico.Image = bmp;
                    picGrafico.Refresh();
                    Thread.Sleep(500);
                    Console.WriteLine($"Punto: ({(int)Math.Round(x)}, {(int)Math.Round(y)})");
                    listPuntos.Items.Add($"({(int)Math.Round(x)}, {(int)Math.Round(y)})");
                    listPuntos.Refresh();
                    x += incrementoX * Math.Sign(Deltay);
                    y += incrementoY;
                }
            }
        }
    }
}
