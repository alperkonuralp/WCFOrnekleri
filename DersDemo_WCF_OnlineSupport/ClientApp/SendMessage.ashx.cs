using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClientApp.OSS;

namespace ClientApp
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class SendMessage : IHttpHandler
    {

        HttpRequest req;
        HttpResponse res;

        public void ProcessRequest(HttpContext context)
        {
            req = context.Request;
            res = context.Response;

            res.ContentType = "text/plain";

            Guid userID = new Guid(req["u"]);
            Guid operatorID = new Guid(req["o"]);
            string message = req["m"];

            using (OnlineSupportServiceClient cli =
                new OnlineSupportServiceClient())
            {
                cli.ClientSendMessage(
                    userID, operatorID, message);
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
