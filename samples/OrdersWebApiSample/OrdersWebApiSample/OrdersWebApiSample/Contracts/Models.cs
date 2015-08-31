// Template: Models (ApiModel.t4) version 3.0

// This code was generated by RAML Web Api 2 Scaffolder

namespace OrdersWebApiSample.OrdersXml.Models {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO")]
    [System.Xml.Serialization.XmlRootAttribute("purchaseOrder", Namespace="http://www.example.com/IPO", IsNullable=false)]
    public partial class PurchaseOrderType {
        
        private AddressTypeCollection itemsField;
        
        private ItemsChoiceTypeCollection itemsElementNameField;
        
        private string itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private ItemsType itemsField1;
        
        private System.DateTime orderDateField;
        
        private bool orderDateFieldSpecified;
        
        private string idField;
        
        private bool shippedField;
        
        private bool shippedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billTo", typeof(AddressType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("shipTo", typeof(AddressType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("singleAddress", typeof(AddressType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public AddressTypeCollection Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceTypeCollection ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("comment", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("customerComment", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("shipComment", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ItemsType items {
            get {
                return this.itemsField1;
            }
            set {
                this.itemsField1 = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime orderDate {
            get {
                return this.orderDateField;
            }
            set {
                this.orderDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderDateSpecified {
            get {
                return this.orderDateFieldSpecified;
            }
            set {
                this.orderDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool shipped {
            get {
                return this.shippedField;
            }
            set {
                this.shippedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippedSpecified {
            get {
                return this.shippedFieldSpecified;
            }
            set {
                this.shippedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UKAddress))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(USAddress))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO")]
    public partial class AddressType {
        
        private string nameField;
        
        private string streetField;
        
        private string cityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO")]
    public partial class ItemsType {
        
        private ItemsTypeItemCollection itemField;
        
        private StringCollection textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ItemsTypeItemCollection item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public StringCollection Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.example.com/IPO")]
    public partial class ItemsTypeItem {
        
        private string productNameField;
        
        private string quantityField;
        
        private decimal uSPriceField;
        
        private StringCollection itemsField;
        
        private ItemsChoiceType1Collection itemsElementNameField;
        
        private System.DateTime shipDateField;
        
        private bool shipDateFieldSpecified;
        
        private string partNumField;
        
        private decimal weightKgField;
        
        private bool weightKgFieldSpecified;
        
        private ItemsTypeItemShipBy shipByField;
        
        private bool shipByFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string productName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="positiveInteger")]
        public string quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal USPrice {
            get {
                return this.uSPriceField;
            }
            set {
                this.uSPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("comment", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("customerComment", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("shipComment", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public StringCollection Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1Collection ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime shipDate {
            get {
                return this.shipDateField;
            }
            set {
                this.shipDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipDateSpecified {
            get {
                return this.shipDateFieldSpecified;
            }
            set {
                this.shipDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string partNum {
            get {
                return this.partNumField;
            }
            set {
                this.partNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal weightKg {
            get {
                return this.weightKgField;
            }
            set {
                this.weightKgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weightKgSpecified {
            get {
                return this.weightKgFieldSpecified;
            }
            set {
                this.weightKgFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemsTypeItemShipBy shipBy {
            get {
                return this.shipByField;
            }
            set {
                this.shipByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipBySpecified {
            get {
                return this.shipByFieldSpecified;
            }
            set {
                this.shipByFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        /// <remarks/>
        comment,
        
        /// <remarks/>
        customerComment,
        
        /// <remarks/>
        shipComment,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.example.com/IPO")]
    public enum ItemsTypeItemShipBy {
        
        /// <remarks/>
        air,
        
        /// <remarks/>
        land,
        
        /// <remarks/>
        any,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO")]
    public partial class UKAddress : AddressType {
        
        private string postcodeField;
        
        private string exportCodeField;
        
        public UKAddress() {
            this.exportCodeField = "1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string postcode {
            get {
                return this.postcodeField;
            }
            set {
                this.postcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string exportCode {
            get {
                return this.exportCodeField;
            }
            set {
                this.exportCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO")]
    public partial class USAddress : AddressType {
        
        private USState stateField;
        
        private string zipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public USState state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="positiveInteger")]
        public string zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO")]
    public enum USState {
        
        /// <remarks/>
        AK,
        
        /// <remarks/>
        AL,
        
        /// <remarks/>
        AR,
        
        /// <remarks/>
        CA,
        
        /// <remarks/>
        PA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":billTo")]
        billTo,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":shipTo")]
        shipTo,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":singleAddress")]
        singleAddress,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        comment,
        
        /// <remarks/>
        customerComment,
        
        /// <remarks/>
        shipComment,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.com/IPO")]
    [System.Xml.Serialization.XmlRootAttribute("orders", Namespace="http://www.example.com/IPO", IsNullable=false)]
    public partial class PurchaseOrdersType {
        
        private PurchaseOrderTypeCollection ordersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("orders", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PurchaseOrderTypeCollection orders {
            get {
                return this.ordersField;
            }
            set {
                this.ordersField = value;
            }
        }
    }
    
    public class AddressTypeCollection : System.Collections.CollectionBase {
        
        public AddressType this[int idx] {
            get {
                return ((AddressType)(base.InnerList[idx]));
            }
            set {
                base.InnerList[idx] = value;
            }
        }
        
        public int Add(AddressType value) {
            return base.InnerList.Add(value);
        }
    }
    
    public class ItemsChoiceTypeCollection : System.Collections.CollectionBase {
        
        public ItemsChoiceType this[int idx] {
            get {
                return ((ItemsChoiceType)(base.InnerList[idx]));
            }
            set {
                base.InnerList[idx] = value;
            }
        }
        
        public int Add(ItemsChoiceType value) {
            return base.InnerList.Add(value);
        }
    }
    
    public class ItemsTypeItemCollection : System.Collections.CollectionBase {
        
        public ItemsTypeItem this[int idx] {
            get {
                return ((ItemsTypeItem)(base.InnerList[idx]));
            }
            set {
                base.InnerList[idx] = value;
            }
        }
        
        public int Add(ItemsTypeItem value) {
            return base.InnerList.Add(value);
        }
    }
    
    public class StringCollection : System.Collections.CollectionBase {
        
        public string this[int idx] {
            get {
                return ((string)(base.InnerList[idx]));
            }
            set {
                base.InnerList[idx] = value;
            }
        }
        
        public int Add(string value) {
            return base.InnerList.Add(value);
        }
    }
    
    public class ItemsChoiceType1Collection : System.Collections.CollectionBase {
        
        public ItemsChoiceType1 this[int idx] {
            get {
                return ((ItemsChoiceType1)(base.InnerList[idx]));
            }
            set {
                base.InnerList[idx] = value;
            }
        }
        
        public int Add(ItemsChoiceType1 value) {
            return base.InnerList.Add(value);
        }
    }
    
    public class PurchaseOrderTypeCollection : System.Collections.CollectionBase {
        
        public PurchaseOrderType this[int idx] {
            get {
                return ((PurchaseOrderType)(base.InnerList[idx]));
            }
            set {
                base.InnerList[idx] = value;
            }
        }
        
        public int Add(PurchaseOrderType value) {
            return base.InnerList.Add(value);
        }
    }
}

