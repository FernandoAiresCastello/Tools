using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Globalization;

namespace FileCorruptor
{
    public partial class MainWindow : Form
    {
        private string FileOriginal = "";
        private string FileCorrupted = "";
        private int RangeStart = 0;
        private int RangeEnd = 0;
        private int RangeStep = 0;
        private bool RangeStepRandom = false;
        private int RangeStepRandomMin = 0;
        private int RangeStepRandomMax = 0;

        private byte[] FileBytes = null;
        private Random Random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            TxtFileOriginal.Text = dialog.FileName;
            TxtFileCorrupted.Text = Path.ChangeExtension(dialog.FileName, "corr");
        }

        private void BtnOverwrite_Click(object sender, EventArgs e)
        {
            TxtFileCorrupted.Text = TxtFileOriginal.Text;
        }

        private void Error(string title, string message)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Info(string title, string message)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCorrupt_Click(object sender, EventArgs e)
        {
            FileOriginal = TxtFileOriginal.Text.Trim();
            FileCorrupted = TxtFileCorrupted.Text.Trim();
            RangeStart = int.Parse(TextToDecimal(TxtRangeStart));
            RangeEnd = int.Parse(TextToDecimal(TxtRangeEnd));
            RangeStepRandom = RbStepRandom.Checked;
            RangeStep = int.Parse(TxtRangeStep.Text.Trim());
            RangeStepRandomMin = int.Parse(TxtRangeStepRandomMin.Text.Trim());
            RangeStepRandomMax = int.Parse(TxtRangeStepRandomMax.Text.Trim());

            FileBytes = File.ReadAllBytes(FileOriginal);

            if (RangeEnd >= FileBytes.Length)
            {
                Error("Setup error", "Range end must be smaller than " + FileBytes.Length);
                return;
            }
            if (RangeEnd < RangeStart)
            {
                Error("Setup error", "Range end must be greater than or equal to range start");
                return;
            }
            if (RangeStart < 0)
            {
                Error("Setup error", "Range start must be greater than or equal to 0");
                return;
            }
            if (RangeStep < 1)
            {
                Error("Setup error", "Range step must be larger than 0");
                return;
            }

            ProgressBar.Step = 1;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = RangeEnd - RangeStart;

            Thread t = null;

            if (RbRandomize.Checked)
                t = new Thread(p => CorruptRandomize(int.Parse(TxtRandomMin.Text.Trim()), int.Parse(TxtRandomMax.Text.Trim())));
            else if (RbReplace.Checked)
                t = new Thread(p => CorruptReplace(int.Parse(TxtReplaceFrom.Text.Trim()), int.Parse(TxtReplaceTo.Text.Trim())));
            else if (RbAdd.Checked)
                t = new Thread(p => CorruptAdd(int.Parse(TxtAdd.Text.Trim())));
            else if (RbShiftRight.Checked)
                t = new Thread(p => CorruptShiftRight(int.Parse(TxtShiftRight.Text.Trim())));

            if (t != null)
            {
                EnableUI(false);
                t.Start();
            }
        }

        private void TxtFileOriginal_TextChanged(object sender, EventArgs e)
        {
            string file = TxtFileOriginal.Text.Trim();
            if (string.IsNullOrEmpty(file) || !File.Exists(file))
                return;

            FileInfo info = new FileInfo(file);

            LblFileLength.Text = "File length: " + info.Length + " bytes";
            LblValidRange.Text = "Valid range: 0-" + (info.Length - 1) + " (0x0000-" + (info.Length - 1).ToString("X") + ")";
        }

        private string TextToDecimal(TextBox textBox)
        {
            string range = textBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(range))
                return null;

            if (range.StartsWith("0x"))
            {
                range = range.Substring(2);
                int rangeDecimal = int.Parse(range, NumberStyles.HexNumber);
                return rangeDecimal.ToString();
            }

            return range;
        }

        private void TxtRangeStep_Validated(object sender, EventArgs e)
        {
            if (int.Parse(TxtRangeStep.Text.Trim()) < 1)
                TxtRangeStep.Text = "1";
        }

        private void EnableUI(bool enable)
        {
            Invoke((MethodInvoker)delegate { PnlFile.Enabled = enable; });
            Invoke((MethodInvoker)delegate { PnlSetup.Enabled = enable; });
            Invoke((MethodInvoker)delegate { BtnCorrupt.Enabled = enable; });
        }

        private void OnCorruptionFinished()
        {
            File.WriteAllBytes(FileCorrupted, FileBytes);

            EnableUI(true);
            Invoke((MethodInvoker)delegate { BtnCorrupt.Text = "Corrupt!"; });
            Invoke((MethodInvoker)delegate { BtnCorrupt.Invalidate(); });
            Invoke((MethodInvoker)delegate { ProgressBar.Value = 0; });

            MessageBox.Show("Corruption completed successfully!", "Corruption completed", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateProgress()
        {
            string status = "Corrupting byte " + ProgressBar.Value + " of " + ProgressBar.Maximum + " ...";

            Invoke((MethodInvoker)delegate { BtnCorrupt.Text = status; });
            Invoke((MethodInvoker)delegate { ProgressBar.PerformStep(); });
        }

        private int GetRandomStep()
        {
            return Random.Next(RangeStepRandomMin, RangeStepRandomMax + 1);
        }

        private void CorruptRandomize(int min, int max)
        {
            for (int i = RangeStart; i <= RangeEnd; i+= (RangeStepRandom ? GetRandomStep() : RangeStep))
            {
                FileBytes[i] = (byte)Random.Next(min, max + 1);
                UpdateProgress();
            }

            OnCorruptionFinished();
        }

        private void CorruptReplace(int from, int to)
        {
            for (int i = RangeStart; i <= RangeEnd; i += (RangeStepRandom ? GetRandomStep() : RangeStep))
            {
                if (FileBytes[i] == from)
                    FileBytes[i] = (byte)to;

                UpdateProgress();
            }

            OnCorruptionFinished();
        }

        private void CorruptAdd(int value)
        {
            for (int i = RangeStart; i <= RangeEnd; i += (RangeStepRandom ? GetRandomStep() : RangeStep))
            {
                FileBytes[i] += (byte)value;
                UpdateProgress();
            }

            OnCorruptionFinished();
        }

        private void CorruptShiftRight(int value)
        {
            for (int i = RangeStart; i <= RangeEnd; i += (RangeStepRandom ? GetRandomStep() : RangeStep))
            {
                FileBytes[i] >>= (byte)value;
                UpdateProgress();
            }

            OnCorruptionFinished();
        }
    }
}
