﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClient.OSS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperatorData", Namespace="http://schemas.datacontract.org/2004/07/OnlineSupportServiceLibrary.Entities")]
    [System.SerializableAttribute()]
    public partial class OperatorData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastOperationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OnlineTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid OperatorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperatorNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastOperationTime {
            get {
                return this.LastOperationTimeField;
            }
            set {
                if ((this.LastOperationTimeField.Equals(value) != true)) {
                    this.LastOperationTimeField = value;
                    this.RaisePropertyChanged("LastOperationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OnlineTime {
            get {
                return this.OnlineTimeField;
            }
            set {
                if ((this.OnlineTimeField.Equals(value) != true)) {
                    this.OnlineTimeField = value;
                    this.RaisePropertyChanged("OnlineTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid OperatorID {
            get {
                return this.OperatorIDField;
            }
            set {
                if ((this.OperatorIDField.Equals(value) != true)) {
                    this.OperatorIDField = value;
                    this.RaisePropertyChanged("OperatorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OperatorName {
            get {
                return this.OperatorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.OperatorNameField, value) != true)) {
                    this.OperatorNameField = value;
                    this.RaisePropertyChanged("OperatorName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientData", Namespace="http://schemas.datacontract.org/2004/07/OnlineSupportServiceLibrary.Entities")]
    [System.SerializableAttribute()]
    public partial class ClientData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastOperationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OnlineTimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((this.ClientIDField.Equals(value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientName {
            get {
                return this.ClientNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientNameField, value) != true)) {
                    this.ClientNameField = value;
                    this.RaisePropertyChanged("ClientName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastOperationTime {
            get {
                return this.LastOperationTimeField;
            }
            set {
                if ((this.LastOperationTimeField.Equals(value) != true)) {
                    this.LastOperationTimeField = value;
                    this.RaisePropertyChanged("LastOperationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OnlineTime {
            get {
                return this.OnlineTimeField;
            }
            set {
                if ((this.OnlineTimeField.Equals(value) != true)) {
                    this.OnlineTimeField = value;
                    this.RaisePropertyChanged("OnlineTime");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatData", Namespace="http://schemas.datacontract.org/2004/07/OnlineSupportServiceLibrary.Entities")]
    [System.SerializableAttribute()]
    public partial class ChatData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime SendingTimeField;
        
        private string RecieverNameField;
        
        private string SenderNameField;
        
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime SendingTime {
            get {
                return this.SendingTimeField;
            }
            set {
                if ((this.SendingTimeField.Equals(value) != true)) {
                    this.SendingTimeField = value;
                    this.RaisePropertyChanged("SendingTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string RecieverName {
            get {
                return this.RecieverNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RecieverNameField, value) != true)) {
                    this.RecieverNameField = value;
                    this.RaisePropertyChanged("RecieverName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public string SenderName {
            get {
                return this.SenderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderNameField, value) != true)) {
                    this.SenderNameField = value;
                    this.RaisePropertyChanged("SenderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OSS.IOnlineSupportService")]
    public interface IOnlineSupportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/ClientStart", ReplyAction="http://tempuri.org/IOnlineSupportService/ClientStartResponse")]
        System.Guid ClientStart(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/ClientEnd", ReplyAction="http://tempuri.org/IOnlineSupportService/ClientEndResponse")]
        bool ClientEnd(System.Guid userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/OperatorStart", ReplyAction="http://tempuri.org/IOnlineSupportService/OperatorStartResponse")]
        System.Guid OperatorStart(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/OperatorEnd", ReplyAction="http://tempuri.org/IOnlineSupportService/OperatorEndResponse")]
        bool OperatorEnd(System.Guid userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/GetOperators", ReplyAction="http://tempuri.org/IOnlineSupportService/GetOperatorsResponse")]
        WinClient.OSS.OperatorData[] GetOperators();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/GetClients", ReplyAction="http://tempuri.org/IOnlineSupportService/GetClientsResponse")]
        WinClient.OSS.ClientData[] GetClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/ClientSendMessage", ReplyAction="http://tempuri.org/IOnlineSupportService/ClientSendMessageResponse")]
        bool ClientSendMessage(System.Guid userID, System.Guid operatorID, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/OperatorSendMessage", ReplyAction="http://tempuri.org/IOnlineSupportService/OperatorSendMessageResponse")]
        bool OperatorSendMessage(System.Guid operatorID, System.Guid userID, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/ClientGetMessages", ReplyAction="http://tempuri.org/IOnlineSupportService/ClientGetMessagesResponse")]
        WinClient.OSS.ChatData[] ClientGetMessages(System.Guid userID, System.DateTime lastOperationTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineSupportService/OperatorGetMessages", ReplyAction="http://tempuri.org/IOnlineSupportService/OperatorGetMessagesResponse")]
        WinClient.OSS.ChatData[] OperatorGetMessages(System.Guid OperatorID, System.DateTime lastOperationTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IOnlineSupportServiceChannel : WinClient.OSS.IOnlineSupportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class OnlineSupportServiceClient : System.ServiceModel.ClientBase<WinClient.OSS.IOnlineSupportService>, WinClient.OSS.IOnlineSupportService {
        
        public OnlineSupportServiceClient() {
        }
        
        public OnlineSupportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OnlineSupportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnlineSupportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnlineSupportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid ClientStart(string userName) {
            return base.Channel.ClientStart(userName);
        }
        
        public bool ClientEnd(System.Guid userID) {
            return base.Channel.ClientEnd(userID);
        }
        
        public System.Guid OperatorStart(string userName) {
            return base.Channel.OperatorStart(userName);
        }
        
        public bool OperatorEnd(System.Guid userID) {
            return base.Channel.OperatorEnd(userID);
        }
        
        public WinClient.OSS.OperatorData[] GetOperators() {
            return base.Channel.GetOperators();
        }
        
        public WinClient.OSS.ClientData[] GetClients() {
            return base.Channel.GetClients();
        }
        
        public bool ClientSendMessage(System.Guid userID, System.Guid operatorID, string message) {
            return base.Channel.ClientSendMessage(userID, operatorID, message);
        }
        
        public bool OperatorSendMessage(System.Guid operatorID, System.Guid userID, string message) {
            return base.Channel.OperatorSendMessage(operatorID, userID, message);
        }
        
        public WinClient.OSS.ChatData[] ClientGetMessages(System.Guid userID, System.DateTime lastOperationTime) {
            return base.Channel.ClientGetMessages(userID, lastOperationTime);
        }
        
        public WinClient.OSS.ChatData[] OperatorGetMessages(System.Guid OperatorID, System.DateTime lastOperationTime) {
            return base.Channel.OperatorGetMessages(OperatorID, lastOperationTime);
        }
    }
}
