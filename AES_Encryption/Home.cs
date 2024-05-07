using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Encryption_Decryption
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            EncryptionForm encryption = new EncryptionForm();
          
            encryption.Show();
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {
            DecryptionForm encryption = new DecryptionForm();
            encryption.Show();
        }
    }
}
