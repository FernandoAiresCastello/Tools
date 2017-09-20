using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PaletteExtractor
{
    class PalettePictureBox : PictureBox
    {
        public int OffsetX;
        public int OffsetY;
        public int GapX;
        public int GapY;

        public int GetOffsetX() { return OffsetX; }
        public int GetOffsetY() { return OffsetY; }
        public int GetGapX() { return GapX; }
        public int GetGapY() { return GapY; }

        public void SetOffsetX(int value) { OffsetX = value; }
        public void SetOffsetY(int value) { OffsetY = value; }
        public void SetGapX(int value) { GapX = value; }
        public void SetGapY(int value) { GapY = value; }

        public PalettePictureBox()
        {
            OffsetX = 0;
            OffsetY = 0;
            GapX = 10;
            GapY = 10;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Image == null)
                return;

            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    e.Graphics.FillRectangle(Brushes.White, OffsetX + x, OffsetY + y, 1, 1);
                    x += GapX;
                }
                y += GapY;
            }
        }

        public List<Color> ExtractColors()
        {
            List<Color> colors = new List<Color>();
            Bitmap bitmap = (Bitmap)Image;

            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    int px = OffsetX + x;
                    int py = OffsetY + y;

                    if (px < Image.Width && py < Image.Height)
                        colors.Add(bitmap.GetPixel(px, py));

                    x += GapX;
                }
                y += GapY;
            }

            return colors;
        }
    }
}
