namespace PaletteExtractor
{
    partial class MainWindow
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
            this.PaletteImagePanel = new System.Windows.Forms.Panel();
            this.PalettePictureBox = new PaletteExtractor.PalettePictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.TxtOffsetX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOffsetY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGapX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGapY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSuffix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPrefix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbFormat = new System.Windows.Forms.ComboBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.BtnExtract = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnSaveBin = new System.Windows.Forms.Button();
            this.BtnSaveGimp = new System.Windows.Forms.Button();
            this.PaletteImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PalettePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaletteImagePanel
            // 
            this.PaletteImagePanel.AutoScroll = true;
            this.PaletteImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaletteImagePanel.Controls.Add(this.PalettePictureBox);
            this.PaletteImagePanel.Location = new System.Drawing.Point(12, 41);
            this.PaletteImagePanel.Name = "PaletteImagePanel";
            this.PaletteImagePanel.Size = new System.Drawing.Size(256, 256);
            this.PaletteImagePanel.TabIndex = 1;
            // 
            // PalettePictureBox
            // 
            this.PalettePictureBox.Location = new System.Drawing.Point(77, 70);
            this.PalettePictureBox.Name = "PalettePictureBox";
            this.PalettePictureBox.Size = new System.Drawing.Size(100, 105);
            this.PalettePictureBox.TabIndex = 0;
            this.PalettePictureBox.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(12, 12);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(256, 23);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load Palette Image";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TxtOffsetX
            // 
            this.TxtOffsetX.Location = new System.Drawing.Point(64, 23);
            this.TxtOffsetX.MaxLength = 4;
            this.TxtOffsetX.Name = "TxtOffsetX";
            this.TxtOffsetX.Size = new System.Drawing.Size(41, 20);
            this.TxtOffsetX.TabIndex = 3;
            this.TxtOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOffsetX.TextChanged += new System.EventHandler(this.SetupTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X Offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y Offset";
            // 
            // TxtOffsetY
            // 
            this.TxtOffsetY.Location = new System.Drawing.Point(64, 49);
            this.TxtOffsetY.MaxLength = 4;
            this.TxtOffsetY.Name = "TxtOffsetY";
            this.TxtOffsetY.Size = new System.Drawing.Size(41, 20);
            this.TxtOffsetY.TabIndex = 5;
            this.TxtOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOffsetY.TextChanged += new System.EventHandler(this.SetupTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X Gap";
            // 
            // TxtGapX
            // 
            this.TxtGapX.Location = new System.Drawing.Point(200, 23);
            this.TxtGapX.MaxLength = 4;
            this.TxtGapX.Name = "TxtGapX";
            this.TxtGapX.Size = new System.Drawing.Size(41, 20);
            this.TxtGapX.TabIndex = 7;
            this.TxtGapX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtGapX.TextChanged += new System.EventHandler(this.SetupTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y Gap";
            // 
            // TxtGapY
            // 
            this.TxtGapY.Location = new System.Drawing.Point(200, 49);
            this.TxtGapY.MaxLength = 4;
            this.TxtGapY.Name = "TxtGapY";
            this.TxtGapY.Size = new System.Drawing.Size(41, 20);
            this.TxtGapY.TabIndex = 9;
            this.TxtGapY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtGapY.TextChanged += new System.EventHandler(this.SetupTextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSuffix);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtPrefix);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CmbFormat);
            this.groupBox1.Controls.Add(this.TxtOffsetX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtGapY);
            this.groupBox1.Controls.Add(this.TxtOffsetY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtGapX);
            this.groupBox1.Location = new System.Drawing.Point(275, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // TxtSuffix
            // 
            this.TxtSuffix.Location = new System.Drawing.Point(64, 147);
            this.TxtSuffix.MaxLength = 32768;
            this.TxtSuffix.Name = "TxtSuffix";
            this.TxtSuffix.Size = new System.Drawing.Size(177, 20);
            this.TxtSuffix.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Suffix";
            // 
            // TxtPrefix
            // 
            this.TxtPrefix.Location = new System.Drawing.Point(64, 121);
            this.TxtPrefix.MaxLength = 32768;
            this.TxtPrefix.Name = "TxtPrefix";
            this.TxtPrefix.Size = new System.Drawing.Size(177, 20);
            this.TxtPrefix.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prefix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Format";
            // 
            // CmbFormat
            // 
            this.CmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormat.FormattingEnabled = true;
            this.CmbFormat.Items.AddRange(new object[] {
            "Hex RGBA (0xRRGGBBAA)"});
            this.CmbFormat.Location = new System.Drawing.Point(64, 85);
            this.CmbFormat.Name = "CmbFormat";
            this.CmbFormat.Size = new System.Drawing.Size(177, 21);
            this.CmbFormat.TabIndex = 11;
            // 
            // TxtData
            // 
            this.TxtData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData.Location = new System.Drawing.Point(537, 12);
            this.TxtData.Multiline = true;
            this.TxtData.Name = "TxtData";
            this.TxtData.ReadOnly = true;
            this.TxtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtData.Size = new System.Drawing.Size(256, 347);
            this.TxtData.TabIndex = 12;
            this.TxtData.Text = "Setup then click Extract";
            // 
            // BtnExtract
            // 
            this.BtnExtract.Location = new System.Drawing.Point(275, 202);
            this.BtnExtract.Name = "BtnExtract";
            this.BtnExtract.Size = new System.Drawing.Size(256, 23);
            this.BtnExtract.TabIndex = 13;
            this.BtnExtract.Text = "Extract";
            this.BtnExtract.UseVisualStyleBackColor = true;
            this.BtnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(537, 365);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(256, 23);
            this.BtnCopy.TabIndex = 14;
            this.BtnCopy.Text = "Copy to Clipboard";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnSaveBin
            // 
            this.BtnSaveBin.Location = new System.Drawing.Point(12, 303);
            this.BtnSaveBin.Name = "BtnSaveBin";
            this.BtnSaveBin.Size = new System.Drawing.Size(256, 23);
            this.BtnSaveBin.TabIndex = 15;
            this.BtnSaveBin.Text = "Save as Binary";
            this.BtnSaveBin.UseVisualStyleBackColor = true;
            this.BtnSaveBin.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSaveGimp
            // 
            this.BtnSaveGimp.Location = new System.Drawing.Point(12, 332);
            this.BtnSaveGimp.Name = "BtnSaveGimp";
            this.BtnSaveGimp.Size = new System.Drawing.Size(256, 23);
            this.BtnSaveGimp.TabIndex = 16;
            this.BtnSaveGimp.Text = "Save as GIMP Palette";
            this.BtnSaveGimp.UseVisualStyleBackColor = true;
            this.BtnSaveGimp.Click += new System.EventHandler(this.BtnSaveGimp_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 399);
            this.Controls.Add(this.BtnSaveGimp);
            this.Controls.Add(this.BtnSaveBin);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.BtnExtract);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.PaletteImagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palette Extractor";
            this.PaletteImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PalettePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PaletteImagePanel;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.TextBox TxtOffsetX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOffsetY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGapX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGapY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Button BtnExtract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbFormat;
        private PalettePictureBox PalettePictureBox;
        private System.Windows.Forms.TextBox TxtSuffix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPrefix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnSaveBin;
        private System.Windows.Forms.Button BtnSaveGimp;
    }
}

