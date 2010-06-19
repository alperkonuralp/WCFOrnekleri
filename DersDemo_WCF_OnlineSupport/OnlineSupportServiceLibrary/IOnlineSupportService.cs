using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineSupportServiceLibrary.Entities;
using System.ServiceModel;

namespace OnlineSupportServiceLibrary
{
    [ServiceContract]
    public interface IOnlineSupportService
    {
        [OperationContract()]
        Guid ClientStart(string userName);
        [OperationContract]
        bool ClientEnd(Guid userID);

        [OperationContract]
        Guid OperatorStart(string userName);
        [OperationContract]
        bool OperatorEnd(Guid userID);

        [OperationContract]
        OperatorData[] GetOperators();
        [OperationContract]
        ClientData[] GetClients();

        [OperationContract]
        bool ClientSendMessage(
            Guid userID, Guid operatorID, string message);

        [OperationContract]
        bool OperatorSendMessage(
            Guid operatorID, Guid userID, string message);

        [OperationContract]
        ChatData[] ClientGetMessages(
            Guid userID, DateTime lastOperationTime);

        [OperationContract]
        ChatData[] OperatorGetMessages(
            Guid OperatorID, DateTime lastOperationTime);
    }
}
