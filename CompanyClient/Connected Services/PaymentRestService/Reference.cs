﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyClient.PaymentRestService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaymentRestService.IPayMentService")]
    public interface IPayMentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayMentService/PayBill", ReplyAction="http://tempuri.org/IPayMentService/PayBillResponse")]
        string PayBill(string PayId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayMentService/PayBill", ReplyAction="http://tempuri.org/IPayMentService/PayBillResponse")]
        System.Threading.Tasks.Task<string> PayBillAsync(string PayId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPayMentServiceChannel : CompanyClient.PaymentRestService.IPayMentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PayMentServiceClient : System.ServiceModel.ClientBase<CompanyClient.PaymentRestService.IPayMentService>, CompanyClient.PaymentRestService.IPayMentService {
        
        public PayMentServiceClient() {
        }
        
        public PayMentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PayMentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PayMentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PayMentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string PayBill(string PayId) {
            return base.Channel.PayBill(PayId);
        }
        
        public System.Threading.Tasks.Task<string> PayBillAsync(string PayId) {
            return base.Channel.PayBillAsync(PayId);
        }
    }
}
