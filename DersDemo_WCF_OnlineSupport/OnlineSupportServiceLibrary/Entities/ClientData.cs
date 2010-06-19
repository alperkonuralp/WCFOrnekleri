using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace OnlineSupportServiceLibrary.Entities
{
    [DataContract]
    public class ClientData
    {
        [DataMember]
        public Guid ClientID { get; set; }

        [DataMember]
        public string ClientName { get; set; }

        [DataMember]
        public DateTime OnlineTime { get; set; }

        [DataMember]
        public DateTime LastOperationTime { get; set; }

        internal List<ChatData> _chats =
            new List<ChatData>();
    }
}
