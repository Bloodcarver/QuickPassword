using System;
using System.Windows.Forms;

namespace QuickPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            label1.Text = GetPassword(6);
            label2.Text = GetPassword(8);
            label3.Text = GetPassword(10);
            label4.Text = GetPassword(12);
            label5.Text = GetPassword(14);
            label6.Text = RandomPassword.Generate(8, 8);
            label7.Text = RandomPassword.Generate(10, 10);
            label8.Text = RandomPassword.Generate(12, 12);
            label9.Text = RandomPassword.Generate(14, 14);
        }
        private string GetPassword(int iLength)
        {
            string sPassword = "";
            var ppg = new PwdGen.PronounceablePasswordGenerator();
            var passwords = ppg.Generate(PasswordCount: 1, PasswordLength: iLength);
            foreach (var password in passwords)
            {
                sPassword= password.ToString();
            }
            ppg = null;
            return sPassword;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
            this.Close();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label2.Text);
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label3.Text);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label4.Text);
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label5.Text);
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label6.Text);
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label7.Text);
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label8.Text);
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label9.Text);
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}