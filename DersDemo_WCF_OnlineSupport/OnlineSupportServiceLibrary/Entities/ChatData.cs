using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace OnlineSupportServiceLibrary.Entities
{
    [DataContract]
    public class ChatData
    {
        [DataMember(IsRequired = true,
            Name = "SenderName", Order = 2)]
        public string Sender { get; set; }

        [DataMember(IsRequired = true,
            Name = "RecieverName", Order = 1)]
        public string Reciever { get; set; }

        [DataMember(IsRequired = true, Order = 3)]
        public string Message { get; set; }

        [DataMember(IsRequired = true, Order = 0)]
        public DateTime SendingTime { get; set; }

        [DataMember]
        public Guid SenderID { get; set; }
        [DataMember]
        public SenderType SenderType { get; set; }
        [DataMember]
        public Guid RecieverID { get; set; }
    }

    public enum SenderType { Client, Operator };
}
