using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineSupportServiceLibrary.Entities;
using System.ServiceModel;

namespace OnlineSupportServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class OnlineSupportService :
        IOnlineSupportService
    {
        protected List<OperatorData> _operators =
            new List<OperatorData>(20);

        protected List<ClientData> _clients =
            new List<ClientData>(100);

        protected List<ChatData> _chats =
            new List<ChatData>(200);

        #region IOnlineSupportService Members

        public Guid ClientStart(string userName)
        {
            var cd = new ClientData()
            {
                ClientID = Guid.NewGuid(),
                ClientName = userName,
                OnlineTime = DateTime.Now,
                LastOperationTime = DateTime.Now
            };
            _clients.Add(cd);
            return cd.ClientID;
        }

        public bool ClientEnd(Guid userID)
        {
            var cd = _clients.FirstOrDefault(
                x => x.ClientID == userID);

            if (cd != null)
            {
                _clients.Remove(cd);
                return true;
            }
            return false;
        }

        public Guid OperatorStart(string userName)
        {
            var od = new OperatorData()
            {
                OperatorID = Guid.NewGuid(),
                OperatorName = userName,
                OnlineTime = DateTime.Now,
                LastOperationTime = DateTime.Now
            };
            _operators.Add(od);
            return od.OperatorID;
        }

        public bool OperatorEnd(Guid userID)
        {
            var od = _operators.FirstOrDefault(
                x => x.OperatorID == userID);

            if (od != null)
            {
                _operators.Remove(od);
                return true;
            }
            return false;
        }

        public OperatorData[] GetOperators()
        {
            return _operators.Select(x => new OperatorData()
            {
                OperatorID = x.OperatorID,
                OperatorName = x.OperatorName
            }).ToArray();
        }

        public ClientData[] GetClients()
        {
            return _clients.ToArray();
        }

        public bool ClientSendMessage(
            Guid userID, Guid operatorID, string message)
        {
            var cli =
                _clients.FirstOrDefault(
                    x => x.ClientID == userID);

            var ope =
                _operators.FirstOrDefault(
                    x => x.OperatorID == operatorID);
            if (cli == null || ope == null)
            {
                return false;
            }

            var cd = new ChatData()
            {
                SenderType = SenderType.Client,
                SenderID = userID,
                Sender = cli.ClientName,

                RecieverID = operatorID,
                Reciever = ope.OperatorName,

                Message = message,
                SendingTime = DateTime.Now
            };

            _chats.Add(cd);
            cli.LastOperationTime = cd.SendingTime;
            cli._chats.Add(cd);

            ope._chats.Add(cd);

            return true;
        }

        public bool OperatorSendMessage(Guid operatorID, Guid userID, string message)
        {
            var cli =
                _clients.FirstOrDefault(
                    x => x.ClientID == userID);

            var ope =
                _operators.FirstOrDefault(
                    x => x.OperatorID == operatorID);
            if (cli == null || ope == null)
            {
                return false;
            }

            var cd = new ChatData()
            {
                SenderType = SenderType.Operator,
                SenderID = operatorID,
                Sender = ope.OperatorName,

                RecieverID = userID,
                Reciever = cli.ClientName,

                Message = message,
                SendingTime = DateTime.Now
            };

            _chats.Add(cd);
            cli._chats.Add(cd);

            ope.LastOperationTime = cd.SendingTime;
            ope._chats.Add(cd);

            return true;
        }

        public ChatData[] ClientGetMessages(
            Guid userID, DateTime lastOperationTime)
        {
            var cli =
                _clients.FirstOrDefault(
                    x => x.ClientID == userID);


            return (cli == null) ? null :
                cli._chats
                    .Where(x => x.SendingTime > lastOperationTime)
                    .ToArray();
        }

        public ChatData[] OperatorGetMessages(
            Guid operatorID, DateTime lastOperationTime)
        {
            var ope =
                _operators.FirstOrDefault(
                    x => x.OperatorID == operatorID);


            return (ope == null) ? null :
                ope._chats
                    .Where(x => x.SendingTime > lastOperationTime)
                    .ToArray();
        }

        #endregion
    }
}
