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
    internal class RellenoC
    {

        public async Task FloodFillAsync(Bitmap bmp, PictureBox pic, int x, int y, Color objetivo, Color nuevoColor, int delayMs = 1)
        {
            if (objetivo.ToArgb() == nuevoColor.ToArgb()) return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(new Point(x, y));

            while (cola.Count > 0)
            {
                Point p = cola.Dequeue();
                if (p.X < 0 || p.X >= bmp.Width || p.Y < 0 || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() != objetivo.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, nuevoColor);

                // Refresca la imagen del PictureBox
                if (cola.Count % 100 == 0)
                {
                    pic.Image = (Bitmap)bmp.Clone(); // evita parpadeo
                    await Task.Delay(delayMs);
                }

                cola.Enqueue(new Point(p.X + 1, p.Y));
                cola.Enqueue(new Point(p.X - 1, p.Y));
                cola.Enqueue(new Point(p.X, p.Y + 1));
                cola.Enqueue(new Point(p.X, p.Y - 1));
            }

            pic.Image = bmp; 
        }


    }
}
