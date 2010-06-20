using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClientApp.OSS;

namespace ClientApp
{
    public partial class _Default : System.Web.UI.Page
    {

        public string UserName
        {
            get { return hfUserName.Value; }
            set { hfUserName.Value = value; }
        }
        public Guid UserID
        {
            get { return new Guid(hfUserID.Value); }
            set { hfUserID.Value = value.ToString(); }
        }
        public Guid OperatorID
        {
            get { return new Guid(hfOperatorID.Value); }
            set { hfOperatorID.Value = value.ToString(); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bSend_Click(object sender, EventArgs e)
        {
            p1.Visible = false;
            p2.Visible = true;
            p3.Visible = false;

            UserName = tbName.Text;

            using (OnlineSupportServiceClient cli =
                new OnlineSupportServiceClient())
            {
                UserID = cli.ClientStart(UserName);

                var ops = cli.GetOperators();
                ddl.DataSource = ops;
                ddl.DataTextField = "OperatorName";
                ddl.DataValueField = "OperatorID";
                ddl.DataBind();

            }


        }

        protected void bStart_Click(object sender, EventArgs e)
        {
            OperatorID = new Guid(ddl.SelectedValue);
            
            p1.Visible = p2.Visible = false;
            p3.Visible = true;
        }
    }
}
