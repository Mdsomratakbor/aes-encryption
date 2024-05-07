using AES_Encryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Decryption
{
    public partial class DecryptionForm : Form
    {
        public DecryptionForm()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (this.textBoxKey.Text.Length > 10 && this.textBoxValue.Text != null)
            {
                var encryptedValue = AES.AESDecrypt(textBoxValue.Text, textBoxKey.Text);
                textBoxResult.Text = encryptedValue;
            }

            else
            {
                System.Windows.Forms.MessageBox.Show("Key Must be gater then or equal 10");
            }

        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxKey.Text.Length > 10 && this.textBoxValue.Text != null)
            {

                this.btnResult.Enabled = true;
            }

        }
    }
}
