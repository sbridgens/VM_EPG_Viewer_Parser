using System;
using System.Text;

namespace Epg.Entities.Concrete.XMLEntities
{
    // TVAMain XML entity
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TVAMain
    {

        private TVAMainProgramDescription programDescriptionField;

        private System.DateTime publicationTimeField;

        private string publisherField;

        private byte versionField;

        private string langField;

        /// <remarks/>
        public TVAMainProgramDescription ProgramDescription
        {
            get
            {
                return this.programDescriptionField;
            }
            set
            {
                this.programDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime publicationTime
        {
            get
            {
                return this.publicationTimeField;
            }
            set
            {
                this.publicationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescription
    {

        private TVAMainProgramDescriptionProgramInformation[] programInformationTableField;

        private TVAMainProgramDescriptionGroupInformation[] groupInformationTableField;

        private TVAMainProgramDescriptionSchedule[] programLocationTableField;

        private TVAMainProgramDescriptionServiceInformation[] serviceInformationTableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProgramInformation", IsNullable = false)]
        public TVAMainProgramDescriptionProgramInformation[] ProgramInformationTable
        {
            get
            {
                return this.programInformationTableField;
            }
            set
            {
                this.programInformationTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GroupInformation", IsNullable = false)]
        public TVAMainProgramDescriptionGroupInformation[] GroupInformationTable
        {
            get
            {
                return this.groupInformationTableField;
            }
            set
            {
                this.groupInformationTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Schedule", IsNullable = false)]
        public TVAMainProgramDescriptionSchedule[] ProgramLocationTable
        {
            get
            {
                return this.programLocationTableField;
            }
            set
            {
                this.programLocationTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceInformation", IsNullable = false)]
        public TVAMainProgramDescriptionServiceInformation[] ServiceInformationTable
        {
            get
            {
                return this.serviceInformationTableField;
            }
            set
            {
                this.serviceInformationTableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformation
    {

        private TVAMainProgramDescriptionProgramInformationBasicDescription basicDescriptionField;

        private TVAMainProgramDescriptionProgramInformationOtherIdentifier[] otherIdentifierField;

        private TVAMainProgramDescriptionProgramInformationEpisodeOf episodeOfField;

        private string programIdField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescription BasicDescription
        {
            get
            {
                return this.basicDescriptionField;
            }
            set
            {
                this.basicDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherIdentifier")]
        public TVAMainProgramDescriptionProgramInformationOtherIdentifier[] OtherIdentifier
        {
            get
            {
                return this.otherIdentifierField;
            }
            set
            {
                this.otherIdentifierField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationEpisodeOf EpisodeOf
        {
            get
            {
                return this.episodeOfField;
            }
            set
            {
                this.episodeOfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string programId
        {
            get
            {
                return this.programIdField;
            }
            set
            {
                this.programIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescription
    {

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionTitle[] titleField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionShortTitle shortTitleField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionSynopsis[] synopsisField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionKeyword[] keywordField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionGenre[] genreField;

        private string languageField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItem[] creditsListField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterial[] relatedMaterialField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionProductionDate productionDateField;

        private string productionLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionTitle[] Title
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
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionShortTitle ShortTitle
        {
            get
            {
                return this.shortTitleField;
            }
            set
            {
                this.shortTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Synopsis")]
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionSynopsis[] Synopsis
        {
            get
            {
                return this.synopsisField;
            }
            set
            {
                this.synopsisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionKeyword[] Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Genre")]
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionGenre[] Genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CreditsItem", IsNullable = false)]
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItem[] CreditsList
        {
            get
            {
                return this.creditsListField;
            }
            set
            {
                this.creditsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedMaterial")]
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterial[] RelatedMaterial
        {
            get
            {
                return this.relatedMaterialField;
            }
            set
            {
                this.relatedMaterialField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionProductionDate ProductionDate
        {
            get
            {
                return this.productionDateField;
            }
            set
            {
                this.productionDateField = value;
            }
        }

        /// <remarks/>
        public string ProductionLocation
        {
            get
            {
                return this.productionLocationField;
            }
            set
            {
                this.productionLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionTitle
    {

        private string typeField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionShortTitle
    {

        private byte lengthField;

        private string langField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionSynopsis
    {

        private string lengthField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionKeyword
    {

        private string typeField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionGenre
    {

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionGenreName nameField;

        private string hrefField;

        private string typeField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionGenreName Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionGenreName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItem
    {

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPersonName personNameField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPersonNameIDRef personNameIDRefField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPresentationRole presentationRoleField;

        private string roleField;

        private byte indexField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPersonNameIDRef PersonNameIDRef
        {
            get
            {
                return this.personNameIDRefField;
            }
            set
            {
                this.personNameIDRefField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPresentationRole PresentationRole
        {
            get
            {
                return this.presentationRoleField;
            }
            set
            {
                this.presentationRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPersonName
    {

        private GivenName givenNameField;

        private FamilyName familyNameField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tva:mpeg7:2008")]
        public GivenName GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tva:mpeg7:2008")]
        public FamilyName FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:tva:mpeg7:2008")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:tva:mpeg7:2008", IsNullable = false)]
    public partial class GivenName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:tva:mpeg7:2008")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:tva:mpeg7:2008", IsNullable = false)]
    public partial class FamilyName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPersonNameIDRef
    {

        private uint refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionCreditsItemPresentationRole
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterial
    {

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterialHowRelated howRelatedField;

        private TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterialMediaLocator mediaLocatorField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterialHowRelated HowRelated
        {
            get
            {
                return this.howRelatedField;
            }
            set
            {
                this.howRelatedField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterialMediaLocator MediaLocator
        {
            get
            {
                return this.mediaLocatorField;
            }
            set
            {
                this.mediaLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterialHowRelated
    {

        private string nameField;

        private string hrefField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionRelatedMaterialMediaLocator
    {

        private string mediaUriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tva:mpeg7:2008")]
        public string MediaUri
        {
            get
            {
                return this.mediaUriField;
            }
            set
            {
                this.mediaUriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationBasicDescriptionProductionDate
    {

        private ushort timePointField;

        /// <remarks/>
        public ushort TimePoint
        {
            get
            {
                return this.timePointField;
            }
            set
            {
                this.timePointField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationOtherIdentifier
    {

        private string authorityField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string authority
        {
            get
            {
                return this.authorityField;
            }
            set
            {
                this.authorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationEpisodeOf
    {

        private uint indexField;

        private string cridField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string crid
        {
            get
            {
                return this.cridField;
            }
            set
            {
                this.cridField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformation
    {

        private TVAMainProgramDescriptionGroupInformationGroupType groupTypeField;

        private TVAMainProgramDescriptionGroupInformationBasicDescription basicDescriptionField;

        private TVAMainProgramDescriptionGroupInformationMemberOf memberOfField;

        private TVAMainProgramDescriptionGroupInformationOtherIdentifier[] otherIdentifierField;

        private string groupIdField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationGroupType GroupType
        {
            get
            {
                return this.groupTypeField;
            }
            set
            {
                this.groupTypeField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationBasicDescription BasicDescription
        {
            get
            {
                return this.basicDescriptionField;
            }
            set
            {
                this.basicDescriptionField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationMemberOf MemberOf
        {
            get
            {
                return this.memberOfField;
            }
            set
            {
                this.memberOfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherIdentifier")]
        public TVAMainProgramDescriptionGroupInformationOtherIdentifier[] OtherIdentifier
        {
            get
            {
                return this.otherIdentifierField;
            }
            set
            {
                this.otherIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string groupId
        {
            get
            {
                return this.groupIdField;
            }
            set
            {
                this.groupIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationGroupType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescription
    {

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionTitle titleField;

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionShortTitle shortTitleField;

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionSynopsis[] synopsisField;

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionGenre[] genreField;

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterial[] relatedMaterialField;

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionProductionDate productionDateField;

        private string productionLocationField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionTitle Title
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
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionShortTitle ShortTitle
        {
            get
            {
                return this.shortTitleField;
            }
            set
            {
                this.shortTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Synopsis")]
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionSynopsis[] Synopsis
        {
            get
            {
                return this.synopsisField;
            }
            set
            {
                this.synopsisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Genre")]
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionGenre[] Genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedMaterial")]
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterial[] RelatedMaterial
        {
            get
            {
                return this.relatedMaterialField;
            }
            set
            {
                this.relatedMaterialField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionProductionDate ProductionDate
        {
            get
            {
                return this.productionDateField;
            }
            set
            {
                this.productionDateField = value;
            }
        }

        /// <remarks/>
        public string ProductionLocation
        {
            get
            {
                return this.productionLocationField;
            }
            set
            {
                this.productionLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionTitle
    {

        private string typeField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionShortTitle
    {

        private byte lengthField;

        private string langField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionSynopsis
    {

        private string lengthField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionGenre
    {

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionGenreName nameField;

        private string hrefField;

        private string typeField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionGenreName Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionGenreName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterial
    {

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterialHowRelated howRelatedField;

        private TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterialMediaLocator mediaLocatorField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterialHowRelated HowRelated
        {
            get
            {
                return this.howRelatedField;
            }
            set
            {
                this.howRelatedField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterialMediaLocator MediaLocator
        {
            get
            {
                return this.mediaLocatorField;
            }
            set
            {
                this.mediaLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterialHowRelated
    {

        private string nameField;

        private string hrefField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionRelatedMaterialMediaLocator
    {

        private string mediaUriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tva:mpeg7:2008")]
        public string MediaUri
        {
            get
            {
                return this.mediaUriField;
            }
            set
            {
                this.mediaUriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationBasicDescriptionProductionDate
    {

        private uint timePointField;

        /// <remarks/>
        public uint TimePoint
        {
            get
            {
                return this.timePointField;
            }
            set
            {
                this.timePointField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationMemberOf
    {

        private uint indexField;

        private string cridField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string crid
        {
            get
            {
                return this.cridField;
            }
            set
            {
                this.cridField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationOtherIdentifier
    {

        private string authorityField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string authority
        {
            get
            {
                return this.authorityField;
            }
            set
            {
                this.authorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionSchedule
    {

        private TVAMainProgramDescriptionScheduleScheduleEvent[] scheduleEventField;

        private uint serviceIDRefField;

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleEvent")]
        public TVAMainProgramDescriptionScheduleScheduleEvent[] ScheduleEvent
        {
            get
            {
                return this.scheduleEventField;
            }
            set
            {
                this.scheduleEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint serviceIDRef
        {
            get
            {
                return this.serviceIDRefField;
            }
            set
            {
                this.serviceIDRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEvent
    {

        private TVAMainProgramDescriptionScheduleScheduleEventProgram programField;

        private string instanceMetadataIdField;

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescription instanceDescriptionField;

        private System.DateTime publishedStartTimeField;

        private System.DateTime publishedEndTimeField;

        private string publishedDurationField;

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventProgram Program
        {
            get
            {
                return this.programField;
            }
            set
            {
                this.programField = value;
            }
        }

        /// <remarks/>
        public string InstanceMetadataId
        {
            get
            {
                return this.instanceMetadataIdField;
            }
            set
            {
                this.instanceMetadataIdField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescription InstanceDescription
        {
            get
            {
                return this.instanceDescriptionField;
            }
            set
            {
                this.instanceDescriptionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime PublishedStartTime
        {
            get
            {
                return this.publishedStartTimeField;
            }
            set
            {
                this.publishedStartTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime PublishedEndTime
        {
            get
            {
                return this.publishedEndTimeField;
            }
            set
            {
                this.publishedEndTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string PublishedDuration
        {
            get
            {
                return this.publishedDurationField;
            }
            set
            {
                this.publishedDurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventProgram
    {

        private string cridField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string crid
        {
            get
            {
                return this.cridField;
            }
            set
            {
                this.cridField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescription
    {

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseList purchaseListField;

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributes aVAttributesField;

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionOtherIdentifier otherIdentifierField;

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseList PurchaseList
        {
            get
            {
                return this.purchaseListField;
            }
            set
            {
                this.purchaseListField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributes AVAttributes
        {
            get
            {
                return this.aVAttributesField;
            }
            set
            {
                this.aVAttributesField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionOtherIdentifier OtherIdentifier
        {
            get
            {
                return this.otherIdentifierField;
            }
            set
            {
                this.otherIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseList
    {

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItem purchaseItemField;

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItem PurchaseItem
        {
            get
            {
                return this.purchaseItemField;
            }
            set
            {
                this.purchaseItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItem
    {

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPrice priceField;

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchase purchaseField;

        private string descriptionField;

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPrice Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchase Purchase
        {
            get
            {
                return this.purchaseField;
            }
            set
            {
                this.purchaseField = value;
            }
        }

        /// <remarks/>
        public string Description
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPrice
    {

        private string currencyField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchase
    {

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseType purchaseTypeField;

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseType PurchaseType
        {
            get
            {
                return this.purchaseTypeField;
            }
            set
            {
                this.purchaseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseType
    {

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributes
    {

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributes audioAttributesField;

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributes AudioAttributes
        {
            get
            {
                return this.audioAttributesField;
            }
            set
            {
                this.audioAttributesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributes
    {

        private TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesAudioLanguage audioLanguageField;

        /// <remarks/>
        public TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesAudioLanguage AudioLanguage
        {
            get
            {
                return this.audioLanguageField;
            }
            set
            {
                this.audioLanguageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesAudioLanguage
    {

        private string purposeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionScheduleScheduleEventInstanceDescriptionOtherIdentifier
    {

        private string typeField;

        private string organizationField;

        private string authorityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string authority
        {
            get
            {
                return this.authorityField;
            }
            set
            {
                this.authorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionServiceInformation
    {

        private string nameField;

        private uint serviceIdField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint serviceId
        {
            get
            {
                return this.serviceIdField;
            }
            set
            {
                this.serviceIdField = value;
            }
        }
    }


}
