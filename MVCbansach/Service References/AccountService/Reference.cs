﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCbansach.AccountService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/BookstoreService.EF")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AvatarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreatedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DayOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FacebookField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ModifiedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifiedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RolesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string YahooField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public string Avatar {
            get {
                return this.AvatarField;
            }
            set {
                if ((object.ReferenceEquals(this.AvatarField, value) != true)) {
                    this.AvatarField = value;
                    this.RaisePropertyChanged("Avatar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreatedBy {
            get {
                return this.CreatedByField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatedByField, value) != true)) {
                    this.CreatedByField = value;
                    this.RaisePropertyChanged("CreatedBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DayOfBirth {
            get {
                return this.DayOfBirthField;
            }
            set {
                if ((this.DayOfBirthField.Equals(value) != true)) {
                    this.DayOfBirthField = value;
                    this.RaisePropertyChanged("DayOfBirth");
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
        public string Facebook {
            get {
                return this.FacebookField;
            }
            set {
                if ((object.ReferenceEquals(this.FacebookField, value) != true)) {
                    this.FacebookField = value;
                    this.RaisePropertyChanged("Facebook");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fullname {
            get {
                return this.FullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullnameField, value) != true)) {
                    this.FullnameField = value;
                    this.RaisePropertyChanged("Fullname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GroupId {
            get {
                return this.GroupIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupIdField, value) != true)) {
                    this.GroupIdField = value;
                    this.RaisePropertyChanged("GroupId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifiedAt {
            get {
                return this.ModifiedAtField;
            }
            set {
                if ((this.ModifiedAtField.Equals(value) != true)) {
                    this.ModifiedAtField = value;
                    this.RaisePropertyChanged("ModifiedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModifiedBy {
            get {
                return this.ModifiedByField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifiedByField, value) != true)) {
                    this.ModifiedByField = value;
                    this.RaisePropertyChanged("ModifiedBy");
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
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Roles {
            get {
                return this.RolesField;
            }
            set {
                if ((object.ReferenceEquals(this.RolesField, value) != true)) {
                    this.RolesField = value;
                    this.RaisePropertyChanged("Roles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Skype {
            get {
                return this.SkypeField;
            }
            set {
                if ((object.ReferenceEquals(this.SkypeField, value) != true)) {
                    this.SkypeField = value;
                    this.RaisePropertyChanged("Skype");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Status {
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
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Yahoo {
            get {
                return this.YahooField;
            }
            set {
                if ((object.ReferenceEquals(this.YahooField, value) != true)) {
                    this.YahooField = value;
                    this.RaisePropertyChanged("Yahoo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService.IAccount")]
    public interface IAccount {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/findAll", ReplyAction="http://tempuri.org/IModelOf_Account/findAllResponse")]
        MVCbansach.AccountService.Account[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/findAll", ReplyAction="http://tempuri.org/IModelOf_Account/findAllResponse")]
        System.Threading.Tasks.Task<MVCbansach.AccountService.Account[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/findById", ReplyAction="http://tempuri.org/IModelOf_Account/findByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MVCbansach.AccountService.Account[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MVCbansach.AccountService.Account))]
        MVCbansach.AccountService.Account findById(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/findById", ReplyAction="http://tempuri.org/IModelOf_Account/findByIdResponse")]
        System.Threading.Tasks.Task<MVCbansach.AccountService.Account> findByIdAsync(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/insert", ReplyAction="http://tempuri.org/IModelOf_Account/insertResponse")]
        long insert(MVCbansach.AccountService.Account entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/insert", ReplyAction="http://tempuri.org/IModelOf_Account/insertResponse")]
        System.Threading.Tasks.Task<long> insertAsync(MVCbansach.AccountService.Account entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/update", ReplyAction="http://tempuri.org/IModelOf_Account/updateResponse")]
        bool update(MVCbansach.AccountService.Account entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/update", ReplyAction="http://tempuri.org/IModelOf_Account/updateResponse")]
        System.Threading.Tasks.Task<bool> updateAsync(MVCbansach.AccountService.Account entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/delete", ReplyAction="http://tempuri.org/IModelOf_Account/deleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MVCbansach.AccountService.Account[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MVCbansach.AccountService.Account))]
        bool delete(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Account/delete", ReplyAction="http://tempuri.org/IModelOf_Account/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Authenticate", ReplyAction="http://tempuri.org/IAccount/AuthenticateResponse")]
        MVCbansach.AccountService.Account Authenticate(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Authenticate", ReplyAction="http://tempuri.org/IAccount/AuthenticateResponse")]
        System.Threading.Tasks.Task<MVCbansach.AccountService.Account> AuthenticateAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/findAccountsByGroup", ReplyAction="http://tempuri.org/IAccount/findAccountsByGroupResponse")]
        MVCbansach.AccountService.Account[] findAccountsByGroup(string groupID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/findAccountsByGroup", ReplyAction="http://tempuri.org/IAccount/findAccountsByGroupResponse")]
        System.Threading.Tasks.Task<MVCbansach.AccountService.Account[]> findAccountsByGroupAsync(string groupID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/findAccountByUsername", ReplyAction="http://tempuri.org/IAccount/findAccountByUsernameResponse")]
        MVCbansach.AccountService.Account findAccountByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/findAccountByUsername", ReplyAction="http://tempuri.org/IAccount/findAccountByUsernameResponse")]
        System.Threading.Tasks.Task<MVCbansach.AccountService.Account> findAccountByUsernameAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountChannel : MVCbansach.AccountService.IAccount, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountClient : System.ServiceModel.ClientBase<MVCbansach.AccountService.IAccount>, MVCbansach.AccountService.IAccount {
        
        public AccountClient() {
        }
        
        public AccountClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVCbansach.AccountService.Account[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<MVCbansach.AccountService.Account[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public MVCbansach.AccountService.Account findById(object id) {
            return base.Channel.findById(id);
        }
        
        public System.Threading.Tasks.Task<MVCbansach.AccountService.Account> findByIdAsync(object id) {
            return base.Channel.findByIdAsync(id);
        }
        
        public long insert(MVCbansach.AccountService.Account entity) {
            return base.Channel.insert(entity);
        }
        
        public System.Threading.Tasks.Task<long> insertAsync(MVCbansach.AccountService.Account entity) {
            return base.Channel.insertAsync(entity);
        }
        
        public bool update(MVCbansach.AccountService.Account entity) {
            return base.Channel.update(entity);
        }
        
        public System.Threading.Tasks.Task<bool> updateAsync(MVCbansach.AccountService.Account entity) {
            return base.Channel.updateAsync(entity);
        }
        
        public bool delete(object id) {
            return base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(object id) {
            return base.Channel.deleteAsync(id);
        }
        
        public MVCbansach.AccountService.Account Authenticate(string username, string password) {
            return base.Channel.Authenticate(username, password);
        }
        
        public System.Threading.Tasks.Task<MVCbansach.AccountService.Account> AuthenticateAsync(string username, string password) {
            return base.Channel.AuthenticateAsync(username, password);
        }
        
        public MVCbansach.AccountService.Account[] findAccountsByGroup(string groupID) {
            return base.Channel.findAccountsByGroup(groupID);
        }
        
        public System.Threading.Tasks.Task<MVCbansach.AccountService.Account[]> findAccountsByGroupAsync(string groupID) {
            return base.Channel.findAccountsByGroupAsync(groupID);
        }
        
        public MVCbansach.AccountService.Account findAccountByUsername(string username) {
            return base.Channel.findAccountByUsername(username);
        }
        
        public System.Threading.Tasks.Task<MVCbansach.AccountService.Account> findAccountByUsernameAsync(string username) {
            return base.Channel.findAccountByUsernameAsync(username);
        }
    }
}
