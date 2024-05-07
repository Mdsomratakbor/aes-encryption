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
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }
        public enum enumAction
        {
            wait,
            start,
            close
        }
        private MessageBox.enumAction action;
        private int x, y;

        private void btnTimes_Click(object sender, EventArgs e)
        {
            interValTimer.Interval = 1;
            action = enumAction.close;
        }

        private void interValTimer_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enumAction.wait:
                    interValTimer.Interval = 5000;
                    action = enumAction.close;
                    break;
                case enumAction.start:
                    interValTimer.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left --;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enumAction.wait;
                        }
                    }
                        break;
                case enumAction.close:
                    interValTimer.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showAlert(string message)
        {
            this.Opacity = 0.0;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 0; i < 10; i++)
            {
                fname = "Message" + i.ToString();
                MessageBox frm = (MessageBox)Application.OpenForms[fname];
                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width;// - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height;//- this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.X - base.Width - 5;
            this.lblMessage.Text = message;
            this.Show();
            this.action = enumAction.start;
            this.interValTimer.Interval = 1;

        }
    }
}
