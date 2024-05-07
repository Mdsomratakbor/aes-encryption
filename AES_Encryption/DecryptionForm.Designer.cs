
namespace Encryption_Decryption
{
    partial class DecryptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptionForm));
            this.btnResult = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.decryptionResultLabel = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.decryptedLabel = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Green;
            this.btnResult.Enabled = false;
            this.btnResult.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnResult.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnResult.IconColor = System.Drawing.Color.Cornsilk;
            this.btnResult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResult.IconSize = 35;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnResult.Location = new System.Drawing.Point(387, 143);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(188, 44);
            this.btnResult.TabIndex = 15;
            this.btnResult.Text = "Process";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnClose.IconColor = System.Drawing.Color.Brown;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(421, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Size = new System.Drawing.Size(140, 33);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxResult.BackColor = System.Drawing.Color.Silver;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxResult.HideSelection = false;
            this.textBoxResult.Location = new System.Drawing.Point(266, 217);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.PlaceholderText = "Decrypted value show here";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxResult.Size = new System.Drawing.Size(439, 155);
            this.textBoxResult.TabIndex = 13;
            this.textBoxResult.Tag = "";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // decryptionResultLabel
            // 
            this.decryptionResultLabel.AutoSize = true;
            this.decryptionResultLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decryptionResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.decryptionResultLabel.Location = new System.Drawing.Point(77, 276);
            this.decryptionResultLabel.Name = "decryptionResultLabel";
            this.decryptionResultLabel.Padding = new System.Windows.Forms.Padding(5);
            this.decryptionResultLabel.Size = new System.Drawing.Size(184, 28);
            this.decryptionResultLabel.TabIndex = 12;
            this.decryptionResultLabel.Text = "Decryption Result :";
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxValue.Location = new System.Drawing.Point(265, 91);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(440, 23);
            this.textBoxValue.TabIndex = 11;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // decryptedLabel
            // 
            this.decryptedLabel.AutoSize = true;
            this.decryptedLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decryptedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.decryptedLabel.Location = new System.Drawing.Point(83, 91);
            this.decryptedLabel.Name = "decryptedLabel";
            this.decryptedLabel.Padding = new System.Windows.Forms.Padding(5);
            this.decryptedLabel.Size = new System.Drawing.Size(178, 28);
            this.decryptedLabel.TabIndex = 10;
            this.decryptedLabel.Text = "Decryption Value :";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxKey.Location = new System.Drawing.Point(265, 27);
            this.textBoxKey.MinimumSize = new System.Drawing.Size(4, 30);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.PlaceholderText = "Key must be gater then or equal 10 charaters";
            this.textBoxKey.Size = new System.Drawing.Size(440, 23);
            this.textBoxKey.TabIndex = 9;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.keyLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.keyLabel.Location = new System.Drawing.Point(99, 22);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Padding = new System.Windows.Forms.Padding(5);
            this.keyLabel.Size = new System.Drawing.Size(162, 28);
            this.keyLabel.TabIndex = 8;
            this.keyLabel.Text = "Decryption Key :";
            // 
            // DecryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.decryptionResultLabel);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.decryptedLabel);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.keyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptionForm";
            this.Text = "Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnResult;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label decryptionResultLabel;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label decryptedLabel;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label keyLabel;
    }
}