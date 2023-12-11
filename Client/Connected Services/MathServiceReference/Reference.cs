﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyNumbers", Namespace="http://schemas.datacontract.org/2004/07/PPService")]
    public partial class MyNumbers : object
    {
        
        private int Number1Field;
        
        private int Number2Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number1
        {
            get
            {
                return this.Number1Field;
            }
            set
            {
                this.Number1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number2
        {
            get
            {
                return this.Number2Field;
            }
            set
            {
                this.Number2Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathServiceReference.IMathService")]
    public interface IMathService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(MathServiceReference.MyNumbers obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IMathServiceChannel : MathServiceReference.IMathService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<MathServiceReference.IMathService>, MathServiceReference.IMathService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MathServiceClient() : 
                base(MathServiceClient.GetDefaultBinding(), MathServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMathService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MathServiceClient.GetBindingForEndpoint(endpointConfiguration), MathServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MathServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MathServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(MathServiceReference.MyNumbers obj)
        {
            return base.Channel.AddAsync(obj);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(MathServiceReference.MyNumbers obj)
        {
            return base.Channel.SubtractAsync(obj);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMathService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMathService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:61934/MathService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MathServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMathService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MathServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMathService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMathService,
        }
    }
}