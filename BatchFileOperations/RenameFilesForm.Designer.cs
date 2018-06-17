namespace BatchFileOperations
{
    partial class RenameFilesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtExtensions = new System.Windows.Forms.TextBox();
            this.TxtRemoveText = new System.Windows.Forms.TextBox();
            this.TxtAppendText = new System.Windows.Forms.TextBox();
            this.TxtReplaceTextFrom = new System.Windows.Forms.TextBox();
            this.TxtAppendNumber = new System.Windows.Forms.TextBox();
            this.RbRemoveText = new System.Windows.Forms.RadioButton();
            this.RbAppendText = new System.Windows.Forms.RadioButton();
            this.RbReplaceText = new System.Windows.Forms.RadioButton();
            this.RbAppendNumber = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFolder = new System.Windows.Forms.TextBox();
            this.TxtReplaceTextTo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RbChangeExt = new System.Windows.Forms.RadioButton();
            this.TxtChangeExt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rename files in folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "File extensions";
            // 
            // TxtExtensions
            // 
            this.TxtExtensions.Location = new System.Drawing.Point(121, 73);
            this.TxtExtensions.Name = "TxtExtensions";
            this.TxtExtensions.Size = new System.Drawing.Size(405, 23);
            this.TxtExtensions.TabIndex = 1;
            // 
            // TxtRemoveText
            // 
            this.TxtRemoveText.Location = new System.Drawing.Point(223, 12);
            this.TxtRemoveText.Name = "TxtRemoveText";
            this.TxtRemoveText.Size = new System.Drawing.Size(271, 23);
            this.TxtRemoveText.TabIndex = 3;
            // 
            // TxtAppendText
            // 
            this.TxtAppendText.Location = new System.Drawing.Point(223, 40);
            this.TxtAppendText.Name = "TxtAppendText";
            this.TxtAppendText.Size = new System.Drawing.Size(271, 23);
            this.TxtAppendText.TabIndex = 5;
            // 
            // TxtReplaceTextFrom
            // 
            this.TxtReplaceTextFrom.Location = new System.Drawing.Point(223, 68);
            this.TxtReplaceTextFrom.Name = "TxtReplaceTextFrom";
            this.TxtReplaceTextFrom.Size = new System.Drawing.Size(132, 23);
            this.TxtReplaceTextFrom.TabIndex = 7;
            // 
            // TxtAppendNumber
            // 
            this.TxtAppendNumber.Location = new System.Drawing.Point(223, 96);
            this.TxtAppendNumber.Name = "TxtAppendNumber";
            this.TxtAppendNumber.Size = new System.Drawing.Size(271, 23);
            this.TxtAppendNumber.TabIndex = 10;
            // 
            // RbRemoveText
            // 
            this.RbRemoveText.AutoSize = true;
            this.RbRemoveText.Location = new System.Drawing.Point(13, 13);
            this.RbRemoveText.Name = "RbRemoveText";
            this.RbRemoveText.Size = new System.Drawing.Size(193, 20);
            this.RbRemoveText.TabIndex = 2;
            this.RbRemoveText.TabStop = true;
            this.RbRemoveText.Text = "Remove text from filename";
            this.RbRemoveText.UseVisualStyleBackColor = true;
            this.RbRemoveText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbRemoveText_MouseClick);
            // 
            // RbAppendText
            // 
            this.RbAppendText.AutoSize = true;
            this.RbAppendText.Location = new System.Drawing.Point(13, 41);
            this.RbAppendText.Name = "RbAppendText";
            this.RbAppendText.Size = new System.Drawing.Size(174, 20);
            this.RbAppendText.TabIndex = 4;
            this.RbAppendText.TabStop = true;
            this.RbAppendText.Text = "Append text to filename";
            this.RbAppendText.UseVisualStyleBackColor = true;
            this.RbAppendText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbRemoveText_MouseClick);
            // 
            // RbReplaceText
            // 
            this.RbReplaceText.AutoSize = true;
            this.RbReplaceText.Location = new System.Drawing.Point(13, 69);
            this.RbReplaceText.Name = "RbReplaceText";
            this.RbReplaceText.Size = new System.Drawing.Size(176, 20);
            this.RbReplaceText.TabIndex = 6;
            this.RbReplaceText.TabStop = true;
            this.RbReplaceText.Text = "Replace text in filename";
            this.RbReplaceText.UseVisualStyleBackColor = true;
            this.RbReplaceText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbRemoveText_MouseClick);
            // 
            // RbAppendNumber
            // 
            this.RbAppendNumber.AutoSize = true;
            this.RbAppendNumber.Location = new System.Drawing.Point(13, 97);
            this.RbAppendNumber.Name = "RbAppendNumber";
            this.RbAppendNumber.Size = new System.Drawing.Size(200, 20);
            this.RbAppendNumber.TabIndex = 9;
            this.RbAppendNumber.TabStop = true;
            this.RbAppendNumber.Text = "Append number to filename";
            this.RbAppendNumber.UseVisualStyleBackColor = true;
            this.RbAppendNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbRemoveText_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RbChangeExt);
            this.panel1.Controls.Add(this.TxtChangeExt);
            this.panel1.Controls.Add(this.TxtReplaceTextTo);
            this.panel1.Controls.Add(this.RbRemoveText);
            this.panel1.Controls.Add(this.RbAppendNumber);
            this.panel1.Controls.Add(this.TxtRemoveText);
            this.panel1.Controls.Add(this.RbReplaceText);
            this.panel1.Controls.Add(this.TxtAppendText);
            this.panel1.Controls.Add(this.RbAppendText);
            this.panel1.Controls.Add(this.TxtReplaceTextFrom);
            this.panel1.Controls.Add(this.TxtAppendNumber);
            this.panel1.Location = new System.Drawing.Point(15, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 162);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Folder";
            // 
            // TxtFolder
            // 
            this.TxtFolder.Location = new System.Drawing.Point(121, 44);
            this.TxtFolder.Name = "TxtFolder";
            this.TxtFolder.Size = new System.Drawing.Size(405, 23);
            this.TxtFolder.TabIndex = 0;
            // 
            // TxtReplaceTextTo
            // 
            this.TxtReplaceTextTo.Location = new System.Drawing.Point(362, 67);
            this.TxtReplaceTextTo.Name = "TxtReplaceTextTo";
            this.TxtReplaceTextTo.Size = new System.Drawing.Size(132, 23);
            this.TxtReplaceTextTo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(511, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbChangeExt
            // 
            this.RbChangeExt.AutoSize = true;
            this.RbChangeExt.Location = new System.Drawing.Point(13, 125);
            this.RbChangeExt.Name = "RbChangeExt";
            this.RbChangeExt.Size = new System.Drawing.Size(162, 20);
            this.RbChangeExt.TabIndex = 11;
            this.RbChangeExt.TabStop = true;
            this.RbChangeExt.Text = "Change file extension";
            this.RbChangeExt.UseVisualStyleBackColor = true;
            this.RbChangeExt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbRemoveText_MouseClick);
            // 
            // TxtChangeExt
            // 
            this.TxtChangeExt.Location = new System.Drawing.Point(223, 124);
            this.TxtChangeExt.Name = "TxtChangeExt";
            this.TxtChangeExt.Size = new System.Drawing.Size(271, 23);
            this.TxtChangeExt.TabIndex = 12;
            // 
            // RenameFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtExtensions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RenameFilesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch File Operations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtExtensions;
        private System.Windows.Forms.TextBox TxtRemoveText;
        private System.Windows.Forms.TextBox TxtAppendText;
        private System.Windows.Forms.TextBox TxtReplaceTextFrom;
        private System.Windows.Forms.TextBox TxtAppendNumber;
        private System.Windows.Forms.RadioButton RbRemoveText;
        private System.Windows.Forms.RadioButton RbAppendText;
        private System.Windows.Forms.RadioButton RbReplaceText;
        private System.Windows.Forms.RadioButton RbAppendNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFolder;
        private System.Windows.Forms.TextBox TxtReplaceTextTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RbChangeExt;
        private System.Windows.Forms.TextBox TxtChangeExt;
    }
}

