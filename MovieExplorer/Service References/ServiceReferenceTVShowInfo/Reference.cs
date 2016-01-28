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
namespace MovieExplorer.ServiceReferenceTVShowInfo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:WSTvInfo", ConfigurationName="ServiceReferenceTVShowInfo.WSTvInfoPortType")]
    public interface WSTvInfoPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.flosti.net/ws_tv_info.php/GetTvShowDataById", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<MovieExplorer.ServiceReferenceTVShowInfo.GetTvShowDataByIdResponse> GetTvShowDataByIdAsync(MovieExplorer.ServiceReferenceTVShowInfo.GetTvShowDataByIdRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:WSTvInfo")]
    public partial class TvShowInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string titleField;
        
        private int dayField;
        
        private int monthField;
        
        private int yearField;
        
        private string summaryField;
        
        private string backgroundField;
        
        private decimal rateField;
        
        private string webField;
        
        private string posterField;
        
        private string statusField;
        
        private int numEpisodesField;
        
        private int numSeasonsField;
        
        private string[] genresField;
        
        private CreatorInfo[] creatorsField;
        
        private SeasonInfo[] seasonsField;
        
        private ActorInfo[] castField;
        
        private CrewInfo[] crewField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int Day {
            get {
                return this.dayField;
            }
            set {
                this.dayField = value;
                this.RaisePropertyChanged("Day");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int Month {
            get {
                return this.monthField;
            }
            set {
                this.monthField = value;
                this.RaisePropertyChanged("Month");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
                this.RaisePropertyChanged("Summary");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string Background {
            get {
                return this.backgroundField;
            }
            set {
                this.backgroundField = value;
                this.RaisePropertyChanged("Background");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public decimal Rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
                this.RaisePropertyChanged("Rate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string Web {
            get {
                return this.webField;
            }
            set {
                this.webField = value;
                this.RaisePropertyChanged("Web");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string Poster {
            get {
                return this.posterField;
            }
            set {
                this.posterField = value;
                this.RaisePropertyChanged("Poster");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int NumEpisodes {
            get {
                return this.numEpisodesField;
            }
            set {
                this.numEpisodesField = value;
                this.RaisePropertyChanged("NumEpisodes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int NumSeasons {
            get {
                return this.numSeasonsField;
            }
            set {
                this.numSeasonsField = value;
                this.RaisePropertyChanged("NumSeasons");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Genres", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string[] Genres {
            get {
                return this.genresField;
            }
            set {
                this.genresField = value;
                this.RaisePropertyChanged("Genres");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Creators", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public CreatorInfo[] Creators {
            get {
                return this.creatorsField;
            }
            set {
                this.creatorsField = value;
                this.RaisePropertyChanged("Creators");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Seasons", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public SeasonInfo[] Seasons {
            get {
                return this.seasonsField;
            }
            set {
                this.seasonsField = value;
                this.RaisePropertyChanged("Seasons");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cast", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public ActorInfo[] Cast {
            get {
                return this.castField;
            }
            set {
                this.castField = value;
                this.RaisePropertyChanged("Cast");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Crew", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public CrewInfo[] Crew {
            get {
                return this.crewField;
            }
            set {
                this.crewField = value;
                this.RaisePropertyChanged("Crew");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:WSTvInfo")]
    public partial class CreatorInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string pictureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Picture {
            get {
                return this.pictureField;
            }
            set {
                this.pictureField = value;
                this.RaisePropertyChanged("Picture");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:WSTvInfo")]
    public partial class CrewInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string departmentField;
        
        private string jobField;
        
        private string pictureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
                this.RaisePropertyChanged("Department");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
                this.RaisePropertyChanged("Job");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Picture {
            get {
                return this.pictureField;
            }
            set {
                this.pictureField = value;
                this.RaisePropertyChanged("Picture");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:WSTvInfo")]
    public partial class ActorInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string characterField;
        
        private string pictureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Character {
            get {
                return this.characterField;
            }
            set {
                this.characterField = value;
                this.RaisePropertyChanged("Character");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Picture {
            get {
                return this.pictureField;
            }
            set {
                this.pictureField = value;
                this.RaisePropertyChanged("Picture");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:WSTvInfo")]
    public partial class SeasonInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int numberField;
        
        private string airDateField;
        
        private string posterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
                this.RaisePropertyChanged("Number");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string AirDate {
            get {
                return this.airDateField;
            }
            set {
                this.airDateField = value;
                this.RaisePropertyChanged("AirDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTvShowDataById", WrapperNamespace="WSTvInfo", IsWrapped=true)]
    public partial class GetTvShowDataByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int id;
        
        public GetTvShowDataByIdRequest() {
        }
        
        public GetTvShowDataByIdRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTvShowDataByIdResponse", WrapperNamespace="WSTvInfo", IsWrapped=true)]
    public partial class GetTvShowDataByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public MovieExplorer.ServiceReferenceTVShowInfo.TvShowInfo @return;
        
        public GetTvShowDataByIdResponse() {
        }
        
        public GetTvShowDataByIdResponse(MovieExplorer.ServiceReferenceTVShowInfo.TvShowInfo @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSTvInfoPortTypeChannel : MovieExplorer.ServiceReferenceTVShowInfo.WSTvInfoPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSTvInfoPortTypeClient : System.ServiceModel.ClientBase<MovieExplorer.ServiceReferenceTVShowInfo.WSTvInfoPortType>, MovieExplorer.ServiceReferenceTVShowInfo.WSTvInfoPortType {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WSTvInfoPortTypeClient() : 
                base(WSTvInfoPortTypeClient.GetDefaultBinding(), WSTvInfoPortTypeClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.WSTvInfoPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSTvInfoPortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(WSTvInfoPortTypeClient.GetBindingForEndpoint(endpointConfiguration), WSTvInfoPortTypeClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSTvInfoPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WSTvInfoPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSTvInfoPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WSTvInfoPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSTvInfoPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MovieExplorer.ServiceReferenceTVShowInfo.GetTvShowDataByIdResponse> MovieExplorer.ServiceReferenceTVShowInfo.WSTvInfoPortType.GetTvShowDataByIdAsync(MovieExplorer.ServiceReferenceTVShowInfo.GetTvShowDataByIdRequest request) {
            return base.Channel.GetTvShowDataByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<MovieExplorer.ServiceReferenceTVShowInfo.GetTvShowDataByIdResponse> GetTvShowDataByIdAsync(int id) {
            MovieExplorer.ServiceReferenceTVShowInfo.GetTvShowDataByIdRequest inValue = new MovieExplorer.ServiceReferenceTVShowInfo.GetTvShowDataByIdRequest();
            inValue.id = id;
            return ((MovieExplorer.ServiceReferenceTVShowInfo.WSTvInfoPortType)(this)).GetTvShowDataByIdAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.WSTvInfoPort)) {
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
            if ((endpointConfiguration == EndpointConfiguration.WSTvInfoPort)) {
                return new System.ServiceModel.EndpointAddress("http://ws.flosti.net/ws_tv_info.php");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return WSTvInfoPortTypeClient.GetBindingForEndpoint(EndpointConfiguration.WSTvInfoPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return WSTvInfoPortTypeClient.GetEndpointAddress(EndpointConfiguration.WSTvInfoPort);
        }
        
        public enum EndpointConfiguration {
            
            WSTvInfoPort,
        }
    }
}
