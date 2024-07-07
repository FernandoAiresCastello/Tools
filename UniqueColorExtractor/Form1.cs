using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniqueColorExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var image = Image.FromFile(dialog.FileName) as Bitmap;
            var colors = new HashSet<Color>();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);
                    colors.Add(color);
                }
            }

            TxtColors.Clear();

            foreach (Color color in colors)
            {
                string rgb = color.ToArgb().ToString("X06").Substring(2);
                TxtColors.Text += rgb + Environment.NewLine;
            }

            LblMessage.Text = "Unique colors: " + colors.Count;
        }
    }
}
