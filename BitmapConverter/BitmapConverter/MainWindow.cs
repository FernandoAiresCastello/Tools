using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapConverter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            PnlStatus.Visible = false;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            ImageBox.Image = Image.FromFile(dialog.FileName);
            ImageBox.Size = ImageBox.Image.Size;

            PnlStatus.Visible = true;

            LblFilename.Text = "Path: " + dialog.FileName;
            LblSize.Text = "Dimensions: " + ImageBox.Image.Size.Width + "x" + ImageBox.Image.Size.Height;
            LblPixelCount.Text = "Pixel count: " + (ImageBox.Image.Size.Width * ImageBox.Image.Size.Height);

            TxtOutput.Text = "";
        }

        private void BtnConvertCppRGBArray_Click(object sender, EventArgs e)
        {
            if (ImageBox.Image == null)
                return;

            Bitmap bitmap = (Bitmap)ImageBox.Image;
            int size = bitmap.Height * bitmap.Width;
            Color[] pixels = new Color[size];
            int pi = 0;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                    pixels[pi++] = bitmap.GetPixel(x, y);

            string output = "int bitmap[" + size + "] = " + Environment.NewLine + "{";

            for (int i = 0; i < pixels.Length; i++)
            {
                if (i % 16 == 0)
                    output += Environment.NewLine + "\t";

                output += "0x" + pixels[i].ToArgb().ToString("X8").Substring(2);

                if (i < pixels.Length - 1)
                    output += ",";
            }

            TxtOutput.Text = (output += Environment.NewLine + "};" + Environment.NewLine);
        }

        private void TxtOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                TxtOutput.SelectAll();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
