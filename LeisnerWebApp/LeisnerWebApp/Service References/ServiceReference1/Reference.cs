﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeisnerWebApp.ServiceReference1 {
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
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeekIDField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WeekID {
            get {
                return this.WeekIDField;
            }
            set {
                if ((this.WeekIDField.Equals(value) != true)) {
                    this.WeekIDField = value;
                    this.RaisePropertyChanged("WeekID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Common", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWebService.Classes")]
    [System.SerializableAttribute()]
    public partial class Common : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DayIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HourIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SizeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeekIdField;
        
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
        public int DayId {
            get {
                return this.DayIdField;
            }
            set {
                if ((this.DayIdField.Equals(value) != true)) {
                    this.DayIdField = value;
                    this.RaisePropertyChanged("DayId");
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
        public int SizeId {
            get {
                return this.SizeIdField;
            }
            set {
                if ((this.SizeIdField.Equals(value) != true)) {
                    this.SizeIdField = value;
                    this.RaisePropertyChanged("SizeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WeekId {
            get {
                return this.WeekIdField;
            }
            set {
                if ((this.WeekIdField.Equals(value) != true)) {
                    this.WeekIdField = value;
                    this.RaisePropertyChanged("WeekId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Stats", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWebService.Classes")]
    [System.SerializableAttribute()]
    public partial class Stats : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Day_of_weekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Pee_sizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Week_IdField;
        
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
        public string Day_of_week {
            get {
                return this.Day_of_weekField;
            }
            set {
                if ((object.ReferenceEquals(this.Day_of_weekField, value) != true)) {
                    this.Day_of_weekField = value;
                    this.RaisePropertyChanged("Day_of_week");
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
        public int Pee_size {
            get {
                return this.Pee_sizeField;
            }
            set {
                if ((this.Pee_sizeField.Equals(value) != true)) {
                    this.Pee_sizeField = value;
                    this.RaisePropertyChanged("Pee_size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Week_Id {
            get {
                return this.Week_IdField;
            }
            set {
                if ((this.Week_IdField.Equals(value) != true)) {
                    this.Week_IdField = value;
                    this.RaisePropertyChanged("Week_Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDBAccessService")]
    public interface IDBAccessService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindPerson", ReplyAction="http://tempuri.org/IDBAccessService/FindPersonResponse")]
        void FindPerson(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindPerson", ReplyAction="http://tempuri.org/IDBAccessService/FindPersonResponse")]
        System.Threading.Tasks.Task FindPersonAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllPersons", ReplyAction="http://tempuri.org/IDBAccessService/FindAllPersonsResponse")]
        LeisnerWebApp.ServiceReference1.Person[] FindAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllPersons", ReplyAction="http://tempuri.org/IDBAccessService/FindAllPersonsResponse")]
        System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Person[]> FindAllPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindTime", ReplyAction="http://tempuri.org/IDBAccessService/FindTimeResponse")]
        void FindTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindTime", ReplyAction="http://tempuri.org/IDBAccessService/FindTimeResponse")]
        System.Threading.Tasks.Task FindTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllTimes", ReplyAction="http://tempuri.org/IDBAccessService/FindAllTimesResponse")]
        LeisnerWebApp.ServiceReference1.Time[] FindAllTimes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindAllTimes", ReplyAction="http://tempuri.org/IDBAccessService/FindAllTimesResponse")]
        System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Time[]> FindAllTimesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SavePerson", ReplyAction="http://tempuri.org/IDBAccessService/SavePersonResponse")]
        void SavePerson(int Status, string Email, string Password, string Name, string Address, string ChildsName, string Doctor, string DateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SavePerson", ReplyAction="http://tempuri.org/IDBAccessService/SavePersonResponse")]
        System.Threading.Tasks.Task SavePersonAsync(int Status, string Email, string Password, string Name, string Address, string ChildsName, string Doctor, string DateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SaveHour", ReplyAction="http://tempuri.org/IDBAccessService/SaveHourResponse")]
        void SaveHour(string Hour);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SaveHour", ReplyAction="http://tempuri.org/IDBAccessService/SaveHourResponse")]
        System.Threading.Tasks.Task SaveHourAsync(string Hour);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindInfo", ReplyAction="http://tempuri.org/IDBAccessService/FindInfoResponse")]
        LeisnerWebApp.ServiceReference1.Common[] FindInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/FindInfo", ReplyAction="http://tempuri.org/IDBAccessService/FindInfoResponse")]
        System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Common[]> FindInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SaveInfo", ReplyAction="http://tempuri.org/IDBAccessService/SaveInfoResponse")]
        void SaveInfo(int personId, int weekId, int hourId, int dayId, int peePeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/SaveInfo", ReplyAction="http://tempuri.org/IDBAccessService/SaveInfoResponse")]
        System.Threading.Tasks.Task SaveInfoAsync(int personId, int weekId, int hourId, int dayId, int peePeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/GetStats", ReplyAction="http://tempuri.org/IDBAccessService/GetStatsResponse")]
        LeisnerWebApp.ServiceReference1.Stats[] GetStats();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/GetStats", ReplyAction="http://tempuri.org/IDBAccessService/GetStatsResponse")]
        System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Stats[]> GetStatsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/UpdatePerson", ReplyAction="http://tempuri.org/IDBAccessService/UpdatePersonResponse")]
        void UpdatePerson(string email, string password, string name, string address, string doctor, string childsname, string dateofbirth, int status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/UpdatePerson", ReplyAction="http://tempuri.org/IDBAccessService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(string email, string password, string name, string address, string doctor, string childsname, string dateofbirth, int status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/DeletePerson", ReplyAction="http://tempuri.org/IDBAccessService/DeletePersonResponse")]
        bool DeletePerson(int personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBAccessService/DeletePerson", ReplyAction="http://tempuri.org/IDBAccessService/DeletePersonResponse")]
        System.Threading.Tasks.Task<bool> DeletePersonAsync(int personId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBAccessServiceChannel : LeisnerWebApp.ServiceReference1.IDBAccessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBAccessServiceClient : System.ServiceModel.ClientBase<LeisnerWebApp.ServiceReference1.IDBAccessService>, LeisnerWebApp.ServiceReference1.IDBAccessService {
        
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
        
        public void FindPerson(string Email) {
            base.Channel.FindPerson(Email);
        }
        
        public System.Threading.Tasks.Task FindPersonAsync(string Email) {
            return base.Channel.FindPersonAsync(Email);
        }
        
        public LeisnerWebApp.ServiceReference1.Person[] FindAllPersons() {
            return base.Channel.FindAllPersons();
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Person[]> FindAllPersonsAsync() {
            return base.Channel.FindAllPersonsAsync();
        }
        
        public void FindTime() {
            base.Channel.FindTime();
        }
        
        public System.Threading.Tasks.Task FindTimeAsync() {
            return base.Channel.FindTimeAsync();
        }
        
        public LeisnerWebApp.ServiceReference1.Time[] FindAllTimes() {
            return base.Channel.FindAllTimes();
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Time[]> FindAllTimesAsync() {
            return base.Channel.FindAllTimesAsync();
        }
        
        public void SavePerson(int Status, string Email, string Password, string Name, string Address, string ChildsName, string Doctor, string DateOfBirth) {
            base.Channel.SavePerson(Status, Email, Password, Name, Address, ChildsName, Doctor, DateOfBirth);
        }
        
        public System.Threading.Tasks.Task SavePersonAsync(int Status, string Email, string Password, string Name, string Address, string ChildsName, string Doctor, string DateOfBirth) {
            return base.Channel.SavePersonAsync(Status, Email, Password, Name, Address, ChildsName, Doctor, DateOfBirth);
        }
        
        public void SaveHour(string Hour) {
            base.Channel.SaveHour(Hour);
        }
        
        public System.Threading.Tasks.Task SaveHourAsync(string Hour) {
            return base.Channel.SaveHourAsync(Hour);
        }
        
        public LeisnerWebApp.ServiceReference1.Common[] FindInfo() {
            return base.Channel.FindInfo();
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Common[]> FindInfoAsync() {
            return base.Channel.FindInfoAsync();
        }
        
        public void SaveInfo(int personId, int weekId, int hourId, int dayId, int peePeeId) {
            base.Channel.SaveInfo(personId, weekId, hourId, dayId, peePeeId);
        }
        
        public System.Threading.Tasks.Task SaveInfoAsync(int personId, int weekId, int hourId, int dayId, int peePeeId) {
            return base.Channel.SaveInfoAsync(personId, weekId, hourId, dayId, peePeeId);
        }
        
        public LeisnerWebApp.ServiceReference1.Stats[] GetStats() {
            return base.Channel.GetStats();
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApp.ServiceReference1.Stats[]> GetStatsAsync() {
            return base.Channel.GetStatsAsync();
        }
        
        public void UpdatePerson(string email, string password, string name, string address, string doctor, string childsname, string dateofbirth, int status) {
            base.Channel.UpdatePerson(email, password, name, address, doctor, childsname, dateofbirth, status);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(string email, string password, string name, string address, string doctor, string childsname, string dateofbirth, int status) {
            return base.Channel.UpdatePersonAsync(email, password, name, address, doctor, childsname, dateofbirth, status);
        }
        
        public bool DeletePerson(int personId) {
            return base.Channel.DeletePerson(personId);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePersonAsync(int personId) {
            return base.Channel.DeletePersonAsync(personId);
        }
    }
}
