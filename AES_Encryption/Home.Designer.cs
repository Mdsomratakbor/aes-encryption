
using System.Drawing;
using System.Windows.Forms;

namespace Encryption_Decryption
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.appLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEncryption = new FontAwesome.Sharp.IconButton();
            this.btnDecryption = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appLable
            // 
            this.appLable.AutoSize = true;
            this.appLable.BackColor = System.Drawing.Color.White;
            this.appLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appLable.Font = new System.Drawing.Font("Verdana", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.appLable.ForeColor = System.Drawing.Color.Salmon;
            this.appLable.Location = new System.Drawing.Point(184, 21);
            this.appLable.MaximumSize = new System.Drawing.Size(500, 0);
            this.appLable.Name = "appLable";
            this.appLable.Padding = new System.Windows.Forms.Padding(3);
            this.appLable.Size = new System.Drawing.Size(500, 34);
            this.appLable.TabIndex = 0;
            this.appLable.Text = "Encryption And Decryption Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(286, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Size = new System.Drawing.Size(295, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEncryption
            // 
            this.btnEncryption.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnEncryption.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEncryption.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEncryption.FlatAppearance.BorderSize = 2;
            this.btnEncryption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnEncryption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEncryption.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnEncryption.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncryption.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnEncryption.IconColor = System.Drawing.Color.SeaShell;
            this.btnEncryption.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEncryption.IconSize = 35;
            this.btnEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncryption.Location = new System.Drawing.Point(184, 319);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(245, 54);
            this.btnEncryption.TabIndex = 4;
            this.btnEncryption.Text = "Encryption";
            this.btnEncryption.UseVisualStyleBackColor = false;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDecryption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDecryption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDecryption.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnDecryption.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecryption.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnDecryption.IconColor = System.Drawing.Color.MistyRose;
            this.btnDecryption.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDecryption.IconSize = 35;
            this.btnDecryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryption.Location = new System.Drawing.Point(439, 319);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(245, 54);
            this.btnDecryption.TabIndex = 5;
            this.btnDecryption.Text = "Decryption";
            this.btnDecryption.UseVisualStyleBackColor = false;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(808, 433);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnEncryption;
        private FontAwesome.Sharp.IconButton btnDecryption;
    }
}