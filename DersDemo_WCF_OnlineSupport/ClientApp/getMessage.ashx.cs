using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.SessionState;
using ClientApp.OSS;
using System.Text;

namespace ClientApp
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class getMessage : IHttpHandler, IRequiresSessionState
    {
        HttpRequest req;
        HttpResponse res;
        HttpSessionState ses;

        public void ProcessRequest(HttpContext context)
        {
            req = context.Request;
            res = context.Response;
            ses = context.Session;

            res.ContentType = "text/html";
            Guid userID = new Guid(req["u"]);
            Guid operatorID = new Guid(req["o"]);

            DateTime dt = ses["LastOperationTime"] == null ?
                    DateTime.MinValue :
                    (DateTime)ses["LastOperationTime"];


            using (OnlineSupportServiceClient cli =
                new OnlineSupportServiceClient())
            {
                var cds = cli.ClientGetMessages(
                    userID, dt);

                StringBuilder sb = new StringBuilder("<div>");
                if (cds != null && cds.Length > 0)
                {
                    foreach (var item in cds)
                    {
                        Guid oi;
                        if (item.SenderType == SenderType.Client)
                        {
                            oi = item.RecieverID;
                        }
                        else
                        {
                            oi = item.SenderID;
                        }

                        if (oi == operatorID)
                        {
                            sb.AppendFormat(
                                "<div>{0} -&gt; {1} ({2:T})</br>{3}</div>",
                                item.SenderName,
                                item.RecieverName,
                                item.SendingTime,
                                item.Message
                            );
                        }
                        ses["LastOperationTime"] = item.SendingTime;
                    }
                }
                sb.Append("</div>");
                res.Write(sb.ToString());
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
