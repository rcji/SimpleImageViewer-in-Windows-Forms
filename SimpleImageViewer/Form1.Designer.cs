﻿namespace SimpleImageViewer
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
            this.btnImgSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImgSelect
            // 
            this.btnImgSelect.Location = new System.Drawing.Point(12, 524);
            this.btnImgSelect.Name = "btnImgSelect";
            this.btnImgSelect.Size = new System.Drawing.Size(670, 36);
            this.btnImgSelect.TabIndex = 0;
            this.btnImgSelect.Text = "Image Select";
            this.btnImgSelect.UseVisualStyleBackColor = true;
            this.btnImgSelect.Click += new System.EventHandler(this.btnImgSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImgSelect);
            this.MaximumSize = new System.Drawing.Size(712, 619);
            this.MinimumSize = new System.Drawing.Size(712, 619);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImgSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

