using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using OnlineSupportServiceLibrary;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected ServiceHost _host;

        protected override void OnStart(string[] args)
        {
            _host = new ServiceHost(
                typeof(OnlineSupportService));

            _host.Open();
        }

        protected override void OnStop()
        {
            _host.Close();
            ((IDisposable)_host).Dispose();
            _host = null;
        }

    }
}
