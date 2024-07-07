namespace UniqueColorExtractor
{
    partial class Form1
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
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.TxtColors = new System.Windows.Forms.TextBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(107, 45);
            this.BtnLoadImage.TabIndex = 0;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.UseVisualStyleBackColor = true;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // TxtColors
            // 
            this.TxtColors.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColors.Location = new System.Drawing.Point(12, 63);
            this.TxtColors.Multiline = true;
            this.TxtColors.Name = "TxtColors";
            this.TxtColors.ReadOnly = true;
            this.TxtColors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtColors.Size = new System.Drawing.Size(389, 375);
            this.TxtColors.TabIndex = 1;
            this.TxtColors.WordWrap = false;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(143, 28);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(156, 13);
            this.LblMessage.TabIndex = 2;
            this.LblMessage.Text = "Press button to load an image...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.TxtColors);
            this.Controls.Add(this.BtnLoadImage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.TextBox TxtColors;
        private System.Windows.Forms.Label LblMessage;
    }
}

