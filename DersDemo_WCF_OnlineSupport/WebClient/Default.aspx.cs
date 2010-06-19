using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.OSS;

namespace WebClient
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bSend_Click(object sender, EventArgs e)
        {
            using (OnlineSupportServiceClient cli =
                new OnlineSupportServiceClient())
            {
                cli.ClientStart(tbName.Text);
                Page.ClientScript.RegisterStartupScript(
                    GetType(), "IslemTamam",
                    "alert('İşlem Tamam');", true);
            }
        }
    }
}
