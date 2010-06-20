using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OperatorApp.OSS;
using System.Threading;

namespace OperatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thGetOnlineUsers =
                new Thread(GetOnlineClintsThreadMethod) { IsBackground = true };
        }

        public static string OperatorName;
        public static Guid OperatorID;
        public static OnlineSupportServiceClient Client =
            new OnlineSupportServiceClient();

        public static List<ClientData> Clients =
            new List<ClientData>();

        private Thread thGetOnlineUsers;

        private void Form1_Load(object sender, EventArgs e)
        {
            Startup s = new Startup();
            if (s.ShowDialog(this) == DialogResult.OK)
            {
                OperatorName = s.OperatorName;

                OperatorID = Client.OperatorStart(OperatorName);

                thGetOnlineUsers.Start();
            }
            else
            {
                Application.Exit();
            }
        }


        private void GetOnlineClintsThreadMethod()
        {
            try
            {
                while (true)
                {
                    GetOnlineClients();
                    Thread.Sleep(2000);
                    GetChatData();
                    Thread.Sleep(2000);
                }
            }
            catch (ThreadAbortException)
            {

            }
        }

        private void GetOnlineClients()
        {
            ClientData[] clients = Client.GetClients();
            foreach (var item in clients)
            {
                var esit = false;
                foreach (var item2 in Clients)
                {
                    if (item.ClientID == item2.ClientID)
                    {
                        esit = true;
                        item.OnlineTime = item2.OnlineTime;
                        item.LastOperationTime = item2.LastOperationTime;
                        break;
                    }
                }
                if (!esit)
                {
                    // yeni client
                    Clients.Add(item);
                    CreateTabPage(item);
                }
            }
        }

        private DateTime _lastOperationTime =
            DateTime.MinValue;

        private Dictionary<Guid, UCChatControl> _ucChatControls =
            new Dictionary<Guid, UCChatControl>();

        private void GetChatData()
        {
            var cd = Client.OperatorGetMessages(
                OperatorID, _lastOperationTime);

            if (cd != null && cd.Length > 0)
            {
                foreach (var item in cd)
                {
                    Guid clientid;
                    if (item.SenderType == SenderType.Operator)
                    {
                        // operatör yazmış.
                        clientid = item.RecieverID;
                    }
                    else
                    {
                        // client yazmış
                        clientid = item.SenderID;
                    }

                    UCChatControl uc;
                    if (_ucChatControls.TryGetValue(
                        clientid, out uc))
                    {
                        uc.WriteMessage(item);
                    }
                    _lastOperationTime = item.SendingTime;
                }
            }

        }

        public delegate void CreateTabPageDelegate(ClientData item);
        private void CreateTabPage(ClientData item)
        {
            if (InvokeRequired)
            {
                Invoke(
                    new CreateTabPageDelegate(CreateTabPage),
                    item);
            }
            else
            {
                TabPage tp = new TabPage(item.ClientName);
                tp.Tag = item;

                UCChatControl uc = new UCChatControl();

                tp.Controls.Add(uc);
                uc.Location = new Point(0, 0);
                uc.Dock = DockStyle.Fill;
                uc.CData = item;
                _ucChatControls.Add(item.ClientID, uc);

                tabControl1.TabPages.Add(tp);
            }
        }
    }
}
