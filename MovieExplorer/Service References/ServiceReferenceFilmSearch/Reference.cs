﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace MovieExplorer.ServiceReferenceFilmSearch {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:WSFilmSearch", ConfigurationName="ServiceReferenceFilmSearch.WSFilmSearchPortType")]
    public interface WSFilmSearchPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.flosti.net/ws_film_search.php/SearchMoviesByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<MovieExplorer.ServiceReferenceFilmSearch.SearchMoviesByNameResponse> SearchMoviesByNameAsync(MovieExplorer.ServiceReferenceFilmSearch.SearchMoviesByNameRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:WSFilmSearch")]
    public partial class Film : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string titleField;
        
        private string descriptionField;
        
        private int yearField;
        
        private string posterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
                this.RaisePropertyChanged("Year");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Poster {
            get {
                return this.posterField;
            }
            set {
                this.posterField = value;
                this.RaisePropertyChanged("Poster");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchMoviesByName", WrapperNamespace="WSFlosti", IsWrapped=true)]
    public partial class SearchMoviesByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string title;
        
        public SearchMoviesByNameRequest() {
        }
        
        public SearchMoviesByNameRequest(string title) {
            this.title = title;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchMoviesByNameResponse", WrapperNamespace="WSFlosti", IsWrapped=true)]
    public partial class SearchMoviesByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public MovieExplorer.ServiceReferenceFilmSearch.Film[] @return;
        
        public SearchMoviesByNameResponse() {
        }
        
        public SearchMoviesByNameResponse(MovieExplorer.ServiceReferenceFilmSearch.Film[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSFilmSearchPortTypeChannel : MovieExplorer.ServiceReferenceFilmSearch.WSFilmSearchPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSFilmSearchPortTypeClient : System.ServiceModel.ClientBase<MovieExplorer.ServiceReferenceFilmSearch.WSFilmSearchPortType>, MovieExplorer.ServiceReferenceFilmSearch.WSFilmSearchPortType {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WSFilmSearchPortTypeClient() : 
                base(WSFilmSearchPortTypeClient.GetDefaultBinding(), WSFilmSearchPortTypeClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.WSFilmSearchPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSFilmSearchPortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(WSFilmSearchPortTypeClient.GetBindingForEndpoint(endpointConfiguration), WSFilmSearchPortTypeClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSFilmSearchPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WSFilmSearchPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSFilmSearchPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WSFilmSearchPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSFilmSearchPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MovieExplorer.ServiceReferenceFilmSearch.SearchMoviesByNameResponse> MovieExplorer.ServiceReferenceFilmSearch.WSFilmSearchPortType.SearchMoviesByNameAsync(MovieExplorer.ServiceReferenceFilmSearch.SearchMoviesByNameRequest request) {
            return base.Channel.SearchMoviesByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<MovieExplorer.ServiceReferenceFilmSearch.SearchMoviesByNameResponse> SearchMoviesByNameAsync(string title) {
            MovieExplorer.ServiceReferenceFilmSearch.SearchMoviesByNameRequest inValue = new MovieExplorer.ServiceReferenceFilmSearch.SearchMoviesByNameRequest();
            inValue.title = title;
            return ((MovieExplorer.ServiceReferenceFilmSearch.WSFilmSearchPortType)(this)).SearchMoviesByNameAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.WSFilmSearchPort)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.WSFilmSearchPort)) {
                return new System.ServiceModel.EndpointAddress("http://ws.flosti.net/ws_film_search.php");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return WSFilmSearchPortTypeClient.GetBindingForEndpoint(EndpointConfiguration.WSFilmSearchPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return WSFilmSearchPortTypeClient.GetEndpointAddress(EndpointConfiguration.WSFilmSearchPort);
        }
        
        public enum EndpointConfiguration {
            
            WSFilmSearchPort,
        }
    }
}
