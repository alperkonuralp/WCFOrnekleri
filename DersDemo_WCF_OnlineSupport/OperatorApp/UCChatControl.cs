using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OperatorApp.OSS;

namespace OperatorApp
{
    public partial class UCChatControl : UserControl
    {
        public UCChatControl()
        {
            InitializeComponent();
        }

        protected DateTime _lastOperationDate =
            DateTime.MinValue;

        public ClientData CData;

        private void button1_Click(
            object sender, EventArgs e)
        {
            button1.Enabled = false;
            Application.DoEvents();

            Form1.Client.OperatorSendMessage(
                Form1.OperatorID,
                CData.ClientID,
                tbMessage.Text);

            button1.Enabled = true;
            Application.DoEvents();
        }

        public void WriteMessage(ChatData cd)
        {
            string s = string.Format(
                "{0} -> {1} ({2:T})\r\n{3}",
                cd.SenderName,
                cd.RecieverName,
                cd.SendingTime,
                cd.Message);

            tbHistory.AppendText(s);
            tbHistory.AppendText(Environment.NewLine);
        }

    }
}
