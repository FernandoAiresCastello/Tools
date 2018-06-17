using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BatchFileOperations
{
    public partial class RenameFilesForm : Form
    {
        private List<string> Files = new List<string>();

        public RenameFilesForm()
        {
            InitializeComponent();
            UpdateTextBoxes();
        }

        private void Inform(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Error(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateTextBoxes()
        {
            TxtAppendNumber.Enabled = RbAppendNumber.Checked;
            TxtAppendText.Enabled = RbAppendText.Checked;
            TxtRemoveText.Enabled = RbRemoveText.Checked;
            TxtReplaceTextFrom.Enabled = TxtReplaceTextTo.Enabled = RbReplaceText.Checked;
            TxtChangeExt.Enabled = RbChangeExt.Checked;

            if (!TxtAppendNumber.Enabled)
                TxtAppendNumber.Clear();
            if (!TxtAppendText.Enabled)
                TxtAppendText.Clear();
            if (!TxtRemoveText.Enabled)
                TxtRemoveText.Clear();
            if (!TxtReplaceTextFrom.Enabled)
                TxtReplaceTextFrom.Clear();
            if (!TxtReplaceTextTo.Enabled)
                TxtReplaceTextTo.Clear();
            if (!TxtChangeExt.Enabled)
                TxtChangeExt.Clear();
        }

        private void UncheckRadioButtons()
        {
            RbReplaceText.Checked =
            RbRemoveText.Checked =
            RbAppendText.Checked =
            RbAppendNumber.Checked = 
            RbChangeExt.Checked = false;
        }

        private void RbRemoveText_MouseClick(object sender, MouseEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                UncheckRadioButtons();
                radio.Checked = true;
                UpdateTextBoxes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFilesToRename();

            if (RbRemoveText.Checked)
                RemoveText(TxtRemoveText.Text);
            else if (RbAppendText.Checked)
                AppendText(TxtAppendText.Text);
            else if (RbAppendNumber.Checked)
                AppendNumber(TxtAppendNumber.Text);
            else if (RbReplaceText.Checked)
                ReplaceText(TxtReplaceTextFrom.Text, TxtReplaceTextTo.Text);
            else if (RbChangeExt.Checked)
                ChangeExtension(TxtChangeExt.Text);
            else
                Error("You must select an operation.");
        }

        private void GetFilesToRename()
        {
            Files.Clear();

            string folder = TxtFolder.Text.Trim();
            string extensionList = TxtExtensions.Text.Trim();
            string[] extensions = extensionList.Split(',');
            DirectoryInfo dirinfo = new DirectoryInfo(folder);
            FileInfo[] fileinfos = dirinfo.GetFiles();

            foreach (FileInfo info in fileinfos)
            {
                foreach (string ext in extensions)
                {
                    if (ext.Trim() == info.Extension.Replace(".", ""))
                        Files.Add(info.FullName);
                }
            }
        }

        private void RemoveText(string text)
        {
            foreach (string file in Files)
                File.Move(file, file.Replace(text, ""));

            Inform("Operation Successful!");
        }

        private void AppendText(string text)
        {
            foreach (string file in Files)
            {
                string ext = new FileInfo(file).Extension;
                File.Move(file, file.Replace(ext, text + ext));
            }

            Inform("Operation Successful!");
        }

        private void ReplaceText(string original, string replacement)
        {
            foreach (string file in Files)
                File.Move(file, file.Replace(original, replacement));

            Inform("Operation Successful!");
        }

        private void ChangeExtension(string newext)
        {
            foreach (string file in Files)
                File.Move(file, file.Replace(new FileInfo(file).Extension, "." + newext));

            Inform("Operation Successful!");
        }

        private void AppendNumber(string prefix)
        {
            int number = 0;

            foreach (string file in Files)
            {
                string ext = new FileInfo(file).Extension;
                File.Move(file, file.Replace(ext, prefix + number + ext));
                number++;
            }

            Inform("Operation Successful!");
        }
    }
}
