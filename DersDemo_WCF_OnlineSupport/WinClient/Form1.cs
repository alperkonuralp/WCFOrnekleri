using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinClient.OSS;

namespace WinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected Guid userID;
        private void button1_Click(
            object sender, EventArgs e)
        {
            using (OnlineSupportServiceClient cli =
                new OnlineSupportServiceClient())
            {
                userID = cli.ClientStart(textBox1.Text);

                MessageBox.Show("Giriş Yapıldı.");
            }
        }
    }
}
