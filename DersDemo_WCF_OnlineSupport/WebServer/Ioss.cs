using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServer
{
    // NOTE: If you change the interface name "Ioss" here, you must also update the reference to "Ioss" in Web.config.
    [ServiceContract]
    public interface Ioss
    {
        [OperationContract]
        void DoWork();
    }
}
