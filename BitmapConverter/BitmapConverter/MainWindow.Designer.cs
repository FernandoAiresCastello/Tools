namespace BitmapConverter
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
            this.BtnLoad = new System.Windows.Forms.Button();
            this.PnlImage = new System.Windows.Forms.Panel();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.BtnConvertCppRGBArray = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.LblFilename = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.LblPixelCount = new System.Windows.Forms.Label();
            this.PnlStatus = new System.Windows.Forms.Panel();
            this.PnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.PnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(12, 12);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(256, 23);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.Text = "Load Image";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // PnlImage
            // 
            this.PnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlImage.AutoScroll = true;
            this.PnlImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlImage.Controls.Add(this.ImageBox);
            this.PnlImage.Location = new System.Drawing.Point(12, 41);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Size = new System.Drawing.Size(256, 318);
            this.PnlImage.TabIndex = 1;
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(100, 100);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // BtnConvertCppRGBArray
            // 
            this.BtnConvertCppRGBArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConvertCppRGBArray.Location = new System.Drawing.Point(274, 12);
            this.BtnConvertCppRGBArray.Name = "BtnConvertCppRGBArray";
            this.BtnConvertCppRGBArray.Size = new System.Drawing.Size(338, 23);
            this.BtnConvertCppRGBArray.TabIndex = 2;
            this.BtnConvertCppRGBArray.Text = "Convert to C++ RGB Array";
            this.BtnConvertCppRGBArray.UseVisualStyleBackColor = true;
            this.BtnConvertCppRGBArray.Click += new System.EventHandler(this.BtnConvertCppRGBArray_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutput.Location = new System.Drawing.Point(274, 41);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtOutput.Size = new System.Drawing.Size(338, 318);
            this.TxtOutput.TabIndex = 3;
            this.TxtOutput.WordWrap = false;
            this.TxtOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOutput_KeyDown);
            // 
            // LblFilename
            // 
            this.LblFilename.AutoSize = true;
            this.LblFilename.Location = new System.Drawing.Point(8, 8);
            this.LblFilename.Name = "LblFilename";
            this.LblFilename.Size = new System.Drawing.Size(49, 13);
            this.LblFilename.TabIndex = 4;
            this.LblFilename.Text = "Filename";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(8, 26);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(57, 13);
            this.LblSize.TabIndex = 5;
            this.LblSize.Text = "Image size";
            // 
            // LblPixelCount
            // 
            this.LblPixelCount.AutoSize = true;
            this.LblPixelCount.Location = new System.Drawing.Point(8, 44);
            this.LblPixelCount.Name = "LblPixelCount";
            this.LblPixelCount.Size = new System.Drawing.Size(59, 13);
            this.LblPixelCount.TabIndex = 6;
            this.LblPixelCount.Text = "Pixel count";
            // 
            // PnlStatus
            // 
            this.PnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlStatus.Controls.Add(this.LblFilename);
            this.PnlStatus.Controls.Add(this.LblPixelCount);
            this.PnlStatus.Controls.Add(this.LblSize);
            this.PnlStatus.Location = new System.Drawing.Point(12, 365);
            this.PnlStatus.Name = "PnlStatus";
            this.PnlStatus.Size = new System.Drawing.Size(600, 68);
            this.PnlStatus.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.PnlStatus);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.BtnConvertCppRGBArray);
            this.Controls.Add(this.PnlImage);
            this.Controls.Add(this.BtnLoad);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Converter";
            this.PnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.PnlStatus.ResumeLayout(false);
            this.PnlStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Panel PnlImage;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button BtnConvertCppRGBArray;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Label LblFilename;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label LblPixelCount;
        private System.Windows.Forms.Panel PnlStatus;
    }
}

