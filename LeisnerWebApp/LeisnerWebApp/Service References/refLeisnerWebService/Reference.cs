﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeisnerWebApp.refLeisnerWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWebApp.App_Code")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChildNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DoctorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ChildName {
            get {
                return this.ChildNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ChildNameField, value) != true)) {
                    this.ChildNameField = value;
                    this.RaisePropertyChanged("ChildName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfBirthField, value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Doctor {
            get {
                return this.DoctorField;
            }
            set {
                if ((object.ReferenceEquals(this.DoctorField, value) != true)) {
                    this.DoctorField = value;
                    this.RaisePropertyChanged("Doctor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonId {
            get {
                return this.PersonIdField;
            }
            set {
                if ((this.PersonIdField.Equals(value) != true)) {
                    this.PersonIdField = value;
                    this.RaisePropertyChanged("PersonId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Time", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWebApp.App_Code")]
    [System.SerializableAttribute()]
    public partial class Time : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HourIdField;
        
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
        public string Hour {
            get {
                return this.HourField;
            }
            set {
                if ((object.ReferenceEquals(this.HourField, value) != true)) {
                    this.HourField = value;
                    this.RaisePropertyChanged("Hour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HourId {
            get {
                return this.HourIdField;
            }
            set {
                if ((this.HourIdField.Equals(value) != true)) {
                    this.HourIdField = value;
                    this.RaisePropertyChanged("HourId");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="refLeisnerWebService.IDBAccessService")]
    public interface IDBAccessService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindPerson", ReplyAction="http://tempuri.org/IDBAccessService/FindPersonResponse")]
        void FindPerson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindPerson", ReplyAction="http://tempuri.org/IDBAccessService/FindPersonResponse")]
        System.Threading.Tasks.Task FindPersonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllPersons", ReplyAction="http://tempuri.org/IDBAccessService/FindAllPersonsResponse")]
        LeisnerWebApp.refLeisnerWebService.Person[] FindAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllPersons", ReplyAction="http://tempuri.org/IDBAccessService/FindAllPersonsResponse")]
        System.Threading.Tasks.Task<LeisnerWebApp.refLeisnerWebService.Person[]> FindAllPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindTime", ReplyAction="http://tempuri.org/IDBAccessService/FindTimeResponse")]
        void FindTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindTime", ReplyAction="http://tempuri.org/IDBAccessService/FindTimeResponse")]
        System.Threading.Tasks.Task FindTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllTimes", ReplyAction="http://tempuri.org/IDBAccessService/FindAllTimesResponse")]
        LeisnerWebApp.refLeisnerWebService.Time[] FindAllTimes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllTimes", ReplyAction="http://tempuri.org/IDBAccessService/FindAllTimesResponse")]
        System.Threading.Tasks.Task<LeisnerWebApp.refLeisnerWebService.Time[]> FindAllTimesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SavePerson", ReplyAction="http://tempuri.org/IDBAccessService/SavePersonResponse")]
        void SavePerson(int personId, int status, string email, string password, string name, string address, string childName, string doctor, string dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SavePerson", ReplyAction="http://tempuri.org/IDBAccessService/SavePersonResponse")]
        System.Threading.Tasks.Task SavePersonAsync(int personId, int status, string email, string password, string name, string address, string childName, string doctor, string dateOfBirth);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBAccessServiceChannel : LeisnerWebApp.refLeisnerWebService.IDBAccessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBAccessServiceClient : System.ServiceModel.ClientBase<LeisnerWebApp.refLeisnerWebService.IDBAccessService>, LeisnerWebApp.refLeisnerWebService.IDBAccessService {
        
        public DBAccessServiceClient() {
        }
        
        public DBAccessServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBAccessServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBAccessServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBAccessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void FindPerson() {
            base.Channel.FindPerson();
        }
        
        public System.Threading.Tasks.Task FindPersonAsync() {
            return base.Channel.FindPersonAsync();
        }
        
        public LeisnerWebApp.refLeisnerWebService.Person[] FindAllPersons() {
            return base.Channel.FindAllPersons();
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApp.refLeisnerWebService.Person[]> FindAllPersonsAsync() {
            return base.Channel.FindAllPersonsAsync();
        }
        
        public void FindTime() {
            base.Channel.FindTime();
        }
        
        public System.Threading.Tasks.Task FindTimeAsync() {
            return base.Channel.FindTimeAsync();
        }
        
        public LeisnerWebApp.refLeisnerWebService.Time[] FindAllTimes() {
            return base.Channel.FindAllTimes();
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApp.refLeisnerWebService.Time[]> FindAllTimesAsync() {
            return base.Channel.FindAllTimesAsync();
        }
        
        public void SavePerson(int personId, int status, string email, string password, string name, string address, string childName, string doctor, string dateOfBirth) {
            base.Channel.SavePerson(personId, status, email, password, name, address, childName, doctor, dateOfBirth);
        }
        
        public System.Threading.Tasks.Task SavePersonAsync(int personId, int status, string email, string password, string name, string address, string childName, string doctor, string dateOfBirth) {
            return base.Channel.SavePersonAsync(personId, status, email, password, name, address, childName, doctor, dateOfBirth);
        }
    }
}
