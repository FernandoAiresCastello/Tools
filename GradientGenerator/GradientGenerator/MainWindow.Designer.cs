namespace GradientGenerator
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
            this.GradientBox = new System.Windows.Forms.PictureBox();
            this.ColorTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorBottom = new System.Windows.Forms.Panel();
            this.ColorMiddle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GradientBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GradientBox
            // 
            this.GradientBox.BackColor = System.Drawing.Color.White;
            this.GradientBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GradientBox.Location = new System.Drawing.Point(12, 12);
            this.GradientBox.Name = "GradientBox";
            this.GradientBox.Size = new System.Drawing.Size(320, 320);
            this.GradientBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GradientBox.TabIndex = 0;
            this.GradientBox.TabStop = false;
            // 
            // ColorTop
            // 
            this.ColorTop.BackColor = System.Drawing.Color.White;
            this.ColorTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorTop.Location = new System.Drawing.Point(76, 24);
            this.ColorTop.Name = "ColorTop";
            this.ColorTop.Size = new System.Drawing.Size(64, 20);
            this.ColorTop.TabIndex = 2;
            this.ColorTop.Click += new System.EventHandler(this.ColorTop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtHeight);
            this.groupBox1.Controls.Add(this.TxtWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ColorBottom);
            this.groupBox1.Controls.Add(this.ColorMiddle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ColorTop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(344, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 320);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gradient Colors";
            // 
            // ColorBottom
            // 
            this.ColorBottom.BackColor = System.Drawing.Color.Black;
            this.ColorBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBottom.Location = new System.Drawing.Point(76, 76);
            this.ColorBottom.Name = "ColorBottom";
            this.ColorBottom.Size = new System.Drawing.Size(64, 20);
            this.ColorBottom.TabIndex = 5;
            this.ColorBottom.Click += new System.EventHandler(this.ColorBottom_Click);
            // 
            // ColorMiddle
            // 
            this.ColorMiddle.BackColor = System.Drawing.Color.Silver;
            this.ColorMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorMiddle.Location = new System.Drawing.Point(76, 50);
            this.ColorMiddle.Name = "ColorMiddle";
            this.ColorMiddle.Size = new System.Drawing.Size(64, 20);
            this.ColorMiddle.TabIndex = 5;
            this.ColorMiddle.Click += new System.EventHandler(this.ColorMiddle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bottom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Middle";
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(13, 339);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(319, 20);
            this.TxtPath.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(344, 337);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(156, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save image";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Image height";
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(89, 265);
            this.TxtWidth.MaxLength = 4;
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(51, 20);
            this.TxtWidth.TabIndex = 8;
            this.TxtWidth.Text = "640";
            this.TxtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(89, 287);
            this.TxtHeight.MaxLength = 4;
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(51, 20);
            this.TxtHeight.TabIndex = 9;
            this.TxtHeight.Text = "480";
            this.TxtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 369);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GradientBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradient Generator";
            ((System.ComponentModel.ISupportInitialize)(this.GradientBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GradientBox;
        private System.Windows.Forms.Panel ColorTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel ColorBottom;
        private System.Windows.Forms.Panel ColorMiddle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnSave;
    }
}

