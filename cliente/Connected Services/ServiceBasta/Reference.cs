﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cliente.ServiceBasta {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBasta.IServiceBasta")]
    public interface IServiceBasta {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBasta/PruebaConeccion", ReplyAction="http://tempuri.org/IServiceBasta/PruebaConeccionResponse")]
        string PruebaConeccion(int valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBasta/PruebaConeccion", ReplyAction="http://tempuri.org/IServiceBasta/PruebaConeccionResponse")]
        System.Threading.Tasks.Task<string> PruebaConeccionAsync(int valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBasta/AgregarUsuario", ReplyAction="http://tempuri.org/IServiceBasta/AgregarUsuarioResponse")]
        void AgregarUsuario(string name, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBasta/AgregarUsuario", ReplyAction="http://tempuri.org/IServiceBasta/AgregarUsuarioResponse")]
        System.Threading.Tasks.Task AgregarUsuarioAsync(string name, string password, string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBastaChannel : cliente.ServiceBasta.IServiceBasta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBastaClient : System.ServiceModel.ClientBase<cliente.ServiceBasta.IServiceBasta>, cliente.ServiceBasta.IServiceBasta {
        
        public ServiceBastaClient() {
        }
        
        public ServiceBastaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBastaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBastaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBastaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string PruebaConeccion(int valor) {
            return base.Channel.PruebaConeccion(valor);
        }
        
        public System.Threading.Tasks.Task<string> PruebaConeccionAsync(int valor) {
            return base.Channel.PruebaConeccionAsync(valor);
        }
        
        public void AgregarUsuario(string name, string password, string email) {
            base.Channel.AgregarUsuario(name, password, email);
        }
        
        public System.Threading.Tasks.Task AgregarUsuarioAsync(string name, string password, string email) {
            return base.Channel.AgregarUsuarioAsync(name, password, email);
        }
    }
}
