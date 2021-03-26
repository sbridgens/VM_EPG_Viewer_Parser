using System;
using System.Text;

namespace Epg.Entities.Concrete.XMLEntities
{
    // TVAMain XML entity

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TVAMain
    {

        private TVAMainProgramDescription programDescriptionField;

        private string langField;

        private string publisherField;

        private System.DateTime publicationTimeField;

        private string rightsOwnerField;

        private string originIDField;

        private byte versionField;

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
        public string rightsOwner
        {
            get
            {
                return this.rightsOwnerField;
            }
            set
            {
                this.rightsOwnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string originID
        {
            get
            {
                return this.originIDField;
            }
            set
            {
                this.originIDField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescription
    {

        private TVAMainProgramDescriptionProgramInformationTable programInformationTableField;

        private TVAMainProgramDescriptionGroupInformationTable groupInformationTableField;

        private TVAMainProgramDescriptionProgramLocationTable programLocationTableField;

        private TVAMainProgramDescriptionServiceInformationTable serviceInformationTableField;

        private TVAMainProgramDescriptionCreditsInformationTable creditsInformationTableField;

        private TVAMainProgramDescriptionSegmentInformationTable segmentInformationTableField;

        private TVAMainProgramDescriptionPurchaseInformationTable purchaseInformationTableField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTable ProgramInformationTable
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
        public TVAMainProgramDescriptionGroupInformationTable GroupInformationTable
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
        public TVAMainProgramDescriptionProgramLocationTable ProgramLocationTable
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
        public TVAMainProgramDescriptionServiceInformationTable ServiceInformationTable
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

        /// <remarks/>
        public TVAMainProgramDescriptionCreditsInformationTable CreditsInformationTable
        {
            get
            {
                return this.creditsInformationTableField;
            }
            set
            {
                this.creditsInformationTableField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionSegmentInformationTable SegmentInformationTable
        {
            get
            {
                return this.segmentInformationTableField;
            }
            set
            {
                this.segmentInformationTableField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionPurchaseInformationTable PurchaseInformationTable
        {
            get
            {
                return this.purchaseInformationTableField;
            }
            set
            {
                this.purchaseInformationTableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTable
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformation[] programInformationField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProgramInformation")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformation[] ProgramInformation
        {
            get
            {
                return this.programInformationField;
            }
            set
            {
                this.programInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformation
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescription basicDescriptionField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationOtherIdentifier[] otherIdentifierField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributes aVAttributesField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationMemberOf[] memberOfField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFrom derivedFromField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationEpisodeOf episodeOfField;

        private string partOfAggregatedProgramField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAggregationOf aggregationOfField;

        private string programIdField;

        private string fragmentIdField;

        private ulong fragmentVersionField;

        private System.DateTime fragmentExpirationDateField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescription BasicDescription
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationOtherIdentifier[] OtherIdentifier
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributes AVAttributes
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
        [System.Xml.Serialization.XmlElementAttribute("MemberOf")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationMemberOf[] MemberOf
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFrom DerivedFrom
        {
            get
            {
                return this.derivedFromField;
            }
            set
            {
                this.derivedFromField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationEpisodeOf EpisodeOf
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
        public string PartOfAggregatedProgram
        {
            get
            {
                return this.partOfAggregatedProgramField;
            }
            set
            {
                this.partOfAggregatedProgramField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAggregationOf AggregationOf
        {
            get
            {
                return this.aggregationOfField;
            }
            set
            {
                this.aggregationOfField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fragmentId
        {
            get
            {
                return this.fragmentIdField;
            }
            set
            {
                this.fragmentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong fragmentVersion
        {
            get
            {
                return this.fragmentVersionField;
            }
            set
            {
                this.fragmentVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime fragmentExpirationDate
        {
            get
            {
                return this.fragmentExpirationDateField;
            }
            set
            {
                this.fragmentExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescription
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionTitle[] titleField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionMediaTitle[] mediaTitleField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionShortTitle[] shortTitleField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionSynopsis[] synopsisField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPromotionalInformation[] promotionalInformationField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionKeyword[] keywordField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenre[] genreField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionParentalGuidance[] parentalGuidanceField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionLanguage[] languageField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCaptionLanguage[] captionLanguageField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionSignLanguage[] signLanguageField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItem[] creditsListField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItem[] awardsListField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterial[] relatedMaterialField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionProductionDate productionDateField;

        private string productionLocationField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreationCoordinates[] creationCoordinatesField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinates[] depictedCoordinatesField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionReleaseInformation[] releaseInformationField;

        private string durationField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseList purchaseListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionTitle[] Title
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
        [System.Xml.Serialization.XmlElementAttribute("MediaTitle")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionMediaTitle[] MediaTitle
        {
            get
            {
                return this.mediaTitleField;
            }
            set
            {
                this.mediaTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortTitle")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionShortTitle[] ShortTitle
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionSynopsis[] Synopsis
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
        [System.Xml.Serialization.XmlElementAttribute("PromotionalInformation")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPromotionalInformation[] PromotionalInformation
        {
            get
            {
                return this.promotionalInformationField;
            }
            set
            {
                this.promotionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionKeyword[] Keyword
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenre[] Genre
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
        [System.Xml.Serialization.XmlElementAttribute("ParentalGuidance")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionParentalGuidance[] ParentalGuidance
        {
            get
            {
                return this.parentalGuidanceField;
            }
            set
            {
                this.parentalGuidanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Language")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionLanguage[] Language
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
        [System.Xml.Serialization.XmlElementAttribute("CaptionLanguage")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCaptionLanguage[] CaptionLanguage
        {
            get
            {
                return this.captionLanguageField;
            }
            set
            {
                this.captionLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignLanguage")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionSignLanguage[] SignLanguage
        {
            get
            {
                return this.signLanguageField;
            }
            set
            {
                this.signLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CreditsItem", IsNullable = false)]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItem[] CreditsList
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
        [System.Xml.Serialization.XmlArrayItemAttribute("AwardsListItem", IsNullable = false)]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItem[] AwardsList
        {
            get
            {
                return this.awardsListField;
            }
            set
            {
                this.awardsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedMaterial")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterial[] RelatedMaterial
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionProductionDate ProductionDate
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
        [System.Xml.Serialization.XmlElementAttribute("ProductionLocation")]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CreationCoordinates")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreationCoordinates[] CreationCoordinates
        {
            get
            {
                return this.creationCoordinatesField;
            }
            set
            {
                this.creationCoordinatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DepictedCoordinates")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinates[] DepictedCoordinates
        {
            get
            {
                return this.depictedCoordinatesField;
            }
            set
            {
                this.depictedCoordinatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReleaseInformation")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionReleaseInformation[] ReleaseInformation
        {
            get
            {
                return this.releaseInformationField;
            }
            set
            {
                this.releaseInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseList PurchaseList
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionTitle
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionMediaTitle
    {

        private TitleImage titleImageField;

        private TitleVideo titleVideoField;

        private TitleAudio titleAudioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleImage TitleImage
        {
            get
            {
                return this.titleImageField;
            }
            set
            {
                this.titleImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleVideo TitleVideo
        {
            get
            {
                return this.titleVideoField;
            }
            set
            {
                this.titleVideoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleAudio TitleAudio
        {
            get
            {
                return this.titleAudioField;
            }
            set
            {
                this.titleAudioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TitleImage
    {

        private string mediaUriField;

        private string streamIDField;

        private string mediaTimePointField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }

        /// <remarks/>
        public string MediaTimePoint
        {
            get
            {
                return this.mediaTimePointField;
            }
            set
            {
                this.mediaTimePointField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TitleVideo
    {

        private string mediaUriField;

        private string streamIDField;

        private TitleVideoMediaTime mediaTimeField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }

        /// <remarks/>
        public TitleVideoMediaTime MediaTime
        {
            get
            {
                return this.mediaTimeField;
            }
            set
            {
                this.mediaTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TitleVideoMediaTime
    {

        private string mediaTimePointField;

        private string mediaDurationField;

        /// <remarks/>
        public string MediaTimePoint
        {
            get
            {
                return this.mediaTimePointField;
            }
            set
            {
                this.mediaTimePointField = value;
            }
        }

        /// <remarks/>
        public string MediaDuration
        {
            get
            {
                return this.mediaDurationField;
            }
            set
            {
                this.mediaDurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TitleAudio
    {

        private string mediaUriField;

        private string streamIDField;

        private TitleAudioMediaTime mediaTimeField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }

        /// <remarks/>
        public TitleAudioMediaTime MediaTime
        {
            get
            {
                return this.mediaTimeField;
            }
            set
            {
                this.mediaTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TitleAudioMediaTime
    {

        private string mediaTimePointField;

        private string mediaDurationField;

        /// <remarks/>
        public string MediaTimePoint
        {
            get
            {
                return this.mediaTimePointField;
            }
            set
            {
                this.mediaTimePointField = value;
            }
        }

        /// <remarks/>
        public string MediaDuration
        {
            get
            {
                return this.mediaDurationField;
            }
            set
            {
                this.mediaDurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionShortTitle
    {

        private ushort lengthField;

        private string typeField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort length
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionSynopsis
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPromotionalInformation
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionKeyword
    {

        private string typeField;

        private string metadataOriginIDRefField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenre
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenreName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenreDefinition definitionField;

        private string typeField;

        private string metadataOriginIDRefField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenreName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenreDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenreName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionGenreDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionParentalGuidance
    {

        private ParentalRating parentalRatingField;

        private string[] regionField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionParentalGuidanceExplanatoryText[] explanatoryTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public ParentalRating ParentalRating
        {
            get
            {
                return this.parentalRatingField;
            }
            set
            {
                this.parentalRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Region", Namespace = "")]
        public string[] Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExplanatoryText")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionParentalGuidanceExplanatoryText[] ExplanatoryText
        {
            get
            {
                return this.explanatoryTextField;
            }
            set
            {
                this.explanatoryTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ParentalRating
    {

        private ParentalRatingName[] nameField;

        private ParentalRatingDefinition[] definitionField;

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public ParentalRatingName[] Name
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
        [System.Xml.Serialization.XmlElementAttribute("Definition")]
        public ParentalRatingDefinition[] Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class ParentalRatingName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class ParentalRatingDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionParentalGuidanceExplanatoryText
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionLanguage
    {

        private string typeField;

        private bool supplementalField;

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
        public bool supplemental
        {
            get
            {
                return this.supplementalField;
            }
            set
            {
                this.supplementalField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCaptionLanguage
    {

        private bool primaryField;

        private bool translationField;

        private bool closedField;

        private bool supplementalField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool supplemental
        {
            get
            {
                return this.supplementalField;
            }
            set
            {
                this.supplementalField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionSignLanguage
    {

        private bool primaryField;

        private bool translationField;

        private string typeField;

        private bool closedField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItem
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemPersonName personNameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemPersonNameIDRef personNameIDRefField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemOrganizationName organizationNameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemCharacter[] characterField;

        private string roleField;

        private string indexField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemPersonName PersonName
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemPersonNameIDRef PersonNameIDRef
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemOrganizationName OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Character")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemCharacter[] Character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string index
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemPersonName
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

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
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class GivenName
    {

        private string initialField;

        private string abbrevField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string initial
        {
            get
            {
                return this.initialField;
            }
            set
            {
                this.initialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string abbrev
        {
            get
            {
                return this.abbrevField;
            }
            set
            {
                this.abbrevField = value;
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class LinkingName
    {

        private string initialField;

        private string abbrevField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string initial
        {
            get
            {
                return this.initialField;
            }
            set
            {
                this.initialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string abbrev
        {
            get
            {
                return this.abbrevField;
            }
            set
            {
                this.abbrevField = value;
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FamilyName
    {

        private string initialField;

        private string abbrevField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string initial
        {
            get
            {
                return this.initialField;
            }
            set
            {
                this.initialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string abbrev
        {
            get
            {
                return this.abbrevField;
            }
            set
            {
                this.abbrevField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemPersonNameIDRef
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemOrganizationName
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreditsItemCharacter
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItem
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemTitle titleField;

        private ushort yearField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAward[] awardField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemTitle Title
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
        public ushort Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Award")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAward[] Award
        {
            get
            {
                return this.awardField;
            }
            set
            {
                this.awardField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemTitle
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAward
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardCategory categoryField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNominee nomineeField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardCategory Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNominee Nominee
        {
            get
            {
                return this.nomineeField;
            }
            set
            {
                this.nomineeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardCategory
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNominee
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineePersonName personNameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineePersonNameIDRef personNameIDRefField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineeOrganizationName organizationNameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineeCharacter[] characterField;

        private string roleField;

        private string indexField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineePersonName PersonName
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineePersonNameIDRef PersonNameIDRef
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineeOrganizationName OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Character")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineeCharacter[] Character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string index
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineePersonName
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineePersonNameIDRef
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineeOrganizationName
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionAwardsListItemAwardNomineeCharacter
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterial
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelated howRelatedField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormat formatField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialMediaLocator mediaLocatorField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialPromotionalText[] promotionalTextField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialPromotionalMedia[] promotionalMediaField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialSourceMediaLocator sourceMediaLocatorField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelated HowRelated
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialMediaLocator MediaLocator
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalText")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialPromotionalText[] PromotionalText
        {
            get
            {
                return this.promotionalTextField;
            }
            set
            {
                this.promotionalTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalMedia")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialPromotionalMedia[] PromotionalMedia
        {
            get
            {
                return this.promotionalMediaField;
            }
            set
            {
                this.promotionalMediaField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialSourceMediaLocator SourceMediaLocator
        {
            get
            {
                return this.sourceMediaLocatorField;
            }
            set
            {
                this.sourceMediaLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelated
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelatedName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelatedDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelatedName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelatedDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelatedName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialHowRelatedDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormat
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormatName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormatDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormatName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormatDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormatName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialFormatDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialMediaLocator
    {

        private string mediaUriField;

        private string streamIDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "", DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialPromotionalText
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialPromotionalMedia
    {

        private TitleImage titleImageField;

        private TitleVideo titleVideoField;

        private TitleAudio titleAudioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleImage TitleImage
        {
            get
            {
                return this.titleImageField;
            }
            set
            {
                this.titleImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleVideo TitleVideo
        {
            get
            {
                return this.titleVideoField;
            }
            set
            {
                this.titleVideoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleAudio TitleAudio
        {
            get
            {
                return this.titleAudioField;
            }
            set
            {
                this.titleAudioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionRelatedMaterialSourceMediaLocator
    {

        private string mediaUriField;

        private string streamIDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "", DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionProductionDate
    {

        private string timePointField;

        private string durationField;

        /// <remarks/>
        public string TimePoint
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

        /// <remarks/>
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreationCoordinates
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreationCoordinatesCreationDate creationDateField;

        private string creationLocationField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreationCoordinatesCreationDate CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        public string CreationLocation
        {
            get
            {
                return this.creationLocationField;
            }
            set
            {
                this.creationLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionCreationCoordinatesCreationDate
    {

        private string timePointField;

        private string durationField;

        /// <remarks/>
        public string TimePoint
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

        /// <remarks/>
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinates
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinatesDepictedDate depictedDateField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinatesDepictedLocation depictedLocationField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinatesDepictedDate DepictedDate
        {
            get
            {
                return this.depictedDateField;
            }
            set
            {
                this.depictedDateField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinatesDepictedLocation DepictedLocation
        {
            get
            {
                return this.depictedLocationField;
            }
            set
            {
                this.depictedLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinatesDepictedDate
    {

        private string timePointField;

        private string durationField;

        /// <remarks/>
        public string TimePoint
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

        /// <remarks/>
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionDepictedCoordinatesDepictedLocation
    {

        private Name[] nameField;

        private NameTerm[] nameTermField;

        private Role roleField;

        private GeographicPosition geographicPositionField;

        private string[] regionField;

        private AdministrativeUnit[] administrativeUnitField;

        private PostalAddress postalAddressField;

        private string internalCoordinatesField;

        private bool fictionalField;

        private string langField;

        private string idField;

        private string timeBaseField;

        private string timeUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "")]
        public Name[] Name
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
        [System.Xml.Serialization.XmlElementAttribute("NameTerm", Namespace = "")]
        public NameTerm[] NameTerm
        {
            get
            {
                return this.nameTermField;
            }
            set
            {
                this.nameTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public Role Role
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public GeographicPosition GeographicPosition
        {
            get
            {
                return this.geographicPositionField;
            }
            set
            {
                this.geographicPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Region", Namespace = "")]
        public string[] Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdministrativeUnit", Namespace = "")]
        public AdministrativeUnit[] AdministrativeUnit
        {
            get
            {
                return this.administrativeUnitField;
            }
            set
            {
                this.administrativeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public PostalAddress PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string InternalCoordinates
        {
            get
            {
                return this.internalCoordinatesField;
            }
            set
            {
                this.internalCoordinatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool fictional
        {
            get
            {
                return this.fictionalField;
            }
            set
            {
                this.fictionalField = value;
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
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeBase
        {
            get
            {
                return this.timeBaseField;
            }
            set
            {
                this.timeBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Name
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NameTerm
    {

        private NameTermName[] nameField;

        private NameTermDefinition[] definitionField;

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public NameTermName[] Name
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
        [System.Xml.Serialization.XmlElementAttribute("Definition")]
        public NameTermDefinition[] Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class NameTermName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class NameTermDefinition
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Role
    {

        private RoleName[] nameField;

        private RoleDefinition[] definitionField;

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public RoleName[] Name
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
        [System.Xml.Serialization.XmlElementAttribute("Definition")]
        public RoleDefinition[] Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class RoleName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class RoleDefinition
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class GeographicPosition
    {

        private GeographicPositionPoint pointField;

        private string datumField;

        /// <remarks/>
        public GeographicPositionPoint Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class GeographicPositionPoint
    {

        private decimal longitudeField;

        private decimal latitudeField;

        private double altitudeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AdministrativeUnit
    {

        private string typeField;

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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PostalAddress
    {

        private PostalAddressAddressLine[] addressLineField;

        private PostalAddressPostingIdentifier postingIdentifierField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressLine")]
        public PostalAddressAddressLine[] AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        public PostalAddressPostingIdentifier PostingIdentifier
        {
            get
            {
                return this.postingIdentifierField;
            }
            set
            {
                this.postingIdentifierField = value;
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
    public partial class PostalAddressAddressLine
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
    public partial class PostalAddressPostingIdentifier
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionReleaseInformation
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionReleaseInformationReleaseDate releaseDateField;

        private string releaseLocationField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionReleaseInformationReleaseDate ReleaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        public string ReleaseLocation
        {
            get
            {
                return this.releaseLocationField;
            }
            set
            {
                this.releaseLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionReleaseInformationReleaseDate
    {

        private System.DateTime dayAndYearField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DayAndYear
        {
            get
            {
                return this.dayAndYearField;
            }
            set
            {
                this.dayAndYearField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseList
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PurchaseIdRef", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PurchaseItem", typeof(TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItem))]
        public object[] Items
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItem
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPrice[] priceField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchase[] purchaseField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemDescription[] descriptionField;

        private string[] pricingServerURLField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemDRMDeclaration dRMDeclarationField;

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Price")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPrice[] Price
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
        [System.Xml.Serialization.XmlElementAttribute("Purchase")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchase[] Purchase
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
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemDescription[] Description
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
        [System.Xml.Serialization.XmlElementAttribute("PricingServerURL")]
        public string[] PricingServerURL
        {
            get
            {
                return this.pricingServerURLField;
            }
            set
            {
                this.pricingServerURLField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemDRMDeclaration DRMDeclaration
        {
            get
            {
                return this.dRMDeclarationField;
            }
            set
            {
                this.dRMDeclarationField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPrice
    {

        private string currencyField;

        private float valueField;

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
        public float Value
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchase
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseType purchaseTypeField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit quantityUnitField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityRange quantityRangeField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseType PurchaseType
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

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit QuantityUnit
        {
            get
            {
                return this.quantityUnitField;
            }
            set
            {
                this.quantityUnitField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityRange QuantityRange
        {
            get
            {
                return this.quantityRangeField;
            }
            set
            {
                this.quantityRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseType
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityRange
    {

        private uint minField;

        private uint maxField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemDescription
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationBasicDescriptionPurchaseListPurchaseItemDRMDeclaration
    {

        private string dRMField;

        private string licenseLocatorField;

        /// <remarks/>
        public string DRM
        {
            get
            {
                return this.dRMField;
            }
            set
            {
                this.dRMField = value;
            }
        }

        /// <remarks/>
        public string LicenseLocator
        {
            get
            {
                return this.licenseLocatorField;
            }
            set
            {
                this.licenseLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationOtherIdentifier
    {

        private string typeField;

        private string organizationField;

        private string authorityField;

        private string encodingField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributes
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormat fileFormatField;

        private ulong fileSizeField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystem systemField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesBitRate[] bitRateField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributes[] audioAttributesField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributes videoAttributesField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributes[] captioningAttributesField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormat FileFormat
        {
            get
            {
                return this.fileFormatField;
            }
            set
            {
                this.fileFormatField = value;
            }
        }

        /// <remarks/>
        public ulong FileSize
        {
            get
            {
                return this.fileSizeField;
            }
            set
            {
                this.fileSizeField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystem System
        {
            get
            {
                return this.systemField;
            }
            set
            {
                this.systemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BitRate")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesBitRate[] BitRate
        {
            get
            {
                return this.bitRateField;
            }
            set
            {
                this.bitRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AudioAttributes")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributes[] AudioAttributes
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

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributes VideoAttributes
        {
            get
            {
                return this.videoAttributesField;
            }
            set
            {
                this.videoAttributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaptioningAttributes")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributes[] CaptioningAttributes
        {
            get
            {
                return this.captioningAttributesField;
            }
            set
            {
                this.captioningAttributesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormat
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormatName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormatDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormatName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormatDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormatName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesFileFormatDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystem
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystemName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystemDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystemName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystemDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystemName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesSystemDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesBitRate
    {

        private bool variableField;

        private ulong minimumField;

        private ulong averageField;

        private ulong maximumField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong minimum
        {
            get
            {
                return this.minimumField;
            }
            set
            {
                this.minimumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong maximum
        {
            get
            {
                return this.maximumField;
            }
            set
            {
                this.maximumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributes
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCoding codingField;

        private ushort numOfChannelsField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixType mixTypeField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesAudioLanguage audioLanguageField;

        private uint sampleFrequencyField;

        private uint bitsPerSampleField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCoding Coding
        {
            get
            {
                return this.codingField;
            }
            set
            {
                this.codingField = value;
            }
        }

        /// <remarks/>
        public ushort NumOfChannels
        {
            get
            {
                return this.numOfChannelsField;
            }
            set
            {
                this.numOfChannelsField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixType MixType
        {
            get
            {
                return this.mixTypeField;
            }
            set
            {
                this.mixTypeField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesAudioLanguage AudioLanguage
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

        /// <remarks/>
        public uint SampleFrequency
        {
            get
            {
                return this.sampleFrequencyField;
            }
            set
            {
                this.sampleFrequencyField = value;
            }
        }

        /// <remarks/>
        public uint BitsPerSample
        {
            get
            {
                return this.bitsPerSampleField;
            }
            set
            {
                this.bitsPerSampleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCoding
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCodingName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCodingDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCodingName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCodingDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCodingName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesCodingDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixType
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixTypeName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixTypeDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixTypeName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixTypeDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixTypeName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesMixTypeDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesAudioAttributesAudioLanguage
    {

        private string purposeField;

        private string typeField;

        private bool supplementalField;

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
        public bool supplemental
        {
            get
            {
                return this.supplementalField;
            }
            set
            {
                this.supplementalField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributes
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCoding codingField;

        private string scanField;

        private ushort horizontalSizeField;

        private ushort verticalSizeField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesAspectRatio[] aspectRatioField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesColor colorField;

        private string frameRateField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCoding Coding
        {
            get
            {
                return this.codingField;
            }
            set
            {
                this.codingField = value;
            }
        }

        /// <remarks/>
        public string Scan
        {
            get
            {
                return this.scanField;
            }
            set
            {
                this.scanField = value;
            }
        }

        /// <remarks/>
        public ushort HorizontalSize
        {
            get
            {
                return this.horizontalSizeField;
            }
            set
            {
                this.horizontalSizeField = value;
            }
        }

        /// <remarks/>
        public ushort VerticalSize
        {
            get
            {
                return this.verticalSizeField;
            }
            set
            {
                this.verticalSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AspectRatio")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesAspectRatio[] AspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesColor Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public string FrameRate
        {
            get
            {
                return this.frameRateField;
            }
            set
            {
                this.frameRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCoding
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCodingName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCodingDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCodingName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCodingDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCodingName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesCodingDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesAspectRatio
    {

        private string typeField;

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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesVideoAttributesColor
    {

        private string typeField;

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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributes
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCoding codingField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCoding Coding
        {
            get
            {
                return this.codingField;
            }
            set
            {
                this.codingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCoding
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCodingName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCodingDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCodingName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCodingDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCodingName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAVAttributesCaptioningAttributesCodingDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationMemberOf
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFrom
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReason[] derivationReasonField;

        private uint indexField;

        private string cridField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DerivationReason")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReason[] DerivationReason
        {
            get
            {
                return this.derivationReasonField;
            }
            set
            {
                this.derivationReasonField = value;
            }
        }

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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReason
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifier[] classifierField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonDescription[] descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Classifier")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifier[] Classifier
        {
            get
            {
                return this.classifierField;
            }
            set
            {
                this.classifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonDescription[] Description
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifier
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifierName nameField;

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifierDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifierName Name
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
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifierDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifierName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonClassifierDefinition
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationDerivedFromDerivationReasonDescription
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EpisodeOfType", Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationEpisodeOf
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAggregationOf
    {

        private TVAMainProgramDescriptionProgramInformationTableProgramInformationAggregationOfAggregatedProgram[] aggregatedProgramField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AggregatedProgram")]
        public TVAMainProgramDescriptionProgramInformationTableProgramInformationAggregationOfAggregatedProgram[] AggregatedProgram
        {
            get
            {
                return this.aggregatedProgramField;
            }
            set
            {
                this.aggregatedProgramField = value;
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
    public partial class TVAMainProgramDescriptionProgramInformationTableProgramInformationAggregationOfAggregatedProgram
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
    public partial class TVAMainProgramDescriptionGroupInformationTable
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformation[] groupInformationField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GroupInformation")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformation[] GroupInformation
        {
            get
            {
                return this.groupInformationField;
            }
            set
            {
                this.groupInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformation
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationGroupType groupTypeField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescription basicDescriptionField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationMemberOf[] memberOfField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationOtherIdentifier[] otherIdentifierField;

        private string partOfAggregatedGroupField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationAggregationOf aggregationOfField;

        private string groupIdField;

        private bool orderedField;

        private uint numOfItemsField;

        private string fragmentIdField;

        private ulong fragmentVersionField;

        private System.DateTime fragmentExpirationDateField;

        private string metadataOriginIDRefField;

        private string langField;

        private string serviceIDRefField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationGroupType GroupType
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescription BasicDescription
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
        [System.Xml.Serialization.XmlElementAttribute("MemberOf")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationMemberOf[] MemberOf
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationOtherIdentifier[] OtherIdentifier
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
        public string PartOfAggregatedGroup
        {
            get
            {
                return this.partOfAggregatedGroupField;
            }
            set
            {
                this.partOfAggregatedGroupField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationAggregationOf AggregationOf
        {
            get
            {
                return this.aggregationOfField;
            }
            set
            {
                this.aggregationOfField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ordered
        {
            get
            {
                return this.orderedField;
            }
            set
            {
                this.orderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint numOfItems
        {
            get
            {
                return this.numOfItemsField;
            }
            set
            {
                this.numOfItemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fragmentId
        {
            get
            {
                return this.fragmentIdField;
            }
            set
            {
                this.fragmentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong fragmentVersion
        {
            get
            {
                return this.fragmentVersionField;
            }
            set
            {
                this.fragmentVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime fragmentExpirationDate
        {
            get
            {
                return this.fragmentExpirationDateField;
            }
            set
            {
                this.fragmentExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
        public string serviceIDRef
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProgramGroupTypeType", Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationGroupType
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescription
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionTitle[] titleField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionMediaTitle[] mediaTitleField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionShortTitle[] shortTitleField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionSynopsis[] synopsisField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPromotionalInformation[] promotionalInformationField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionKeyword[] keywordField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenre[] genreField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionParentalGuidance[] parentalGuidanceField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionLanguage[] languageField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCaptionLanguage[] captionLanguageField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionSignLanguage[] signLanguageField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItem[] creditsListField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItem[] awardsListField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterial[] relatedMaterialField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionProductionDate productionDateField;

        private string productionLocationField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreationCoordinates[] creationCoordinatesField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinates[] depictedCoordinatesField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionReleaseInformation[] releaseInformationField;

        private string durationField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseList purchaseListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionTitle[] Title
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
        [System.Xml.Serialization.XmlElementAttribute("MediaTitle")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionMediaTitle[] MediaTitle
        {
            get
            {
                return this.mediaTitleField;
            }
            set
            {
                this.mediaTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortTitle")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionShortTitle[] ShortTitle
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionSynopsis[] Synopsis
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
        [System.Xml.Serialization.XmlElementAttribute("PromotionalInformation")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPromotionalInformation[] PromotionalInformation
        {
            get
            {
                return this.promotionalInformationField;
            }
            set
            {
                this.promotionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionKeyword[] Keyword
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenre[] Genre
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
        [System.Xml.Serialization.XmlElementAttribute("ParentalGuidance")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionParentalGuidance[] ParentalGuidance
        {
            get
            {
                return this.parentalGuidanceField;
            }
            set
            {
                this.parentalGuidanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Language")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionLanguage[] Language
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
        [System.Xml.Serialization.XmlElementAttribute("CaptionLanguage")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCaptionLanguage[] CaptionLanguage
        {
            get
            {
                return this.captionLanguageField;
            }
            set
            {
                this.captionLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignLanguage")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionSignLanguage[] SignLanguage
        {
            get
            {
                return this.signLanguageField;
            }
            set
            {
                this.signLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CreditsItem", IsNullable = false)]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItem[] CreditsList
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
        [System.Xml.Serialization.XmlArrayItemAttribute("AwardsListItem", IsNullable = false)]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItem[] AwardsList
        {
            get
            {
                return this.awardsListField;
            }
            set
            {
                this.awardsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedMaterial")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterial[] RelatedMaterial
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionProductionDate ProductionDate
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
        [System.Xml.Serialization.XmlElementAttribute("ProductionLocation")]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CreationCoordinates")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreationCoordinates[] CreationCoordinates
        {
            get
            {
                return this.creationCoordinatesField;
            }
            set
            {
                this.creationCoordinatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DepictedCoordinates")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinates[] DepictedCoordinates
        {
            get
            {
                return this.depictedCoordinatesField;
            }
            set
            {
                this.depictedCoordinatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReleaseInformation")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionReleaseInformation[] ReleaseInformation
        {
            get
            {
                return this.releaseInformationField;
            }
            set
            {
                this.releaseInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseList PurchaseList
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionTitle
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionMediaTitle
    {

        private TitleImage titleImageField;

        private TitleVideo titleVideoField;

        private TitleAudio titleAudioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleImage TitleImage
        {
            get
            {
                return this.titleImageField;
            }
            set
            {
                this.titleImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleVideo TitleVideo
        {
            get
            {
                return this.titleVideoField;
            }
            set
            {
                this.titleVideoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleAudio TitleAudio
        {
            get
            {
                return this.titleAudioField;
            }
            set
            {
                this.titleAudioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionShortTitle
    {

        private ushort lengthField;

        private string typeField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort length
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionSynopsis
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPromotionalInformation
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionKeyword
    {

        private string typeField;

        private string metadataOriginIDRefField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenre
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenreName nameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenreDefinition definitionField;

        private string typeField;

        private string metadataOriginIDRefField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenreName Name
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenreDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenreName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionGenreDefinition
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionParentalGuidance
    {

        private ParentalRating parentalRatingField;

        private string[] regionField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionParentalGuidanceExplanatoryText[] explanatoryTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tva:mpeg7:2008")]
        public ParentalRating ParentalRating
        {
            get
            {
                return this.parentalRatingField;
            }
            set
            {
                this.parentalRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Region", Namespace = "")]
        public string[] Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExplanatoryText")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionParentalGuidanceExplanatoryText[] ExplanatoryText
        {
            get
            {
                return this.explanatoryTextField;
            }
            set
            {
                this.explanatoryTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionParentalGuidanceExplanatoryText
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionLanguage
    {

        private string typeField;

        private bool supplementalField;

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
        public bool supplemental
        {
            get
            {
                return this.supplementalField;
            }
            set
            {
                this.supplementalField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCaptionLanguage
    {

        private bool primaryField;

        private bool translationField;

        private bool closedField;

        private bool supplementalField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool supplemental
        {
            get
            {
                return this.supplementalField;
            }
            set
            {
                this.supplementalField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionSignLanguage
    {

        private bool primaryField;

        private bool translationField;

        private string typeField;

        private bool closedField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItem
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemPersonName personNameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemPersonNameIDRef personNameIDRefField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemOrganizationName organizationNameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemCharacter[] characterField;

        private string roleField;

        private string indexField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemPersonName PersonName
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemPersonNameIDRef PersonNameIDRef
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemOrganizationName OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Character")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemCharacter[] Character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string index
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemPersonName
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemPersonNameIDRef
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemOrganizationName
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreditsItemCharacter
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItem
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemTitle titleField;

        private ushort yearField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAward[] awardField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemTitle Title
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
        public ushort Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Award")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAward[] Award
        {
            get
            {
                return this.awardField;
            }
            set
            {
                this.awardField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemTitle
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAward
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardCategory categoryField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNominee nomineeField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardCategory Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNominee Nominee
        {
            get
            {
                return this.nomineeField;
            }
            set
            {
                this.nomineeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardCategory
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNominee
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineePersonName personNameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineePersonNameIDRef personNameIDRefField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineeOrganizationName organizationNameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineeCharacter[] characterField;

        private string roleField;

        private string indexField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineePersonName PersonName
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineePersonNameIDRef PersonNameIDRef
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineeOrganizationName OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Character")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineeCharacter[] Character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string index
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineePersonName
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineePersonNameIDRef
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineeOrganizationName
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionAwardsListItemAwardNomineeCharacter
    {

        private GivenName givenNameField;

        private LinkingName linkingNameField;

        private FamilyName familyNameField;

        private string dateFromField;

        private string dateToField;

        private string typeField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public LinkingName LinkingName
        {
            get
            {
                return this.linkingNameField;
            }
            set
            {
                this.linkingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterial
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelated howRelatedField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormat formatField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialMediaLocator mediaLocatorField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialPromotionalText[] promotionalTextField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialPromotionalMedia[] promotionalMediaField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialSourceMediaLocator sourceMediaLocatorField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelated HowRelated
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialMediaLocator MediaLocator
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalText")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialPromotionalText[] PromotionalText
        {
            get
            {
                return this.promotionalTextField;
            }
            set
            {
                this.promotionalTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalMedia")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialPromotionalMedia[] PromotionalMedia
        {
            get
            {
                return this.promotionalMediaField;
            }
            set
            {
                this.promotionalMediaField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialSourceMediaLocator SourceMediaLocator
        {
            get
            {
                return this.sourceMediaLocatorField;
            }
            set
            {
                this.sourceMediaLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelated
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelatedName nameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelatedDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelatedName Name
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelatedDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelatedName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialHowRelatedDefinition
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormat
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormatName nameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormatDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormatName Name
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormatDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormatName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialFormatDefinition
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialMediaLocator
    {

        private string mediaUriField;

        private string streamIDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "", DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialPromotionalText
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialPromotionalMedia
    {

        private TitleImage titleImageField;

        private TitleVideo titleVideoField;

        private TitleAudio titleAudioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleImage TitleImage
        {
            get
            {
                return this.titleImageField;
            }
            set
            {
                this.titleImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleVideo TitleVideo
        {
            get
            {
                return this.titleVideoField;
            }
            set
            {
                this.titleVideoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleAudio TitleAudio
        {
            get
            {
                return this.titleAudioField;
            }
            set
            {
                this.titleAudioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionRelatedMaterialSourceMediaLocator
    {

        private string mediaUriField;

        private string streamIDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "", DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionProductionDate
    {

        private string timePointField;

        private string durationField;

        /// <remarks/>
        public string TimePoint
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

        /// <remarks/>
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreationCoordinates
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreationCoordinatesCreationDate creationDateField;

        private string creationLocationField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreationCoordinatesCreationDate CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        public string CreationLocation
        {
            get
            {
                return this.creationLocationField;
            }
            set
            {
                this.creationLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionCreationCoordinatesCreationDate
    {

        private string timePointField;

        private string durationField;

        /// <remarks/>
        public string TimePoint
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

        /// <remarks/>
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinates
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinatesDepictedDate depictedDateField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinatesDepictedLocation depictedLocationField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinatesDepictedDate DepictedDate
        {
            get
            {
                return this.depictedDateField;
            }
            set
            {
                this.depictedDateField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinatesDepictedLocation DepictedLocation
        {
            get
            {
                return this.depictedLocationField;
            }
            set
            {
                this.depictedLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinatesDepictedDate
    {

        private string timePointField;

        private string durationField;

        /// <remarks/>
        public string TimePoint
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

        /// <remarks/>
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionDepictedCoordinatesDepictedLocation
    {

        private Name[] nameField;

        private NameTerm[] nameTermField;

        private Role roleField;

        private GeographicPosition geographicPositionField;

        private string[] regionField;

        private AdministrativeUnit[] administrativeUnitField;

        private PostalAddress postalAddressField;

        private string internalCoordinatesField;

        private bool fictionalField;

        private string langField;

        private string idField;

        private string timeBaseField;

        private string timeUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "")]
        public Name[] Name
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
        [System.Xml.Serialization.XmlElementAttribute("NameTerm", Namespace = "")]
        public NameTerm[] NameTerm
        {
            get
            {
                return this.nameTermField;
            }
            set
            {
                this.nameTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public Role Role
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public GeographicPosition GeographicPosition
        {
            get
            {
                return this.geographicPositionField;
            }
            set
            {
                this.geographicPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Region", Namespace = "")]
        public string[] Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdministrativeUnit", Namespace = "")]
        public AdministrativeUnit[] AdministrativeUnit
        {
            get
            {
                return this.administrativeUnitField;
            }
            set
            {
                this.administrativeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public PostalAddress PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string InternalCoordinates
        {
            get
            {
                return this.internalCoordinatesField;
            }
            set
            {
                this.internalCoordinatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool fictional
        {
            get
            {
                return this.fictionalField;
            }
            set
            {
                this.fictionalField = value;
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
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeBase
        {
            get
            {
                return this.timeBaseField;
            }
            set
            {
                this.timeBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionReleaseInformation
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionReleaseInformationReleaseDate releaseDateField;

        private string releaseLocationField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionReleaseInformationReleaseDate ReleaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        public string ReleaseLocation
        {
            get
            {
                return this.releaseLocationField;
            }
            set
            {
                this.releaseLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionReleaseInformationReleaseDate
    {

        private System.DateTime dayAndYearField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DayAndYear
        {
            get
            {
                return this.dayAndYearField;
            }
            set
            {
                this.dayAndYearField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseList
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PurchaseIdRef", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PurchaseItem", typeof(TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItem))]
        public object[] Items
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItem
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPrice[] priceField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchase[] purchaseField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemDescription[] descriptionField;

        private string[] pricingServerURLField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemDRMDeclaration dRMDeclarationField;

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Price")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPrice[] Price
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
        [System.Xml.Serialization.XmlElementAttribute("Purchase")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchase[] Purchase
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
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemDescription[] Description
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
        [System.Xml.Serialization.XmlElementAttribute("PricingServerURL")]
        public string[] PricingServerURL
        {
            get
            {
                return this.pricingServerURLField;
            }
            set
            {
                this.pricingServerURLField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemDRMDeclaration DRMDeclaration
        {
            get
            {
                return this.dRMDeclarationField;
            }
            set
            {
                this.dRMDeclarationField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPrice
    {

        private string currencyField;

        private float valueField;

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
        public float Value
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchase
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseType purchaseTypeField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit quantityUnitField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityRange quantityRangeField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseType PurchaseType
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

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit QuantityUnit
        {
            get
            {
                return this.quantityUnitField;
            }
            set
            {
                this.quantityUnitField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityRange QuantityRange
        {
            get
            {
                return this.quantityRangeField;
            }
            set
            {
                this.quantityRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseType
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName nameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName Name
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName nameField;

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName Name
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
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemPurchaseQuantityRange
    {

        private uint minField;

        private uint maxField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemDescription
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationBasicDescriptionPurchaseListPurchaseItemDRMDeclaration
    {

        private string dRMField;

        private string licenseLocatorField;

        /// <remarks/>
        public string DRM
        {
            get
            {
                return this.dRMField;
            }
            set
            {
                this.dRMField = value;
            }
        }

        /// <remarks/>
        public string LicenseLocator
        {
            get
            {
                return this.licenseLocatorField;
            }
            set
            {
                this.licenseLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MemberOfType", Namespace = "")]
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationMemberOf
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationOtherIdentifier
    {

        private string typeField;

        private string organizationField;

        private string authorityField;

        private string encodingField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationAggregationOf
    {

        private TVAMainProgramDescriptionGroupInformationTableGroupInformationAggregationOfAggregatedProgram[] aggregatedProgramField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AggregatedProgram")]
        public TVAMainProgramDescriptionGroupInformationTableGroupInformationAggregationOfAggregatedProgram[] AggregatedProgram
        {
            get
            {
                return this.aggregatedProgramField;
            }
            set
            {
                this.aggregatedProgramField = value;
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
    public partial class TVAMainProgramDescriptionGroupInformationTableGroupInformationAggregationOfAggregatedProgram
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
    public partial class TVAMainProgramDescriptionProgramLocationTable
    {

        private TVAMainProgramDescriptionProgramLocationTableSchedule[] scheduleField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Schedule")]
        public TVAMainProgramDescriptionProgramLocationTableSchedule[] Schedule
        {
            get
            {
                return this.scheduleField;
            }
            set
            {
                this.scheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableSchedule
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEvent[] scheduleEventField;

        private string serviceIDRefField;

        private System.DateTime startField;

        private System.DateTime endField;

        private string fragmentIdField;

        private byte fragmentVersionField;

        private System.DateTime fragmentExpirationDateField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleEvent")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEvent[] ScheduleEvent
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
        public string serviceIDRef
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fragmentId
        {
            get
            {
                return this.fragmentIdField;
            }
            set
            {
                this.fragmentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fragmentVersion
        {
            get
            {
                return this.fragmentVersionField;
            }
            set
            {
                this.fragmentVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime fragmentExpirationDate
        {
            get
            {
                return this.fragmentExpirationDateField;
            }
            set
            {
                this.fragmentExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEvent
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventProgram programField;

        private string programURLField;

        private string instanceMetadataIdField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescription instanceDescriptionField;

        private System.DateTime publishedStartTimeField;

        private bool publishedStartTimeFieldSpecified;

        private System.DateTime publishedEndTimeField;

        private bool publishedEndTimeFieldSpecified;

        private string publishedDurationField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventLive liveField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventRepeat repeatField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventFirstShowing firstShowingField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventLastShowing lastShowingField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventFree freeField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventProgram Program
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
        public string ProgramURL
        {
            get
            {
                return this.programURLField;
            }
            set
            {
                this.programURLField = value;
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescription InstanceDescription
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PublishedStartTimeSpecified
        {
            get
            {
                return this.publishedStartTimeFieldSpecified;
            }
            set
            {
                this.publishedStartTimeFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PublishedEndTimeSpecified
        {
            get
            {
                return this.publishedEndTimeFieldSpecified;
            }
            set
            {
                this.publishedEndTimeFieldSpecified = value;
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

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventLive Live
        {
            get
            {
                return this.liveField;
            }
            set
            {
                this.liveField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventRepeat Repeat
        {
            get
            {
                return this.repeatField;
            }
            set
            {
                this.repeatField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventFirstShowing FirstShowing
        {
            get
            {
                return this.firstShowingField;
            }
            set
            {
                this.firstShowingField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventLastShowing LastShowing
        {
            get
            {
                return this.lastShowingField;
            }
            set
            {
                this.lastShowingField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventFree Free
        {
            get
            {
                return this.freeField;
            }
            set
            {
                this.freeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventProgram
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescription
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionTitle[] titleField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionSynopsis[] synopsisField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenre[] genreField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseList purchaseListField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionCaptionLanguage[] captionLanguageField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionSignLanguage[] signLanguageField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributes aVAttributesField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionMemberOf[] memberOfField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionOtherIdentifier[] otherIdentifierField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterial[] relatedMaterialField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionTitle[] Title
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
        [System.Xml.Serialization.XmlElementAttribute("Synopsis")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionSynopsis[] Synopsis
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenre[] Genre
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseList PurchaseList
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
        [System.Xml.Serialization.XmlElementAttribute("CaptionLanguage")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionCaptionLanguage[] CaptionLanguage
        {
            get
            {
                return this.captionLanguageField;
            }
            set
            {
                this.captionLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignLanguage")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionSignLanguage[] SignLanguage
        {
            get
            {
                return this.signLanguageField;
            }
            set
            {
                this.signLanguageField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributes AVAttributes
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
        [System.Xml.Serialization.XmlElementAttribute("MemberOf")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionMemberOf[] MemberOf
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionOtherIdentifier[] OtherIdentifier
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
        [System.Xml.Serialization.XmlElementAttribute("RelatedMaterial")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterial[] RelatedMaterial
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionTitle
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionSynopsis
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenre
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenreName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenreDefinition definitionField;

        private string typeField;

        private string metadataOriginIDRefField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenreName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenreDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenreName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionGenreDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseList
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PurchaseIdRef", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PurchaseItem", typeof(TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItem))]
        public object[] Items
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItem
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPrice[] priceField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchase[] purchaseField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemDescription[] descriptionField;

        private string[] pricingServerURLField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemDRMDeclaration dRMDeclarationField;

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Price")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPrice[] Price
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
        [System.Xml.Serialization.XmlElementAttribute("Purchase")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchase[] Purchase
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
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemDescription[] Description
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
        [System.Xml.Serialization.XmlElementAttribute("PricingServerURL")]
        public string[] PricingServerURL
        {
            get
            {
                return this.pricingServerURLField;
            }
            set
            {
                this.pricingServerURLField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemDRMDeclaration DRMDeclaration
        {
            get
            {
                return this.dRMDeclarationField;
            }
            set
            {
                this.dRMDeclarationField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPrice
    {

        private string currencyField;

        private float valueField;

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
        public float Value
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchase
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseType purchaseTypeField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit quantityUnitField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityRange quantityRangeField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseType PurchaseType
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

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit QuantityUnit
        {
            get
            {
                return this.quantityUnitField;
            }
            set
            {
                this.quantityUnitField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityRange QuantityRange
        {
            get
            {
                return this.quantityRangeField;
            }
            set
            {
                this.quantityRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseType
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchasePurchaseTypeDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnit
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityUnitDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemPurchaseQuantityRange
    {

        private uint minField;

        private uint maxField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemDescription
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionPurchaseListPurchaseItemDRMDeclaration
    {

        private string dRMField;

        private string licenseLocatorField;

        /// <remarks/>
        public string DRM
        {
            get
            {
                return this.dRMField;
            }
            set
            {
                this.dRMField = value;
            }
        }

        /// <remarks/>
        public string LicenseLocator
        {
            get
            {
                return this.licenseLocatorField;
            }
            set
            {
                this.licenseLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionCaptionLanguage
    {

        private bool primaryField;

        private bool translationField;

        private bool closedField;

        private bool supplementalField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool supplemental
        {
            get
            {
                return this.supplementalField;
            }
            set
            {
                this.supplementalField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionSignLanguage
    {

        private bool primaryField;

        private bool translationField;

        private string typeField;

        private bool closedField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributes
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormat fileFormatField;

        private ulong fileSizeField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystem systemField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesBitRate[] bitRateField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributes[] audioAttributesField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributes videoAttributesField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributes[] captioningAttributesField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormat FileFormat
        {
            get
            {
                return this.fileFormatField;
            }
            set
            {
                this.fileFormatField = value;
            }
        }

        /// <remarks/>
        public ulong FileSize
        {
            get
            {
                return this.fileSizeField;
            }
            set
            {
                this.fileSizeField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystem System
        {
            get
            {
                return this.systemField;
            }
            set
            {
                this.systemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BitRate")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesBitRate[] BitRate
        {
            get
            {
                return this.bitRateField;
            }
            set
            {
                this.bitRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AudioAttributes")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributes[] AudioAttributes
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

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributes VideoAttributes
        {
            get
            {
                return this.videoAttributesField;
            }
            set
            {
                this.videoAttributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaptioningAttributes")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributes[] CaptioningAttributes
        {
            get
            {
                return this.captioningAttributesField;
            }
            set
            {
                this.captioningAttributesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormat
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormatName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormatDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormatName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormatDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormatName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesFileFormatDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystem
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystemName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystemDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystemName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystemDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystemName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesSystemDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesBitRate
    {

        private bool variableField;

        private ulong minimumField;

        private ulong averageField;

        private ulong maximumField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong minimum
        {
            get
            {
                return this.minimumField;
            }
            set
            {
                this.minimumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong maximum
        {
            get
            {
                return this.maximumField;
            }
            set
            {
                this.maximumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributes
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCoding codingField;

        private ushort numOfChannelsField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixType mixTypeField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesAudioLanguage audioLanguageField;

        private uint sampleFrequencyField;

        private uint bitsPerSampleField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCoding Coding
        {
            get
            {
                return this.codingField;
            }
            set
            {
                this.codingField = value;
            }
        }

        /// <remarks/>
        public ushort NumOfChannels
        {
            get
            {
                return this.numOfChannelsField;
            }
            set
            {
                this.numOfChannelsField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixType MixType
        {
            get
            {
                return this.mixTypeField;
            }
            set
            {
                this.mixTypeField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesAudioLanguage AudioLanguage
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

        /// <remarks/>
        public uint SampleFrequency
        {
            get
            {
                return this.sampleFrequencyField;
            }
            set
            {
                this.sampleFrequencyField = value;
            }
        }

        /// <remarks/>
        public uint BitsPerSample
        {
            get
            {
                return this.bitsPerSampleField;
            }
            set
            {
                this.bitsPerSampleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCoding
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCodingName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCodingDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCodingName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCodingDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCodingName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesCodingDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixType
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixTypeName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixTypeDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixTypeName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixTypeDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixTypeName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesMixTypeDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesAudioAttributesAudioLanguage
    {

        private string purposeField;

        private string typeField;

        private bool supplementalField;

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
        public bool supplemental
        {
            get
            {
                return this.supplementalField;
            }
            set
            {
                this.supplementalField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributes
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCoding codingField;

        private string scanField;

        private ushort horizontalSizeField;

        private ushort verticalSizeField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesAspectRatio[] aspectRatioField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesColor colorField;

        private string frameRateField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCoding Coding
        {
            get
            {
                return this.codingField;
            }
            set
            {
                this.codingField = value;
            }
        }

        /// <remarks/>
        public string Scan
        {
            get
            {
                return this.scanField;
            }
            set
            {
                this.scanField = value;
            }
        }

        /// <remarks/>
        public ushort HorizontalSize
        {
            get
            {
                return this.horizontalSizeField;
            }
            set
            {
                this.horizontalSizeField = value;
            }
        }

        /// <remarks/>
        public ushort VerticalSize
        {
            get
            {
                return this.verticalSizeField;
            }
            set
            {
                this.verticalSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AspectRatio")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesAspectRatio[] AspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesColor Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public string FrameRate
        {
            get
            {
                return this.frameRateField;
            }
            set
            {
                this.frameRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCoding
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCodingName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCodingDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCodingName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCodingDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCodingName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesCodingDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesAspectRatio
    {

        private string typeField;

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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesVideoAttributesColor
    {

        private string typeField;

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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributes
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCoding codingField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCoding Coding
        {
            get
            {
                return this.codingField;
            }
            set
            {
                this.codingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCoding
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCodingName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCodingDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCodingName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCodingDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCodingName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionAVAttributesCaptioningAttributesCodingDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionMemberOf
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionOtherIdentifier
    {

        private string typeField;

        private string organizationField;

        private string authorityField;

        private string encodingField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterial
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelated howRelatedField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormat formatField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialMediaLocator mediaLocatorField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialPromotionalText[] promotionalTextField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialPromotionalMedia[] promotionalMediaField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialSourceMediaLocator sourceMediaLocatorField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelated HowRelated
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialMediaLocator MediaLocator
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalText")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialPromotionalText[] PromotionalText
        {
            get
            {
                return this.promotionalTextField;
            }
            set
            {
                this.promotionalTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalMedia")]
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialPromotionalMedia[] PromotionalMedia
        {
            get
            {
                return this.promotionalMediaField;
            }
            set
            {
                this.promotionalMediaField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialSourceMediaLocator SourceMediaLocator
        {
            get
            {
                return this.sourceMediaLocatorField;
            }
            set
            {
                this.sourceMediaLocatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelated
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelatedName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelatedDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelatedName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelatedDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelatedName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialHowRelatedDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormat
    {

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormatName nameField;

        private TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormatDefinition definitionField;

        private string hrefField;

        /// <remarks/>
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormatName Name
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
        public TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormatDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormatName
    {

        private bool preferredField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialFormatDefinition
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialMediaLocator
    {

        private string mediaUriField;

        private string streamIDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "", DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialPromotionalText
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialPromotionalMedia
    {

        private TitleImage titleImageField;

        private TitleVideo titleVideoField;

        private TitleAudio titleAudioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleImage TitleImage
        {
            get
            {
                return this.titleImageField;
            }
            set
            {
                this.titleImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleVideo TitleVideo
        {
            get
            {
                return this.titleVideoField;
            }
            set
            {
                this.titleVideoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TitleAudio TitleAudio
        {
            get
            {
                return this.titleAudioField;
            }
            set
            {
                this.titleAudioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventInstanceDescriptionRelatedMaterialSourceMediaLocator
    {

        private string mediaUriField;

        private string streamIDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "", DataType = "integer")]
        public string StreamID
        {
            get
            {
                return this.streamIDField;
            }
            set
            {
                this.streamIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventLive
    {

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventRepeat
    {

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventFirstShowing
    {

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventLastShowing
    {

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    public partial class TVAMainProgramDescriptionProgramLocationTableScheduleScheduleEventFree
    {

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    public partial class TVAMainProgramDescriptionServiceInformationTable
    {

        private TVAMainProgramDescriptionServiceInformationTableServiceInformation[] serviceInformationField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceInformation")]
        public TVAMainProgramDescriptionServiceInformationTableServiceInformation[] ServiceInformation
        {
            get
            {
                return this.serviceInformationField;
            }
            set
            {
                this.serviceInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionServiceInformationTableServiceInformation
    {

        private TVAMainProgramDescriptionServiceInformationTableServiceInformationName nameField;

        private string serviceURLField;

        private TVAMainProgramDescriptionServiceInformationTableServiceInformationLogo logoField;

        private TVAMainProgramDescriptionServiceInformationTableServiceInformationServiceDescription serviceDescriptionField;

        private TVAMainProgramDescriptionServiceInformationTableServiceInformationParentService parentServiceField;

        private TVAMainProgramDescriptionServiceInformationTableServiceInformationRelatedMaterial relatedMaterialField;

        private object purchaseListField;

        private string groupPurchaseIDRefField;

        private string serviceIdField;

        private string fragmentIdField;

        private byte fragmentVersionField;

        private System.DateTime fragmentExpirationDateField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        public TVAMainProgramDescriptionServiceInformationTableServiceInformationName Name
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
        public string ServiceURL
        {
            get
            {
                return this.serviceURLField;
            }
            set
            {
                this.serviceURLField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionServiceInformationTableServiceInformationLogo Logo
        {
            get
            {
                return this.logoField;
            }
            set
            {
                this.logoField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionServiceInformationTableServiceInformationServiceDescription ServiceDescription
        {
            get
            {
                return this.serviceDescriptionField;
            }
            set
            {
                this.serviceDescriptionField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionServiceInformationTableServiceInformationParentService ParentService
        {
            get
            {
                return this.parentServiceField;
            }
            set
            {
                this.parentServiceField = value;
            }
        }

        /// <remarks/>
        public TVAMainProgramDescriptionServiceInformationTableServiceInformationRelatedMaterial RelatedMaterial
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
        public object PurchaseList
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
        public string GroupPurchaseIDRef
        {
            get
            {
                return this.groupPurchaseIDRefField;
            }
            set
            {
                this.groupPurchaseIDRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceId
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fragmentId
        {
            get
            {
                return this.fragmentIdField;
            }
            set
            {
                this.fragmentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fragmentVersion
        {
            get
            {
                return this.fragmentVersionField;
            }
            set
            {
                this.fragmentVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime fragmentExpirationDate
        {
            get
            {
                return this.fragmentExpirationDateField;
            }
            set
            {
                this.fragmentExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionServiceInformationTableServiceInformationName
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
    public partial class TVAMainProgramDescriptionServiceInformationTableServiceInformationLogo
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
    public partial class TVAMainProgramDescriptionServiceInformationTableServiceInformationServiceDescription
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
    public partial class TVAMainProgramDescriptionServiceInformationTableServiceInformationParentService
    {

        private string serviceIDRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceIDRef
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class TVAMainProgramDescriptionServiceInformationTableServiceInformationRelatedMaterial
    {

        private TVAMainProgramDescriptionServiceInformationTableServiceInformationRelatedMaterialMediaLocator mediaLocatorField;

        /// <remarks/>
        public TVAMainProgramDescriptionServiceInformationTableServiceInformationRelatedMaterialMediaLocator MediaLocator
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
    public partial class TVAMainProgramDescriptionServiceInformationTableServiceInformationRelatedMaterialMediaLocator
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
    public partial class TVAMainProgramDescriptionCreditsInformationTable
    {

        private string copyrightNoticeField;

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string copyrightNotice
        {
            get
            {
                return this.copyrightNoticeField;
            }
            set
            {
                this.copyrightNoticeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionSegmentInformationTable
    {

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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
    public partial class TVAMainProgramDescriptionPurchaseInformationTable
    {

        private string metadataOriginIDRefField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string metadataOriginIDRef
        {
            get
            {
                return this.metadataOriginIDRefField;
            }
            set
            {
                this.metadataOriginIDRefField = value;
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



}
