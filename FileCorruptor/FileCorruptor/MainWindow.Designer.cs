namespace FileCorruptor
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
            this.TxtFileOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFileCorrupted = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnOverwrite = new System.Windows.Forms.Button();
            this.PnlFile = new System.Windows.Forms.GroupBox();
            this.PnlSetup = new System.Windows.Forms.GroupBox();
            this.TxtRangeStepRandomMax = new System.Windows.Forms.TextBox();
            this.RbStepRandom = new System.Windows.Forms.RadioButton();
            this.TxtRangeStepRandomMin = new System.Windows.Forms.TextBox();
            this.RbStepFixed = new System.Windows.Forms.RadioButton();
            this.LblValidRange = new System.Windows.Forms.Label();
            this.LblFileLength = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtShiftRight = new System.Windows.Forms.TextBox();
            this.RbShiftRight = new System.Windows.Forms.RadioButton();
            this.RbReplace = new System.Windows.Forms.RadioButton();
            this.TxtReplaceTo = new System.Windows.Forms.TextBox();
            this.TxtReplaceFrom = new System.Windows.Forms.TextBox();
            this.RbRandomize = new System.Windows.Forms.RadioButton();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.RbAdd = new System.Windows.Forms.RadioButton();
            this.TxtRandomMax = new System.Windows.Forms.TextBox();
            this.TxtRandomMin = new System.Windows.Forms.TextBox();
            this.TxtRangeStep = new System.Windows.Forms.TextBox();
            this.TxtRangeEnd = new System.Windows.Forms.TextBox();
            this.TxtRangeStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCorrupt = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PnlFile.SuspendLayout();
            this.PnlSetup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtFileOriginal
            // 
            this.TxtFileOriginal.Location = new System.Drawing.Point(85, 15);
            this.TxtFileOriginal.Name = "TxtFileOriginal";
            this.TxtFileOriginal.Size = new System.Drawing.Size(313, 20);
            this.TxtFileOriginal.TabIndex = 0;
            this.TxtFileOriginal.TextChanged += new System.EventHandler(this.TxtFileOriginal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Corrupted file";
            // 
            // TxtFileCorrupted
            // 
            this.TxtFileCorrupted.Location = new System.Drawing.Point(85, 41);
            this.TxtFileCorrupted.Name = "TxtFileCorrupted";
            this.TxtFileCorrupted.Size = new System.Drawing.Size(313, 20);
            this.TxtFileCorrupted.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(404, 13);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(94, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnOverwrite
            // 
            this.BtnOverwrite.Location = new System.Drawing.Point(404, 39);
            this.BtnOverwrite.Name = "BtnOverwrite";
            this.BtnOverwrite.Size = new System.Drawing.Size(94, 23);
            this.BtnOverwrite.TabIndex = 5;
            this.BtnOverwrite.Text = "Overwrite";
            this.BtnOverwrite.UseVisualStyleBackColor = true;
            this.BtnOverwrite.Click += new System.EventHandler(this.BtnOverwrite_Click);
            // 
            // PnlFile
            // 
            this.PnlFile.Controls.Add(this.label1);
            this.PnlFile.Controls.Add(this.BtnOverwrite);
            this.PnlFile.Controls.Add(this.TxtFileOriginal);
            this.PnlFile.Controls.Add(this.BtnSearch);
            this.PnlFile.Controls.Add(this.TxtFileCorrupted);
            this.PnlFile.Controls.Add(this.label2);
            this.PnlFile.Location = new System.Drawing.Point(12, 6);
            this.PnlFile.Name = "PnlFile";
            this.PnlFile.Size = new System.Drawing.Size(509, 70);
            this.PnlFile.TabIndex = 6;
            this.PnlFile.TabStop = false;
            // 
            // PnlSetup
            // 
            this.PnlSetup.Controls.Add(this.TxtRangeStepRandomMax);
            this.PnlSetup.Controls.Add(this.RbStepRandom);
            this.PnlSetup.Controls.Add(this.TxtRangeStepRandomMin);
            this.PnlSetup.Controls.Add(this.RbStepFixed);
            this.PnlSetup.Controls.Add(this.LblValidRange);
            this.PnlSetup.Controls.Add(this.LblFileLength);
            this.PnlSetup.Controls.Add(this.groupBox3);
            this.PnlSetup.Controls.Add(this.TxtRangeStep);
            this.PnlSetup.Controls.Add(this.TxtRangeEnd);
            this.PnlSetup.Controls.Add(this.TxtRangeStart);
            this.PnlSetup.Controls.Add(this.label3);
            this.PnlSetup.Location = new System.Drawing.Point(12, 82);
            this.PnlSetup.Name = "PnlSetup";
            this.PnlSetup.Size = new System.Drawing.Size(508, 162);
            this.PnlSetup.TabIndex = 7;
            this.PnlSetup.TabStop = false;
            // 
            // TxtRangeStepRandomMax
            // 
            this.TxtRangeStepRandomMax.Location = new System.Drawing.Point(177, 77);
            this.TxtRangeStepRandomMax.Name = "TxtRangeStepRandomMax";
            this.TxtRangeStepRandomMax.Size = new System.Drawing.Size(33, 20);
            this.TxtRangeStepRandomMax.TabIndex = 22;
            this.TxtRangeStepRandomMax.Text = "1";
            // 
            // RbStepRandom
            // 
            this.RbStepRandom.AutoSize = true;
            this.RbStepRandom.Location = new System.Drawing.Point(11, 78);
            this.RbStepRandom.Name = "RbStepRandom";
            this.RbStepRandom.Size = new System.Drawing.Size(88, 17);
            this.RbStepRandom.TabIndex = 21;
            this.RbStepRandom.Text = "Random step";
            this.RbStepRandom.UseVisualStyleBackColor = true;
            // 
            // TxtRangeStepRandomMin
            // 
            this.TxtRangeStepRandomMin.Location = new System.Drawing.Point(140, 77);
            this.TxtRangeStepRandomMin.Name = "TxtRangeStepRandomMin";
            this.TxtRangeStepRandomMin.Size = new System.Drawing.Size(33, 20);
            this.TxtRangeStepRandomMin.TabIndex = 20;
            this.TxtRangeStepRandomMin.Text = "1";
            // 
            // RbStepFixed
            // 
            this.RbStepFixed.AutoSize = true;
            this.RbStepFixed.Checked = true;
            this.RbStepFixed.Location = new System.Drawing.Point(11, 55);
            this.RbStepFixed.Name = "RbStepFixed";
            this.RbStepFixed.Size = new System.Drawing.Size(73, 17);
            this.RbStepFixed.TabIndex = 19;
            this.RbStepFixed.TabStop = true;
            this.RbStepFixed.Text = "Fixed step";
            this.RbStepFixed.UseVisualStyleBackColor = true;
            // 
            // LblValidRange
            // 
            this.LblValidRange.AutoSize = true;
            this.LblValidRange.Location = new System.Drawing.Point(8, 137);
            this.LblValidRange.Name = "LblValidRange";
            this.LblValidRange.Size = new System.Drawing.Size(69, 13);
            this.LblValidRange.TabIndex = 18;
            this.LblValidRange.Text = "Valid range: -";
            // 
            // LblFileLength
            // 
            this.LblFileLength.AutoSize = true;
            this.LblFileLength.Location = new System.Drawing.Point(8, 117);
            this.LblFileLength.Name = "LblFileLength";
            this.LblFileLength.Size = new System.Drawing.Size(64, 13);
            this.LblFileLength.TabIndex = 17;
            this.LblFileLength.Text = "File length: -";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtShiftRight);
            this.groupBox3.Controls.Add(this.RbShiftRight);
            this.groupBox3.Controls.Add(this.RbReplace);
            this.groupBox3.Controls.Add(this.TxtReplaceTo);
            this.groupBox3.Controls.Add(this.TxtReplaceFrom);
            this.groupBox3.Controls.Add(this.RbRandomize);
            this.groupBox3.Controls.Add(this.TxtAdd);
            this.groupBox3.Controls.Add(this.RbAdd);
            this.groupBox3.Controls.Add(this.TxtRandomMax);
            this.groupBox3.Controls.Add(this.TxtRandomMin);
            this.groupBox3.Location = new System.Drawing.Point(247, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 135);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Corruption Mode";
            // 
            // TxtShiftRight
            // 
            this.TxtShiftRight.Location = new System.Drawing.Point(129, 102);
            this.TxtShiftRight.Name = "TxtShiftRight";
            this.TxtShiftRight.Size = new System.Drawing.Size(50, 20);
            this.TxtShiftRight.TabIndex = 20;
            this.TxtShiftRight.Text = "0";
            // 
            // RbShiftRight
            // 
            this.RbShiftRight.AutoSize = true;
            this.RbShiftRight.Location = new System.Drawing.Point(14, 102);
            this.RbShiftRight.Name = "RbShiftRight";
            this.RbShiftRight.Size = new System.Drawing.Size(69, 17);
            this.RbShiftRight.TabIndex = 19;
            this.RbShiftRight.Text = "Shift right";
            this.RbShiftRight.UseVisualStyleBackColor = true;
            // 
            // RbReplace
            // 
            this.RbReplace.AutoSize = true;
            this.RbReplace.Location = new System.Drawing.Point(14, 50);
            this.RbReplace.Name = "RbReplace";
            this.RbReplace.Size = new System.Drawing.Size(93, 17);
            this.RbReplace.TabIndex = 16;
            this.RbReplace.Text = "Replace bytes";
            this.RbReplace.UseVisualStyleBackColor = true;
            // 
            // TxtReplaceTo
            // 
            this.TxtReplaceTo.Location = new System.Drawing.Point(182, 50);
            this.TxtReplaceTo.Name = "TxtReplaceTo";
            this.TxtReplaceTo.Size = new System.Drawing.Size(50, 20);
            this.TxtReplaceTo.TabIndex = 18;
            this.TxtReplaceTo.Text = "0";
            // 
            // TxtReplaceFrom
            // 
            this.TxtReplaceFrom.Location = new System.Drawing.Point(129, 50);
            this.TxtReplaceFrom.Name = "TxtReplaceFrom";
            this.TxtReplaceFrom.Size = new System.Drawing.Size(50, 20);
            this.TxtReplaceFrom.TabIndex = 17;
            this.TxtReplaceFrom.Text = "0";
            // 
            // RbRandomize
            // 
            this.RbRandomize.AutoSize = true;
            this.RbRandomize.Checked = true;
            this.RbRandomize.Location = new System.Drawing.Point(14, 24);
            this.RbRandomize.Name = "RbRandomize";
            this.RbRandomize.Size = new System.Drawing.Size(106, 17);
            this.RbRandomize.TabIndex = 9;
            this.RbRandomize.TabStop = true;
            this.RbRandomize.Text = "Randomize bytes";
            this.RbRandomize.UseVisualStyleBackColor = true;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(129, 76);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(50, 20);
            this.TxtAdd.TabIndex = 15;
            this.TxtAdd.Text = "0";
            // 
            // RbAdd
            // 
            this.RbAdd.AutoSize = true;
            this.RbAdd.Location = new System.Drawing.Point(14, 76);
            this.RbAdd.Name = "RbAdd";
            this.RbAdd.Size = new System.Drawing.Size(79, 17);
            this.RbAdd.TabIndex = 10;
            this.RbAdd.Text = "Add to byte";
            this.RbAdd.UseVisualStyleBackColor = true;
            // 
            // TxtRandomMax
            // 
            this.TxtRandomMax.Location = new System.Drawing.Point(182, 24);
            this.TxtRandomMax.Name = "TxtRandomMax";
            this.TxtRandomMax.Size = new System.Drawing.Size(50, 20);
            this.TxtRandomMax.TabIndex = 14;
            this.TxtRandomMax.Text = "255";
            // 
            // TxtRandomMin
            // 
            this.TxtRandomMin.Location = new System.Drawing.Point(129, 24);
            this.TxtRandomMin.Name = "TxtRandomMin";
            this.TxtRandomMin.Size = new System.Drawing.Size(50, 20);
            this.TxtRandomMin.TabIndex = 13;
            this.TxtRandomMin.Text = "0";
            // 
            // TxtRangeStep
            // 
            this.TxtRangeStep.Location = new System.Drawing.Point(140, 54);
            this.TxtRangeStep.Name = "TxtRangeStep";
            this.TxtRangeStep.Size = new System.Drawing.Size(70, 20);
            this.TxtRangeStep.TabIndex = 12;
            this.TxtRangeStep.Text = "1";
            this.TxtRangeStep.Validated += new System.EventHandler(this.TxtRangeStep_Validated);
            // 
            // TxtRangeEnd
            // 
            this.TxtRangeEnd.Location = new System.Drawing.Point(140, 15);
            this.TxtRangeEnd.Name = "TxtRangeEnd";
            this.TxtRangeEnd.Size = new System.Drawing.Size(70, 20);
            this.TxtRangeEnd.TabIndex = 7;
            this.TxtRangeEnd.Text = "0";
            // 
            // TxtRangeStart
            // 
            this.TxtRangeStart.Location = new System.Drawing.Point(67, 15);
            this.TxtRangeStart.Name = "TxtRangeStart";
            this.TxtRangeStart.Size = new System.Drawing.Size(70, 20);
            this.TxtRangeStart.TabIndex = 6;
            this.TxtRangeStart.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File range";
            // 
            // BtnCorrupt
            // 
            this.BtnCorrupt.Location = new System.Drawing.Point(12, 250);
            this.BtnCorrupt.Name = "BtnCorrupt";
            this.BtnCorrupt.Size = new System.Drawing.Size(508, 30);
            this.BtnCorrupt.TabIndex = 6;
            this.BtnCorrupt.Text = "Corrupt!";
            this.BtnCorrupt.UseVisualStyleBackColor = true;
            this.BtnCorrupt.Click += new System.EventHandler(this.BtnCorrupt_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 283);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(508, 23);
            this.ProgressBar.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 317);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.BtnCorrupt);
            this.Controls.Add(this.PnlSetup);
            this.Controls.Add(this.PnlFile);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Corruptor";
            this.PnlFile.ResumeLayout(false);
            this.PnlFile.PerformLayout();
            this.PnlSetup.ResumeLayout(false);
            this.PnlSetup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFileOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFileCorrupted;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnOverwrite;
        private System.Windows.Forms.GroupBox PnlFile;
        private System.Windows.Forms.GroupBox PnlSetup;
        private System.Windows.Forms.TextBox TxtRangeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRangeStart;
        private System.Windows.Forms.RadioButton RbRandomize;
        private System.Windows.Forms.RadioButton RbAdd;
        private System.Windows.Forms.TextBox TxtRangeStep;
        private System.Windows.Forms.TextBox TxtRandomMax;
        private System.Windows.Forms.TextBox TxtRandomMin;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbReplace;
        private System.Windows.Forms.TextBox TxtReplaceTo;
        private System.Windows.Forms.TextBox TxtReplaceFrom;
        private System.Windows.Forms.TextBox TxtShiftRight;
        private System.Windows.Forms.RadioButton RbShiftRight;
        private System.Windows.Forms.Button BtnCorrupt;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label LblFileLength;
        private System.Windows.Forms.Label LblValidRange;
        private System.Windows.Forms.RadioButton RbStepFixed;
        private System.Windows.Forms.RadioButton RbStepRandom;
        private System.Windows.Forms.TextBox TxtRangeStepRandomMin;
        private System.Windows.Forms.TextBox TxtRangeStepRandomMax;
    }
}

