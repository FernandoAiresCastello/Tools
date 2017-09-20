using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteExtractor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            TxtOffsetX.Text = PalettePictureBox.GetOffsetX().ToString();
            TxtOffsetY.Text = PalettePictureBox.GetOffsetY().ToString();
            TxtGapX.Text = PalettePictureBox.GetGapX().ToString();
            TxtGapY.Text = PalettePictureBox.GetGapX().ToString();

            CmbFormat.SelectedIndex = 0;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            PalettePictureBox.Image = Image.FromFile(dialog.FileName);
            PalettePictureBox.Location = new Point(0, 0);
            PalettePictureBox.Size = PalettePictureBox.Image.Size;
        }

        private void SetupTextChanged(object sender, EventArgs e)
        {
            try
            {
                PalettePictureBox.SetOffsetX(int.Parse(TxtOffsetX.Text));
                PalettePictureBox.SetOffsetY(int.Parse(TxtOffsetY.Text));
                PalettePictureBox.SetGapX(int.Parse(TxtGapX.Text));
                PalettePictureBox.SetGapY(int.Parse(TxtGapY.Text));

                PalettePictureBox.Refresh();
            }
            catch
            {
            }
        }

        private void BtnExtract_Click(object sender, EventArgs e)
        {
            List<Color> colors = PalettePictureBox.ExtractColors();

            string data = "Colors extracted: " + colors.Count + Environment.NewLine + Environment.NewLine;

            foreach (Color color in colors)
            {
                if (CmbFormat.SelectedIndex == 0)
                    data += TxtPrefix.Text + ToHexRgba(color) + TxtSuffix.Text + Environment.NewLine;
            }

            TxtData.Text = data;
        }

        private string ToHexRgba(Color color)
        {
            return string.Format("0x{0:X2}{1:X2}{2:X2}{3:X2}", color.R, color.G, color.B, color.A);
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtData.Text);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            List<Color> colors = PalettePictureBox.ExtractColors();
            byte[] rgbaArray = new byte[4 * colors.Count];
            int ptr = 0;

            foreach (Color color in colors)
            {
                rgbaArray[ptr++] = color.R;
                rgbaArray[ptr++] = color.G;
                rgbaArray[ptr++] = color.B;
                rgbaArray[ptr++] = color.A;
            }

            File.WriteAllBytes(dialog.FileName, rgbaArray);

            MessageBox.Show(colors.Count + " colors saved to binary file " + dialog.FileName, 
                "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSaveGimp_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            List<Color> colors = PalettePictureBox.ExtractColors();

            FileInfo fi = new FileInfo(dialog.FileName);
            string file = "GIMP Palette\nName: " + fi.Name + "\n#\n";
            foreach (Color color in colors)
            {
                file +=
                    color.R.ToString().PadLeft(3) + " " +
                    color.G.ToString().PadLeft(3) + " " +
                    color.B.ToString().PadLeft(3) + "\n";
            }

            File.WriteAllText(dialog.FileName, file);

            MessageBox.Show(colors.Count + " colors saved to GIMP palette file " + dialog.FileName,
                "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
