﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace privacyIDEAADFSProvider
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ADFSserver
    {

        private string urlField;
        private string realmField;
        private string sslField;
        private string adminuserField;
        private string adminpwField;
        private string upnField;
        private string ChallengeMessageField;
        private ADFSinterface[] interfaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string realm
        {
            get
            {
                return this.realmField;
            }
            set
            {
                this.realmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ssl
        {
            get
            {
                return this.sslField;
            }
            set
            {
                this.sslField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string upn
        {
            get
            {
                return this.upnField;
            }
            set
            {
                this.upnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ChallengeMessage
        {
            get
            {
                return this.ChallengeMessageField;
            }
            set
            {
                this.ChallengeMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string adminuser
        {
            get
            {
                return this.adminuserField;
            }
            set
            {
                this.adminuserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string adminpw
        {
            get
            {
                return this.adminpwField;
            }
            set
            {
                this.adminpwField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interface", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ADFSinterface[] @interface
        {
            get
            {
                return this.interfaceField;
            }
            set
            {
                this.interfaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ADFSinterface
    {

        private string errormessageField;
        private string welcomemessageField;
        private string otptextField;
        private string submittextField;
        private string friendlynameField;
        private string descriptionField;
        private int LCIDField;
        private string titleField;


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string errormessage
        {
            get
            {
                return this.errormessageField;
            }
            set
            {
                this.errormessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string welcomemessage
        {
            get
            {
                return this.welcomemessageField;
            }
            set
            {
                this.welcomemessageField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string otptext
        {
            get
            {
                return this.otptextField;
            }
            set
            {
                this.otptextField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string submittext
        {
            get
            {
                return this.submittextField;
            }
            set
            {
                this.submittextField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string friendlyname
        {
            get
            {
                return this.friendlynameField;
            }
            set
            {
                this.friendlynameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int LCID
        {
            get
            {
                return this.LCIDField;
            }
            set
            {
                this.LCIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private ADFSserver[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("server")]
        public ADFSserver[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}
