using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionAlgoritmos
{
    internal class BresenhamC
    {
        private Graphics g;
        private PictureBox pictureBox;
        private Pen pen;
        private ListBox listPuntos;

        public BresenhamC(PictureBox pb, ListBox lb, Pen customPen = null)
        {
            pictureBox = pb;
            listPuntos = lb;
            g = pb.CreateGraphics();
            pen = customPen ?? new Pen(Color.DarkBlue);
        }

        private Point TransformToCenter(int x, int y)
        {
            int centerX = pictureBox.Width / 2;
            int centerY = pictureBox.Height / 2;
            return new Point(centerX + x, centerY - y);
        }

        public void DrawLine(int x0, int y0, int x1, int y1)
        {
            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                Point p = TransformToCenter(x0, y0);
                g.FillRectangle(pen.Brush, p.X, p.Y, 2, 2);
                Thread.Sleep(500);
                listPuntos.Items.Add($"({(p.X)}, {(p.Y)})");
                listPuntos.Refresh();

                if (x0 == x1 && y0 == y1) break;

                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }
        }
    }
}
