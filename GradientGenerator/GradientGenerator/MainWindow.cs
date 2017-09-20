using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GradientGenerator
{
    public partial class MainWindow : Form
    {
        public Bitmap SampleImage;

        public MainWindow()
        {
            InitializeComponent();

            SampleImage = new Bitmap(GradientBox.ClientSize.Width, GradientBox.ClientSize.Height);
            GradientBox.Image = SampleImage;

            UpdateSample();
        }

        private void ColorTop_Click(object sender, EventArgs e)
        {
            SelectAndSetBackColor(sender as Panel);
        }

        private void ColorMiddle_Click(object sender, EventArgs e)
        {
            SelectAndSetBackColor(sender as Panel);
        }

        private void ColorBottom_Click(object sender, EventArgs e)
        {
            SelectAndSetBackColor(sender as Panel);
        }

        private void SelectAndSetBackColor(Panel panel)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = panel.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
                panel.BackColor = dialog.Color;

            UpdateSample();
        }
        
        private void FillGradient(Bitmap image, Color top, Color middle, Color bottom)
        {
            ColorBlend colors = new ColorBlend(3);
            colors.Colors[0] = top;
            colors.Colors[1] = middle;
            colors.Colors[2] = bottom;
            colors.Positions[0] = 0.0f;
            colors.Positions[1] = 0.5f;
            colors.Positions[2] = 1.0f;

            LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(0, image.Height), Color.White, Color.Black);
            brush.InterpolationColors = colors;

            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(brush, 0, 0, image.Size.Width, image.Size.Height);
        }

        private void UpdateSample()
        {
            FillGradient(SampleImage, ColorTop.BackColor, ColorMiddle.BackColor, ColorBottom.BackColor);
            GradientBox.Invalidate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int width = 0;
            int height = 0;

            try
            {
                width = int.Parse(TxtWidth.Text.Trim());
                height = int.Parse(TxtHeight.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string path = TxtPath.Text.Trim();

            if (width > 0 && height > 0)
                SaveImage(width, height, path);
        }

        private void SaveImage(int width, int height, string path)
        {
            Bitmap image = new Bitmap(width, height);
            FillGradient(image, ColorTop.BackColor, ColorMiddle.BackColor, ColorBottom.BackColor);

            try
            {
                image.Save(path);
                MessageBox.Show("Saved OK", "Image saved successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
