﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSZClient.CardTypeParseServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SSZClient.CardTypeParseServiceReference.CardColor ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SSZClient.CardTypeParseServiceReference.CardNum NumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Drawing.Rectangle RectField;
        
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
        public SSZClient.CardTypeParseServiceReference.CardColor Color {
            get {
                return this.ColorField;
            }
            set {
                if ((this.ColorField.Equals(value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SSZClient.CardTypeParseServiceReference.CardNum Num {
            get {
                return this.NumField;
            }
            set {
                if ((this.NumField.Equals(value) != true)) {
                    this.NumField = value;
                    this.RaisePropertyChanged("Num");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Drawing.Rectangle Rect {
            get {
                return this.RectField;
            }
            set {
                if ((this.RectField.Equals(value) != true)) {
                    this.RectField = value;
                    this.RaisePropertyChanged("Rect");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardColor", Namespace="http://schemas.datacontract.org/2004/07/GXService.CardRecognize.Contract")]
    public enum CardColor : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        未知 = -1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        方块 = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        梅花 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        红桃 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        黑桃 = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardNum", Namespace="http://schemas.datacontract.org/2004/07/GXService.CardRecognize.Contract")]
    public enum CardNum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        未知 = -1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _2 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _3 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _4 = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _5 = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _6 = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _7 = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _8 = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _9 = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _10 = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _J = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _Q = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _K = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _A = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _Joke = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _BigJoke = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        _Any = 17,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardTypeResult", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class CardTypeResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SSZClient.CardTypeParseServiceReference.CardType CardTypeHeadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SSZClient.CardTypeParseServiceReference.CardType CardTypeMiddleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SSZClient.CardTypeParseServiceReference.CardType CardTypeTailField;
        
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
        public SSZClient.CardTypeParseServiceReference.CardType CardTypeHead {
            get {
                return this.CardTypeHeadField;
            }
            set {
                if ((object.ReferenceEquals(this.CardTypeHeadField, value) != true)) {
                    this.CardTypeHeadField = value;
                    this.RaisePropertyChanged("CardTypeHead");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SSZClient.CardTypeParseServiceReference.CardType CardTypeMiddle {
            get {
                return this.CardTypeMiddleField;
            }
            set {
                if ((object.ReferenceEquals(this.CardTypeMiddleField, value) != true)) {
                    this.CardTypeMiddleField = value;
                    this.RaisePropertyChanged("CardTypeMiddle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SSZClient.CardTypeParseServiceReference.CardType CardTypeTail {
            get {
                return this.CardTypeTailField;
            }
            set {
                if ((object.ReferenceEquals(this.CardTypeTailField, value) != true)) {
                    this.CardTypeTailField = value;
                    this.RaisePropertyChanged("CardTypeTail");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.NoTypeCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.BoomCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.GourdCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.PairInHeadCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.StraightFlushCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.FlushCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.StraightCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.NoTypeInHeadCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.ThreeSameCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.DoublePairCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.OnePairCardType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SSZClient.CardTypeParseServiceReference.ThreeSameInHeadCardType))]
    public partial class CardType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SSZClient.CardTypeParseServiceReference.EmTypeCard CardTypeEmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SSZClient.CardRecognizeServiceReference.Card[] CardsField;
        
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
        public SSZClient.CardTypeParseServiceReference.EmTypeCard CardTypeEm {
            get {
                return this.CardTypeEmField;
            }
            set {
                if ((this.CardTypeEmField.Equals(value) != true)) {
                    this.CardTypeEmField = value;
                    this.RaisePropertyChanged("CardTypeEm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SSZClient.CardRecognizeServiceReference.Card[] Cards {
            get {
                return this.CardsField;
            }
            set {
                if ((object.ReferenceEquals(this.CardsField, value) != true)) {
                    this.CardsField = value;
                    this.RaisePropertyChanged("Cards");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NoTypeCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class NoTypeCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BoomCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class BoomCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GourdCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class GourdCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PairInHeadCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class PairInHeadCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StraightFlushCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class StraightFlushCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FlushCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class FlushCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StraightCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class StraightCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NoTypeInHeadCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class NoTypeInHeadCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ThreeSameCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class ThreeSameCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DoublePairCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class DoublePairCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OnePairCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class OnePairCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ThreeSameInHeadCardType", Namespace="GXService.CardRecognize.Contract")]
    [System.SerializableAttribute()]
    public partial class ThreeSameInHeadCardType : SSZClient.CardTypeParseServiceReference.CardType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmTypeCard", Namespace="http://schemas.datacontract.org/2004/07/GXService.SSZGameServer.CardTypeParseServ" +
        "ice.Contract")]
    public enum EmTypeCard : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoType = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OnePair = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DoublePair = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ThreeSame = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Straight = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Flush = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Gourd = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Boom = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        StraightFlush = 8,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CardTypeParseServiceReference.ICardTypeParseService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICardTypeParseService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICardTypeParseService/Connect")]
        void Connect();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICardTypeParseService/Connect")]
        System.Threading.Tasks.Task ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTypeParseService/ParseCardType", ReplyAction="http://tempuri.org/ICardTypeParseService/ParseCardTypeResponse")]
        SSZClient.CardTypeParseServiceReference.CardTypeResult ParseCardType(SSZClient.CardRecognizeServiceReference.Card[] cards);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTypeParseService/ParseCardType", ReplyAction="http://tempuri.org/ICardTypeParseService/ParseCardTypeResponse")]
        System.Threading.Tasks.Task<SSZClient.CardTypeParseServiceReference.CardTypeResult> ParseCardTypeAsync(SSZClient.CardRecognizeServiceReference.Card[] cards);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTypeParseService/ParseCardTypeVsEnemy", ReplyAction="http://tempuri.org/ICardTypeParseService/ParseCardTypeVsEnemyResponse")]
        SSZClient.CardTypeParseServiceReference.CardTypeResult ParseCardTypeVsEnemy(SSZClient.CardRecognizeServiceReference.Card[] cards, SSZClient.CardRecognizeServiceReference.Card[] cardsEnemy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTypeParseService/ParseCardTypeVsEnemy", ReplyAction="http://tempuri.org/ICardTypeParseService/ParseCardTypeVsEnemyResponse")]
        System.Threading.Tasks.Task<SSZClient.CardTypeParseServiceReference.CardTypeResult> ParseCardTypeVsEnemyAsync(SSZClient.CardRecognizeServiceReference.Card[] cards, SSZClient.CardRecognizeServiceReference.Card[] cardsEnemy);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/ICardTypeParseService/Disconnect")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/ICardTypeParseService/Disconnect")]
        System.Threading.Tasks.Task DisconnectAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICardTypeParseServiceChannel : SSZClient.CardTypeParseServiceReference.ICardTypeParseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CardTypeParseServiceClient : System.ServiceModel.ClientBase<SSZClient.CardTypeParseServiceReference.ICardTypeParseService>, SSZClient.CardTypeParseServiceReference.ICardTypeParseService {
        
        public CardTypeParseServiceClient() {
        }
        
        public CardTypeParseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CardTypeParseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardTypeParseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardTypeParseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Connect() {
            base.Channel.Connect();
        }
        
        public System.Threading.Tasks.Task ConnectAsync() {
            return base.Channel.ConnectAsync();
        }
        
        public SSZClient.CardTypeParseServiceReference.CardTypeResult ParseCardType(SSZClient.CardRecognizeServiceReference.Card[] cards) {
            return base.Channel.ParseCardType(cards);
        }

        public System.Threading.Tasks.Task<SSZClient.CardTypeParseServiceReference.CardTypeResult> ParseCardTypeAsync(SSZClient.CardRecognizeServiceReference.Card[] cards)
        {
            return base.Channel.ParseCardTypeAsync(cards);
        }

        public SSZClient.CardTypeParseServiceReference.CardTypeResult ParseCardTypeVsEnemy(SSZClient.CardRecognizeServiceReference.Card[] cards, SSZClient.CardRecognizeServiceReference.Card[] cardsEnemy)
        {
            return base.Channel.ParseCardTypeVsEnemy(cards, cardsEnemy);
        }

        public System.Threading.Tasks.Task<SSZClient.CardTypeParseServiceReference.CardTypeResult> ParseCardTypeVsEnemyAsync(SSZClient.CardRecognizeServiceReference.Card[] cards, SSZClient.CardRecognizeServiceReference.Card[] cardsEnemy)
        {
            return base.Channel.ParseCardTypeVsEnemyAsync(cards, cardsEnemy);
        }
        
        public void Disconnect() {
            base.Channel.Disconnect();
        }
        
        public System.Threading.Tasks.Task DisconnectAsync() {
            return base.Channel.DisconnectAsync();
        }
    }
}
