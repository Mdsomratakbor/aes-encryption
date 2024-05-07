
namespace Encryption_Decryption
{
    partial class EncryptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionForm));
            this.keyLabel = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.encryptedValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnResult = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.keyLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.keyLabel.Location = new System.Drawing.Point(119, 65);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Padding = new System.Windows.Forms.Padding(5);
            this.keyLabel.Size = new System.Drawing.Size(160, 28);
            this.keyLabel.TabIndex = 0;
            this.keyLabel.Text = "Encryption Key :";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxKey.Location = new System.Drawing.Point(285, 70);
            this.textBoxKey.MinimumSize = new System.Drawing.Size(4, 30);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.PlaceholderText = "Key must be gater then or equal 10 charaters";
            this.textBoxKey.Size = new System.Drawing.Size(440, 30);
            this.textBoxKey.TabIndex = 1;
            // 
            // encryptedValue
            // 
            this.encryptedValue.AutoSize = true;
            this.encryptedValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encryptedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.encryptedValue.Location = new System.Drawing.Point(103, 134);
            this.encryptedValue.Name = "encryptedValue";
            this.encryptedValue.Padding = new System.Windows.Forms.Padding(5);
            this.encryptedValue.Size = new System.Drawing.Size(176, 28);
            this.encryptedValue.TabIndex = 2;
            this.encryptedValue.Text = "Encryption Value :";
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxValue.Location = new System.Drawing.Point(285, 134);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(440, 23);
            this.textBoxValue.TabIndex = 3;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(97, 319);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encryption Result :";
            // 
            // textBoxResult
            // 
            this.textBoxResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxResult.BackColor = System.Drawing.Color.Silver;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxResult.HideSelection = false;
            this.textBoxResult.Location = new System.Drawing.Point(286, 260);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.PlaceholderText = "Encrypted value show here";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxResult.Size = new System.Drawing.Size(439, 155);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.Tag = "";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnClose.Location = new System.Drawing.Point(441, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Size = new System.Drawing.Size(140, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Green;
            this.btnResult.Enabled = false;
            this.btnResult.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResult.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnResult.IconColor = System.Drawing.Color.Cornsilk;
            this.btnResult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResult.IconSize = 35;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnResult.Location = new System.Drawing.Point(407, 186);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(188, 44);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Process";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(866, 526);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.encryptedValue);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.keyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptionForm";
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.EncryptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label encryptedValue;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnResult;
    }
}