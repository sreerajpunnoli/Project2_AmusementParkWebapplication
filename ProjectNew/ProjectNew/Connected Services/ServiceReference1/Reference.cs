﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectNew.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Transaction", Namespace="http://entity.assignment3.mcda5510.com")]
    [System.SerializableAttribute()]
    public partial class Transaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string cardNoField;
        
        private string cardTypeField;
        
        private string createdByField;
        
        private System.Nullable<System.DateTime> createdOnField;
        
        private string expDateField;
        
        private System.Nullable<int> idField;
        
        private string nameOnCardField;
        
        private System.Nullable<int> quantityField;
        
        private System.Nullable<float> totalPriceField;
        
        private System.Nullable<float> unitPriceField;
        
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
        public string cardNo {
            get {
                return this.cardNoField;
            }
            set {
                if ((object.ReferenceEquals(this.cardNoField, value) != true)) {
                    this.cardNoField = value;
                    this.RaisePropertyChanged("cardNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string cardType {
            get {
                return this.cardTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.cardTypeField, value) != true)) {
                    this.cardTypeField = value;
                    this.RaisePropertyChanged("cardType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string createdBy {
            get {
                return this.createdByField;
            }
            set {
                if ((object.ReferenceEquals(this.createdByField, value) != true)) {
                    this.createdByField = value;
                    this.RaisePropertyChanged("createdBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> createdOn {
            get {
                return this.createdOnField;
            }
            set {
                if ((this.createdOnField.Equals(value) != true)) {
                    this.createdOnField = value;
                    this.RaisePropertyChanged("createdOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string expDate {
            get {
                return this.expDateField;
            }
            set {
                if ((object.ReferenceEquals(this.expDateField, value) != true)) {
                    this.expDateField = value;
                    this.RaisePropertyChanged("expDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string nameOnCard {
            get {
                return this.nameOnCardField;
            }
            set {
                if ((object.ReferenceEquals(this.nameOnCardField, value) != true)) {
                    this.nameOnCardField = value;
                    this.RaisePropertyChanged("nameOnCard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField.Equals(value) != true)) {
                    this.quantityField = value;
                    this.RaisePropertyChanged("quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<float> totalPrice {
            get {
                return this.totalPriceField;
            }
            set {
                if ((this.totalPriceField.Equals(value) != true)) {
                    this.totalPriceField = value;
                    this.RaisePropertyChanged("totalPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<float> unitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                if ((this.unitPriceField.Equals(value) != true)) {
                    this.unitPriceField = value;
                    this.RaisePropertyChanged("unitPrice");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.assignment3.mcda5510.com", ConfigurationName="ServiceReference1.TransactionWebserviceImpl")]
    public interface TransactionWebserviceImpl {
        
        // CODEGEN: Generating message contract since element name getTransactionReturn from namespace http://service.assignment3.mcda5510.com is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        ProjectNew.ServiceReference1.getTransactionResponse getTransaction(ProjectNew.ServiceReference1.getTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectNew.ServiceReference1.getTransactionResponse> getTransactionAsync(ProjectNew.ServiceReference1.getTransactionRequest request);
        
        // CODEGEN: Generating message contract since element name transaction from namespace http://service.assignment3.mcda5510.com is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        ProjectNew.ServiceReference1.createTransactionResponse createTransaction(ProjectNew.ServiceReference1.createTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectNew.ServiceReference1.createTransactionResponse> createTransactionAsync(ProjectNew.ServiceReference1.createTransactionRequest request);
        
        // CODEGEN: Generating message contract since element name transaction from namespace http://service.assignment3.mcda5510.com is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        ProjectNew.ServiceReference1.updateTransactionResponse updateTransaction(ProjectNew.ServiceReference1.updateTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectNew.ServiceReference1.updateTransactionResponse> updateTransactionAsync(ProjectNew.ServiceReference1.updateTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="removeTransactionReturn")]
        bool removeTransaction(int transactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="removeTransactionReturn")]
        System.Threading.Tasks.Task<bool> removeTransactionAsync(int transactionId);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getTransactionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getTransaction", Namespace="http://service.assignment3.mcda5510.com", Order=0)]
        public ProjectNew.ServiceReference1.getTransactionRequestBody Body;
        
        public getTransactionRequest() {
        }
        
        public getTransactionRequest(ProjectNew.ServiceReference1.getTransactionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://service.assignment3.mcda5510.com")]
    public partial class getTransactionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int transactionId;
        
        public getTransactionRequestBody() {
        }
        
        public getTransactionRequestBody(int transactionId) {
            this.transactionId = transactionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getTransactionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getTransactionResponse", Namespace="http://service.assignment3.mcda5510.com", Order=0)]
        public ProjectNew.ServiceReference1.getTransactionResponseBody Body;
        
        public getTransactionResponse() {
        }
        
        public getTransactionResponse(ProjectNew.ServiceReference1.getTransactionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://service.assignment3.mcda5510.com")]
    public partial class getTransactionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProjectNew.ServiceReference1.Transaction getTransactionReturn;
        
        public getTransactionResponseBody() {
        }
        
        public getTransactionResponseBody(ProjectNew.ServiceReference1.Transaction getTransactionReturn) {
            this.getTransactionReturn = getTransactionReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createTransactionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createTransaction", Namespace="http://service.assignment3.mcda5510.com", Order=0)]
        public ProjectNew.ServiceReference1.createTransactionRequestBody Body;
        
        public createTransactionRequest() {
        }
        
        public createTransactionRequest(ProjectNew.ServiceReference1.createTransactionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://service.assignment3.mcda5510.com")]
    public partial class createTransactionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProjectNew.ServiceReference1.Transaction transaction;
        
        public createTransactionRequestBody() {
        }
        
        public createTransactionRequestBody(ProjectNew.ServiceReference1.Transaction transaction) {
            this.transaction = transaction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createTransactionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createTransactionResponse", Namespace="http://service.assignment3.mcda5510.com", Order=0)]
        public ProjectNew.ServiceReference1.createTransactionResponseBody Body;
        
        public createTransactionResponse() {
        }
        
        public createTransactionResponse(ProjectNew.ServiceReference1.createTransactionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://service.assignment3.mcda5510.com")]
    public partial class createTransactionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool createTransactionReturn;
        
        public createTransactionResponseBody() {
        }
        
        public createTransactionResponseBody(bool createTransactionReturn) {
            this.createTransactionReturn = createTransactionReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateTransactionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateTransaction", Namespace="http://service.assignment3.mcda5510.com", Order=0)]
        public ProjectNew.ServiceReference1.updateTransactionRequestBody Body;
        
        public updateTransactionRequest() {
        }
        
        public updateTransactionRequest(ProjectNew.ServiceReference1.updateTransactionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://service.assignment3.mcda5510.com")]
    public partial class updateTransactionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProjectNew.ServiceReference1.Transaction transaction;
        
        public updateTransactionRequestBody() {
        }
        
        public updateTransactionRequestBody(ProjectNew.ServiceReference1.Transaction transaction) {
            this.transaction = transaction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateTransactionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateTransactionResponse", Namespace="http://service.assignment3.mcda5510.com", Order=0)]
        public ProjectNew.ServiceReference1.updateTransactionResponseBody Body;
        
        public updateTransactionResponse() {
        }
        
        public updateTransactionResponse(ProjectNew.ServiceReference1.updateTransactionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://service.assignment3.mcda5510.com")]
    public partial class updateTransactionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool updateTransactionReturn;
        
        public updateTransactionResponseBody() {
        }
        
        public updateTransactionResponseBody(bool updateTransactionReturn) {
            this.updateTransactionReturn = updateTransactionReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TransactionWebserviceImplChannel : ProjectNew.ServiceReference1.TransactionWebserviceImpl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransactionWebserviceImplClient : System.ServiceModel.ClientBase<ProjectNew.ServiceReference1.TransactionWebserviceImpl>, ProjectNew.ServiceReference1.TransactionWebserviceImpl {
        
        public TransactionWebserviceImplClient() {
        }
        
        public TransactionWebserviceImplClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransactionWebserviceImplClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionWebserviceImplClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionWebserviceImplClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectNew.ServiceReference1.getTransactionResponse ProjectNew.ServiceReference1.TransactionWebserviceImpl.getTransaction(ProjectNew.ServiceReference1.getTransactionRequest request) {
            return base.Channel.getTransaction(request);
        }
        
        public ProjectNew.ServiceReference1.Transaction getTransaction(int transactionId) {
            ProjectNew.ServiceReference1.getTransactionRequest inValue = new ProjectNew.ServiceReference1.getTransactionRequest();
            inValue.Body = new ProjectNew.ServiceReference1.getTransactionRequestBody();
            inValue.Body.transactionId = transactionId;
            ProjectNew.ServiceReference1.getTransactionResponse retVal = ((ProjectNew.ServiceReference1.TransactionWebserviceImpl)(this)).getTransaction(inValue);
            return retVal.Body.getTransactionReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectNew.ServiceReference1.getTransactionResponse> ProjectNew.ServiceReference1.TransactionWebserviceImpl.getTransactionAsync(ProjectNew.ServiceReference1.getTransactionRequest request) {
            return base.Channel.getTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectNew.ServiceReference1.getTransactionResponse> getTransactionAsync(int transactionId) {
            ProjectNew.ServiceReference1.getTransactionRequest inValue = new ProjectNew.ServiceReference1.getTransactionRequest();
            inValue.Body = new ProjectNew.ServiceReference1.getTransactionRequestBody();
            inValue.Body.transactionId = transactionId;
            return ((ProjectNew.ServiceReference1.TransactionWebserviceImpl)(this)).getTransactionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectNew.ServiceReference1.createTransactionResponse ProjectNew.ServiceReference1.TransactionWebserviceImpl.createTransaction(ProjectNew.ServiceReference1.createTransactionRequest request) {
            return base.Channel.createTransaction(request);
        }
        
        public bool createTransaction(ProjectNew.ServiceReference1.Transaction transaction) {
            ProjectNew.ServiceReference1.createTransactionRequest inValue = new ProjectNew.ServiceReference1.createTransactionRequest();
            inValue.Body = new ProjectNew.ServiceReference1.createTransactionRequestBody();
            inValue.Body.transaction = transaction;
            ProjectNew.ServiceReference1.createTransactionResponse retVal = ((ProjectNew.ServiceReference1.TransactionWebserviceImpl)(this)).createTransaction(inValue);
            return retVal.Body.createTransactionReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectNew.ServiceReference1.createTransactionResponse> ProjectNew.ServiceReference1.TransactionWebserviceImpl.createTransactionAsync(ProjectNew.ServiceReference1.createTransactionRequest request) {
            return base.Channel.createTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectNew.ServiceReference1.createTransactionResponse> createTransactionAsync(ProjectNew.ServiceReference1.Transaction transaction) {
            ProjectNew.ServiceReference1.createTransactionRequest inValue = new ProjectNew.ServiceReference1.createTransactionRequest();
            inValue.Body = new ProjectNew.ServiceReference1.createTransactionRequestBody();
            inValue.Body.transaction = transaction;
            return ((ProjectNew.ServiceReference1.TransactionWebserviceImpl)(this)).createTransactionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectNew.ServiceReference1.updateTransactionResponse ProjectNew.ServiceReference1.TransactionWebserviceImpl.updateTransaction(ProjectNew.ServiceReference1.updateTransactionRequest request) {
            return base.Channel.updateTransaction(request);
        }
        
        public bool updateTransaction(ProjectNew.ServiceReference1.Transaction transaction) {
            ProjectNew.ServiceReference1.updateTransactionRequest inValue = new ProjectNew.ServiceReference1.updateTransactionRequest();
            inValue.Body = new ProjectNew.ServiceReference1.updateTransactionRequestBody();
            inValue.Body.transaction = transaction;
            ProjectNew.ServiceReference1.updateTransactionResponse retVal = ((ProjectNew.ServiceReference1.TransactionWebserviceImpl)(this)).updateTransaction(inValue);
            return retVal.Body.updateTransactionReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectNew.ServiceReference1.updateTransactionResponse> ProjectNew.ServiceReference1.TransactionWebserviceImpl.updateTransactionAsync(ProjectNew.ServiceReference1.updateTransactionRequest request) {
            return base.Channel.updateTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectNew.ServiceReference1.updateTransactionResponse> updateTransactionAsync(ProjectNew.ServiceReference1.Transaction transaction) {
            ProjectNew.ServiceReference1.updateTransactionRequest inValue = new ProjectNew.ServiceReference1.updateTransactionRequest();
            inValue.Body = new ProjectNew.ServiceReference1.updateTransactionRequestBody();
            inValue.Body.transaction = transaction;
            return ((ProjectNew.ServiceReference1.TransactionWebserviceImpl)(this)).updateTransactionAsync(inValue);
        }
        
        public bool removeTransaction(int transactionId) {
            return base.Channel.removeTransaction(transactionId);
        }
        
        public System.Threading.Tasks.Task<bool> removeTransactionAsync(int transactionId) {
            return base.Channel.removeTransactionAsync(transactionId);
        }
    }
}
