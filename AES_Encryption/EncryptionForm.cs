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
    public partial class EncryptionForm : Form
    {
        public EncryptionForm()
        {
            InitializeComponent();
        }

        private void EncryptionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (this.textBoxKey.Text.Length > 10 && this.textBoxValue.Text != null)
            {
                //IEncryptionServices encryption = new EncryptionServices();
                var encryptedValue = AES.AESEncrypt(textBoxValue.Text, textBoxKey.Text);
                textBoxResult.Text = encryptedValue;
               // MessageBox successMessage = new MessageBox();
                //successMessage.showAlert("Encryption Successfull!!");
            }
          
            else
            {
                System.Windows.Forms.MessageBox.Show("Key Must be gater then or equal 10");
            }

        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            if(this.textBoxKey.Text.Length>10 && this.textBoxValue.Text != null)
            {
                
                this.btnResult.Enabled = true;
            }
            
        }
    }
}
