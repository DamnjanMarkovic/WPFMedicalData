using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMedicalDataGrid.Model
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/MedicalData.xsd", IsNullable = false)]
    public partial class MedicalData
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnatomicRegion", typeof(MedicalDataAnatomicRegion))]
        [System.Xml.Serialization.XmlElementAttribute("AnatomicRegionTableDefinition", typeof(MedicalDataAnatomicRegionTableDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("ApplicationMode", typeof(MedicalDataApplicationMode))]
        [System.Xml.Serialization.XmlElementAttribute("AvanseHumanBodyPart", typeof(MedicalDataAvanseHumanBodyPart))]
        [System.Xml.Serialization.XmlElementAttribute("Filter", typeof(MedicalDataFilter))]
        [System.Xml.Serialization.XmlElementAttribute("PatientSize", typeof(MedicalDataPatientSize))]
        [System.Xml.Serialization.XmlElementAttribute("Procedure", typeof(MedicalDataProcedure))]
        [System.Xml.Serialization.XmlElementAttribute("ProcedureProgram", typeof(MedicalDataProcedureProgram))]
        [System.Xml.Serialization.XmlElementAttribute("Program", typeof(MedicalDataProgram))]
        [System.Xml.Serialization.XmlElementAttribute("Species", typeof(MedicalDataSpecies))]
        [System.Xml.Serialization.XmlElementAttribute("StandPosition", typeof(MedicalDataStandPosition))]
        [System.Xml.Serialization.XmlElementAttribute("Technique", typeof(MedicalDataTechnique))]
        [System.Xml.Serialization.XmlElementAttribute("ViewPosition", typeof(MedicalDataViewPosition))]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataAnatomicRegion : ObservableObject
    {

        private int iDAnatomicRegionField;

        private string codingSchemaField;

        private string schemaVersionField;

        private string codeValueField;

        private string descriptionField;

        private string bodyPartExaminedField;

        private int iDAvanseHumanBodyPartField;

        private bool iDAvanseHumanBodyPartFieldSpecified;

        private int iDAnatomicRegionTableDefinitionField;

        public MedicalDataAnatomicRegion()
        {
            this.schemaVersionField = "1.0.0";
        }

        /// <remarks/>
        public int IDAnatomicRegion
        {
            get
            {
                return this.iDAnatomicRegionField;
            }
            set
            {
                this.iDAnatomicRegionField = value;
            }
        }

        /// <remarks/>
        public string CodingSchema
        {
            get
            {
                return this.codingSchemaField;
            }
            set
            {
                this.codingSchemaField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute("1.0.0")]
        public string SchemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }

        /// <remarks/>
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
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

        /// <remarks/>
        public string BodyPartExamined
        {
            get
            {
                return this.bodyPartExaminedField;
            }
            set
            {
                this.bodyPartExaminedField = value;
            }
        }

        /// <remarks/>
        public int IDAvanseHumanBodyPart
        {
            get
            {
                return this.iDAvanseHumanBodyPartField;
            }
            set
            {
                this.iDAvanseHumanBodyPartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDAvanseHumanBodyPartSpecified
        {
            get
            {
                return this.iDAvanseHumanBodyPartFieldSpecified;
            }
            set
            {
                this.iDAvanseHumanBodyPartFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int IDAnatomicRegionTableDefinition
        {
            get
            {
                return this.iDAnatomicRegionTableDefinitionField;
            }
            set
            {
                this.iDAnatomicRegionTableDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataAnatomicRegionTableDefinition : ObservableObject
    {

        private int iDAnatomicRegionTableDefinitionField;

        private string descriptionField;

        /// <remarks/>
        public int IDAnatomicRegionTableDefinition
        {
            get
            {
                return this.iDAnatomicRegionTableDefinitionField;
            }
            set
            {
                this.iDAnatomicRegionTableDefinitionField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataApplicationMode : ObservableObject
    {

        private int iDApplicationModeField;

        private string nameField;

        /// <remarks/>
        public int IDApplicationMode
        {
            get
            {
                return this.iDApplicationModeField;
            }
            set
            {
                this.iDApplicationModeField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataAvanseHumanBodyPart : ObservableObject
    {

        private int iDAvanseHumanBodyPartField;

        private string nameField;

        /// <remarks/>
        public int IDAvanseHumanBodyPart
        {
            get
            {
                return this.iDAvanseHumanBodyPartField;
            }
            set
            {
                this.iDAvanseHumanBodyPartField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataFilter : ObservableObject, IDataErrorInfo
    {

        private int iDFilterField;

        private string nameField;

        private double mmAIField;

        private double mmCuField;

        private string codeField;

        /// <remarks/>
        public int IDFilter
        {
            get
            {
                return this.iDFilterField;
            }
            set
            {
                this.iDFilterField = value;

            }
        }

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
                OnPropertyChanged(Name);
            }
        }

        /// <remarks/>
        public double mmAI
        {
            get
            {
                return this.mmAIField;
            }
            set
            {
                this.mmAIField = value;
                OnPropertyChanged(nameof(mmAI));
            }
        }

        /// <remarks/>
        public double mmCu
        {
            get
            {
                return this.mmCuField;
            }
            set
            {
                this.mmCuField = value;
                OnPropertyChanged(nameof(mmCu));
            }
        }

        /// <remarks/>
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                OnPropertyChanged(Code);
            }
        }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "Name")
                {
                    if (string.IsNullOrWhiteSpace(this.nameField) || this.nameField == "")
                    {
                        result = "Enter Name";

                    }
                }

                if (name == "mmAI")
                {
                    if (!(int.TryParse(mmAIField.ToString(), out int c)))
                    {
                        result = "Enter Int Value";
                    }
                }

                if (name == "mmCu")
                {
                    if (!(int.TryParse(mmCuField.ToString(), out int c)))
                    {
                        result = "Enter Int value";
                    }
                }

                return result;
            }
        }

        public MedicalDataFilter()
        {
            this.nameField = "";
            this.mmAIField = 0;
            this.mmCuField = 0;
            this.codeField = "";
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataPatientSize : ObservableObject, IDataErrorInfo
    {

        private int iDPatientSizeField;

        private string nameField;

        private int? minAgeMonthsField;

        private int? maxAgeMonthsField;

        private double? minWeightKgsField;

        private double? maxWeightKgsField;

        private string thumbnailField;

        /// <remarks/>
        public int IDPatientSize
        {
            get
            {
                return this.iDPatientSizeField;
            }
            set
            {
                this.iDPatientSizeField = value;
            }
        }

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
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <remarks/>
        public int? MinAgeMonths
        {
            get
            {
                return this.minAgeMonthsField;
            }
            set
            {
                this.minAgeMonthsField = value;
                OnPropertyChanged(nameof(MinAgeMonths));
            }
        }


        /// <remarks/>
        public int? MaxAgeMonths
        {
            get
            {
                return this.maxAgeMonthsField;
            }
            set
            {
                this.maxAgeMonthsField = value;
                OnPropertyChanged(nameof(MaxAgeMonths));
            }
        }


        /// <remarks/>
        public double? MinWeightKgs
        {
            get
            {
                return this.minWeightKgsField;
            }
            set
            {
                this.minWeightKgsField = value;
                OnPropertyChanged(nameof(MinWeightKgs));
            }
        }

        /// <remarks/>
        public double? MaxWeightKgs
        {
            get
            {
                return this.maxWeightKgsField;
            }
            set
            {
                this.maxWeightKgsField = value;
                OnPropertyChanged(nameof(MaxWeightKgs));
            }
        }

        /// <remarks/>
        public string Thumbnail
        {
            get
            {
                return this.thumbnailField;
            }
            set
            {
                this.thumbnailField = value;
                OnPropertyChanged(nameof(Thumbnail));
            }
        }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "Name")
                {
                    if (string.IsNullOrWhiteSpace(this.nameField) || this.nameField == "")
                    {
                        result = "Enter Name";

                    }
                }
                if (name == "MinAgeMonths")
                {

                    if (!(int.TryParse(minAgeMonthsField.ToString(), out int c)) && minAgeMonthsField != null)
                    {
                        result = "Enter Int Value";
                    }


                }
                if (name == "MaxAgeMonths")
                {
                    if (!(int.TryParse(maxAgeMonthsField.ToString(), out int c)) && maxAgeMonthsField != null)
                    {
                        result = "Enter Int Value";
                    }

                }
                if (name == "MinWeightKgs")
                {
                    if (!(double.TryParse(minWeightKgsField.ToString(), out double c)))
                    {
                        result = "Enter decimal Value";
                    }

                }

                if (name == "MaxWeightKgs")
                {
                    if (!(double.TryParse(maxWeightKgsField.ToString(), out double c)))
                    {
                        result = "Enter decimal Value";
                    }

                }

                return result;
            }
        }

        public MedicalDataPatientSize()
        {
            this.nameField = "";
            this.minAgeMonthsField = null;
            this.maxAgeMonthsField = null;
            this.minWeightKgsField = null;
            this.maxWeightKgsField = null;
            this.thumbnailField = "";
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataProcedure : ObservableObject, IDataErrorInfo
    {

        private int iDProcedureField;

        private string codingSchemaField;

        private string schemaVersionField;

        private string codeValueField;

        private string descriptionField;

        private int idAvanseHumanBodyPartField;

        private string sideField;

        private int orderField;


        private string readingPhysicianField;

        public MedicalDataProcedure()
        {
            this.codingSchemaField = "AvDR";
            this.schemaVersionField = "1.0.0";
            this.codeValueField = "";
            this.descriptionField = "";
            this.orderField = 0;
            this.readingPhysicianField = "";
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "CodingSchema")
                {
                    if (string.IsNullOrWhiteSpace(this.codingSchemaField) || this.codingSchemaField == "")
                    {
                        result = "Enter CodingSchema";

                    }
                }
                if (name == "SchemaVersion")
                {
                    if (string.IsNullOrEmpty(this.schemaVersionField))
                    {
                        result = "Enter SchemaVersion";
                    }

                }
                if (name == "CodeValue")
                {
                    if (string.IsNullOrEmpty(this.codeValueField))
                    {
                        result = "Enter CodeValue";
                    }

                }
                if (name == "Description")
                {
                    if (string.IsNullOrEmpty(this.descriptionField))
                    {
                        result = "Enter Description";
                    }

                }
                if (name == "IdAvanseHumanBodyPart")
                {
                    if (this.idAvanseHumanBodyPartField == 0)
                    {
                        result = "Select AvanseHumanBodyPart";
                    }
                }
                //if (name == "Side")
                //{
                //    if (string.IsNullOrEmpty(this.sideField))
                //    {
                //        result = "Select Side";
                //    }
                //}
                return result;
            }
        }

        /// <remarks/>
        public int IDProcedure
        {
            get
            {
                return this.iDProcedureField;
            }
            set
            {
                this.iDProcedureField = value;
            }
        }

        /// <remarks/>
        public string CodingSchema
        {
            get
            {
                return this.codingSchemaField;
            }
            set
            {
                this.codingSchemaField = value;
                OnPropertyChanged(CodingSchema);
            }
        }

        /// <remarks/>
        public string SchemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
                OnPropertyChanged(nameof(SchemaVersion));
            }
        }

        /// <remarks/>
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
                OnPropertyChanged(nameof(CodeValue));
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
                OnPropertyChanged(nameof(Description));
            }
        }

        /// <remarks/>
        public int IdAvanseHumanBodyPart
        {
            get
            {
                return this.idAvanseHumanBodyPartField;
            }
            set
            {
                this.idAvanseHumanBodyPartField = value;
                OnPropertyChanged(nameof(IdAvanseHumanBodyPart));
            }
        }

        /// <remarks/>
        public string Side
        {
            get
            {
                return this.sideField;
            }
            set
            {
                this.sideField = value;
                OnPropertyChanged(nameof(Side));
            }
        }

        /// <remarks/>
        public int Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
                OnPropertyChanged(nameof(Order));
            }
        }


        /// <remarks/>
        public string ReadingPhysician
        {
            get
            {
                return this.readingPhysicianField;
            }
            set
            {
                this.readingPhysicianField = value;
                OnPropertyChanged(nameof(ReadingPhysician));
            }
        }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataProcedureProgram : ObservableObject, IDataErrorInfo
    {

        private int iDProcedureProgramField;

        private int idProcedureField;

        private int idProgramField;

        private string side;

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "IdProcedure")
                {
                    if (this.idProcedureField == 0)
                    {
                        result = "Select procedure";
                    }
                }
                if (name == "IdProgram")
                {
                    if (this.idProgramField == 0)
                    {
                        result = "Select program";
                    }
                }
                return result;
            }
        }

        /// <remarks/>
        public int IDProcedureProgram
        {
            get
            {
                return this.iDProcedureProgramField;
            }
            set
            {
                this.iDProcedureProgramField = value;
            }
        }

        /// <remarks/>
        public int IdProcedure
        {
            get
            {
                return this.idProcedureField;
            }
            set
            {
                this.idProcedureField = value;
                OnPropertyChanged(nameof(IdProcedure));
            }
        }

        /// <remarks/>
        public int IdProgram
        {
            get
            {
                return this.idProgramField;
            }
            set
            {
                this.idProgramField = value;
                OnPropertyChanged(nameof(IdProgram));
            }
        }

        public string Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
                OnPropertyChanged(nameof(Side));
            }
        }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataProgram : ObservableObject, IDataErrorInfo
    {

        private int iDProgramField;

        private int idAnatomicRegionField;

        private int idViewPositionField;

        private int idApplicationModeField;

        private string lateralityField;

        private string externalMappingField;

        private int idSystemWSField;


        private string gridField;

        private string rADDetectorModeField;

        private double rADFpsField;

        private int rADMaxNFramesField;

        private string rADSequenceDescriptionField;

        private string fLDetectorModeField;

        private double fLFpsField;

        private bool fLEnableABCField;

        private double fLMaxExpTimeSecField;

        private bool fLEnableStoreAllField;

        private string beamAngleField;

        private int idStandPositionField;

        private decimal sIDField;


        private double maxTotalDoseField;


        private double maxTotalDAPField;


        private double eILowerBoundField;


        private double eIUpperBoundField;


        private decimal scatterToPrimaryRatioField;

        private double imageRotationField;

        private string imageMirrorField;

        private bool autoCorpField;

        private bool autoRotateField;

        private string xipAlgoField;

        private string xipGroupField;

        private bool activeField;

        private string thumbPathField;

        private int orderField;

        private string atlasFilenameField;

        private string demoField;

        public MedicalDataProgram()
        {
            this.externalMappingField = "";
            this.gridField = "";
            this.rADDetectorModeField = "";
            this.rADMaxNFramesField = 0;
            this.rADSequenceDescriptionField = "";
            this.sIDField = 0;
            this.maxTotalDoseField = 0;
            this.maxTotalDAPField = 0;
            this.eILowerBoundField = 0;
            this.eIUpperBoundField = 0;
            this.scatterToPrimaryRatioField = 0;
            this.imageMirrorField = "";
            this.xipAlgoField = "";
            this.xipGroupField = "";
            this.thumbPathField = "";
            this.orderField = 0;
            this.atlasFilenameField = "";
            this.demoField = "";
            this.rADFpsField = 0;
            this.fLDetectorModeField = "-1";
            this.fLFpsField = 0;
            this.fLEnableABCField = true;
            this.fLMaxExpTimeSecField = 600;
            this.fLEnableStoreAllField = false;
            this.beamAngleField = "0,0";
            this.imageRotationField = 0;
            this.autoCorpField = true;
            this.autoRotateField = true;
            this.activeField = true;
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "IdAnatomicRegion")
                {
                    if (this.idAnatomicRegionField == 0)
                    {
                        result = "Select AnatomicRegion";
                    }
                }
                if (name == "IdViewPosition")
                {
                    if (this.idViewPositionField == 0)
                    {
                        result = "Select ViewPosition";
                    }
                }
                if (name == "IdApplicationMode")
                {
                    if (this.idApplicationModeField < 0)
                    {
                        result = "Select ApplicationMode";
                    }
                }
                if (name == "Laterality")
                {
                    if (string.IsNullOrEmpty(this.lateralityField))
                    {
                        result = "Select Laterality";
                    }
                }

                if (name == "RadDetectorMode")
                {
                    if (string.IsNullOrWhiteSpace(this.rADDetectorModeField) || this.rADDetectorModeField == "")
                    {
                        result = "Enter RadDetectorMode";

                    }
                }
                if (name == "RadFps")
                {
                    if (!(double.TryParse(rADFpsField.ToString(), out double c)))
                    {
                        result = "Enter double Value";
                    }
                }

                if (name == "RADMaxNFrames")
                {
                    if (!(int.TryParse(rADMaxNFramesField.ToString(), out int c)))
                    {
                        result = "Enter Int Value";
                    }
                }
                if (name == "FLDetectorMode")
                {
                    if (string.IsNullOrWhiteSpace(this.fLDetectorModeField) || this.fLDetectorModeField == "")
                    {
                        result = "Enter FLDetectorMode";

                    }
                }

                if (name == "FLFps")
                {
                    if (!(double.TryParse(fLFpsField.ToString(), out double c)))
                    {
                        result = "Enter double Value";
                    }
                }
                if (name == "FLMaxExpTimeSec")
                {
                    if (this.fLMaxExpTimeSecField == 0)
                    {
                        result = "Enter FLMaxExpTimeSec";
                    }

                }

                if (name == "FLMaxExpTimeSec")
                {
                    if (!(double.TryParse(fLMaxExpTimeSecField.ToString(), out double c)))
                    {
                        result = "Enter double Value";
                    }
                }

                if (name == "BeamAngle")
                {
                    if (string.IsNullOrWhiteSpace(this.beamAngleField) || this.beamAngleField == "")
                    {
                        result = "Enter BeamAngle";

                    }
                }
                if (name == "SID")
                {
                    if (!(float.TryParse(sIDField.ToString(), out float c)))
                    {
                        result = "Enter number value";
                    }
                }

                if (name == "MaxTotalDose")
                {
                    if (!(double.TryParse(maxTotalDoseField.ToString(), out double c)))
                    {
                        result = "Enter number value";
                    }
                }
                if (name == "MaxTotalDAP")
                {
                    if (!(double.TryParse(maxTotalDAPField.ToString(), out double c)))
                    {
                        result = "Enter number value";
                    }
                }
                if (name == "EILowerBound")
                {
                    if (!(double.TryParse(eILowerBoundField.ToString(), out double c)))
                    {
                        result = "Enter number value";
                    }
                }
                if (name == "EIUpperBound")
                {
                    if (!(double.TryParse(eIUpperBoundField.ToString(), out double c)))
                    {
                        result = "Enter number value";
                    }
                }
                if (name == "ScatterToPrimaryRatio")
                {
                    if (!(float.TryParse(scatterToPrimaryRatioField.ToString(), out float c)))
                    {
                        result = "Enter number value";
                    }
                }

                if (name == "ImageRotation")
                {
                    if (!(double.TryParse(imageRotationField.ToString(), out double c)))
                    {
                        result = "Enter number value";
                    }
                }

                if (name == "XipAlgo")
                {
                    if (string.IsNullOrWhiteSpace(this.xipAlgoField) || this.xipAlgoField == "")
                    {
                        result = "Enter XipAlgo";

                    }
                }
                if (name == "XipGroup")
                {
                    if (string.IsNullOrWhiteSpace(this.xipGroupField) || this.xipGroupField == "")
                    {
                        result = "Enter XipGroup";

                    }
                }
                if (name == "Order")
                {
                    if (!(int.TryParse(imageRotationField.ToString(), out int c)))
                    {
                        result = "Enter number value";
                    }
                }

                return result;
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <remarks/>
        public int IDProgram
        {
            get
            {
                return this.iDProgramField;
            }
            set
            {
                this.iDProgramField = value;
            }
        }

        /// <remarks/>
        public int IdAnatomicRegion
        {
            get
            {
                return this.idAnatomicRegionField;
            }
            set
            {
                this.idAnatomicRegionField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public int IdViewPosition
        {
            get
            {
                return this.idViewPositionField;
            }
            set
            {
                this.idViewPositionField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public int IdApplicationMode
        {
            get
            {
                return this.idApplicationModeField;
            }
            set
            {
                this.idApplicationModeField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string Laterality
        {
            get
            {
                return this.lateralityField;
            }
            set
            {
                this.lateralityField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string ExternalMapping
        {
            get
            {
                return this.externalMappingField;
            }
            set
            {
                this.externalMappingField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public int IdSystemWS
        {
            get
            {
                return this.idSystemWSField;
            }
            set
            {
                this.idSystemWSField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string Grid
        {
            get
            {
                return this.gridField;
            }
            set
            {
                this.gridField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string RADDetectorMode
        {
            get
            {
                return this.rADDetectorModeField;
            }
            set
            {
                this.rADDetectorModeField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public double RADFps
        {
            get
            {
                return this.rADFpsField;
            }
            set
            {
                this.rADFpsField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public int RADMaxNFrames
        {
            get
            {
                return this.rADMaxNFramesField;
            }
            set
            {
                this.rADMaxNFramesField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string RADSequenceDescription
        {
            get
            {
                return this.rADSequenceDescriptionField;
            }
            set
            {
                this.rADSequenceDescriptionField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string FLDetectorMode
        {
            get
            {
                return this.fLDetectorModeField;
            }
            set
            {
                this.fLDetectorModeField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public double FLFps
        {
            get
            {
                return this.fLFpsField;
            }
            set
            {
                this.fLFpsField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public bool FLEnableABC
        {
            get
            {
                return this.fLEnableABCField;
            }
            set
            {
                this.fLEnableABCField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public double FLMaxExpTimeSec
        {
            get
            {
                return this.fLMaxExpTimeSecField;
            }
            set
            {
                this.fLMaxExpTimeSecField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public bool FLEnableStoreAll
        {
            get
            {
                return this.fLEnableStoreAllField;
            }
            set
            {
                this.fLEnableStoreAllField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string BeamAngle
        {
            get
            {
                return this.beamAngleField;
            }
            set
            {
                this.beamAngleField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public int IdStandPosition
        {
            get
            {
                return this.idStandPositionField;
            }
            set
            {
                this.idStandPositionField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public decimal SID
        {
            get
            {
                return this.sIDField;
            }
            set
            {
                this.sIDField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public double MaxTotalDose
        {
            get
            {
                return this.maxTotalDoseField;
            }
            set
            {
                this.maxTotalDoseField = value;
                OnPropertyChanged();
            }
        }


        /// <remarks/>
        public double MaxTotalDAP
        {
            get
            {
                return this.maxTotalDAPField;
            }
            set
            {
                this.maxTotalDAPField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public double EILowerBound
        {
            get
            {
                return this.eILowerBoundField;
            }
            set
            {
                this.eILowerBoundField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public double EIUpperBound
        {
            get
            {
                return this.eIUpperBoundField;
            }
            set
            {
                this.eIUpperBoundField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public decimal ScatterToPrimaryRatio
        {
            get
            {
                return this.scatterToPrimaryRatioField;
            }
            set
            {
                this.scatterToPrimaryRatioField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public double ImageRotation
        {
            get
            {
                return this.imageRotationField;
            }
            set
            {
                this.imageRotationField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string ImageMirror
        {
            get
            {
                return this.imageMirrorField;
            }
            set
            {
                this.imageMirrorField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public bool AutoCorp
        {
            get
            {
                return this.autoCorpField;
            }
            set
            {
                this.autoCorpField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public bool AutoRotate
        {
            get
            {
                return this.autoRotateField;
            }
            set
            {
                this.autoRotateField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string XipAlgo
        {
            get
            {
                return this.xipAlgoField;
            }
            set
            {
                this.xipAlgoField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string XipGroup
        {
            get
            {
                return this.xipGroupField;
            }
            set
            {
                this.xipGroupField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public bool Active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string ThumbPath
        {
            get
            {
                return this.thumbPathField;
            }
            set
            {
                this.thumbPathField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public int Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string AtlasFilename
        {
            get
            {
                return this.atlasFilenameField;
            }
            set
            {
                this.atlasFilenameField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string Demo
        {
            get
            {
                return this.demoField;
            }
            set
            {
                this.demoField = value;
                OnPropertyChanged();
            }
        }
        [XmlIgnore]
        public string Description { get; set; }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataSpecies : ObservableObject
    {

        private int iDSpeciesField;

        private string codingSchemaField;

        private string schemaVersionField;

        private string codeValueField;

        private string descriptionField;

        private int iDAnatomicRegionTableDefinitionField;

        public MedicalDataSpecies()
        {
            this.codingSchemaField = "";
            this.schemaVersionField = "1.0.0";
            this.codeValueField = "";
            this.descriptionField = "";
        }

        /// <remarks/>
        public int IDSpecies
        {
            get
            {
                return this.iDSpeciesField;
            }
            set
            {
                this.iDSpeciesField = value;
            }
        }

        /// <remarks/>
        public string CodingSchema
        {
            get
            {
                return this.codingSchemaField;
            }
            set
            {
                this.codingSchemaField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute("1.0.0")]
        public string SchemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }

        /// <remarks/>
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
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

        /// <remarks/>
        public int IDAnatomicRegionTableDefinition
        {
            get
            {
                return this.iDAnatomicRegionTableDefinitionField;
            }
            set
            {
                this.iDAnatomicRegionTableDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataStandPosition : ObservableObject, IDataErrorInfo
    {

        private int iDStandPositionField;

        private string nameField;

        private string commandField;

        private uint activeDetectorField;

        public MedicalDataStandPosition()
        {
            this.nameField = "";
            this.commandField = "";
            this.activeDetectorField = 0;
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "Name")
                {
                    if (string.IsNullOrWhiteSpace(this.nameField) || this.nameField == "")
                    {
                        result = "Enter Name";

                    }
                }
                if (name == "Command")
                {
                    if (string.IsNullOrEmpty(this.commandField))
                    {
                        result = "Enter Command";
                    }

                }

                if (name == "ActiveDetector")
                {
                    if (!(int.TryParse(activeDetectorField.ToString(), out int c)))
                    {
                        result = "Enter Int Value";
                    }
                }
                return result;
            }
        }

        /// <remarks/>
        public int IDStandPosition
        {
            get
            {
                return this.iDStandPositionField;
            }
            set
            {
                this.iDStandPositionField = value;
            }
        }

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
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <remarks/>
        public string Command
        {
            get
            {
                return this.commandField;
            }
            set
            {
                this.commandField = value;
                OnPropertyChanged(nameof(Command));
            }
        }

        /// <remarks/>
        public uint ActiveDetector
        {
            get
            {
                return this.activeDetectorField;
            }
            set
            {
                this.activeDetectorField = value;
                OnPropertyChanged(nameof(ActiveDetector));
            }
        }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataTechnique : ObservableObject, IDataErrorInfo
    {

        private int iDTechniqueField;

        private int idProgramField;

        private int idPatientSizeField;

        private int kvField;

        private double rAD_MAField;

        private string rAD_FocusField;

        private double rAD_MASField;

        private int idFilter_RADField;


        private string aECField;

        private double backupMASField;

        private int denesityField;

        private double collimatorFovXField;


        private double collimatorFovYField;

        private double fL_FrameDoseField;

        private double fL_MAField;

        private double fL_MASField;

        private string fL_FocusField;

        private int idFilter_FLField;

        public MedicalDataTechnique()
        {



            this.kvField = 0;
            this.rAD_MAField = 0;
            this.rAD_FocusField = "";
            this.rAD_MASField = 0;
            this.aECField = "";
            this.backupMASField = 0.0;
            this.collimatorFovXField = 0.0;
            this.collimatorFovYField = 0.0;
            this.fL_FrameDoseField = 0.0;
            this.fL_MAField = 0;
            this.fL_MASField = 0;
            this.fL_FocusField = "";
            this.denesityField = 0;
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "IdProgram")
                {
                    if (this.idProgramField == 0)
                    {
                        result = "Select program";
                    }
                }
                if (name == "IdPatientSize")
                {
                    if (this.idPatientSizeField == 0)
                    {
                        result = "Select PatientSize";
                    }
                }

                if (name == "KV")
                {
                    if (!(int.TryParse(kvField.ToString(), out int c)))
                    {
                        result = "Enter int Value";
                    }
                }
                if (name == "RAD_MA")
                {
                    if (this.rAD_MAField == 0)
                    {
                        result = "Enter RAD_MA";
                    }

                }


                if (name == "RAD_Focus")
                {
                    if (string.IsNullOrEmpty(this.rAD_FocusField))
                    {
                        result = "Select RAD_Fokus";

                    }
                }
                if (name == "RAD_MAS")
                {
                    if (this.rAD_MASField == 0)
                    {
                        result = "Select RAD_MAS";
                    }

                }

                if (name == "Density")
                {
                    if (this.denesityField == 0)
                    {
                        result = "Enter Denity";
                    }

                }

                if (name == "Density")
                {
                    if (!(int.TryParse(denesityField.ToString(), out int c)))
                    {
                        result = "Enter int Value";
                    }
                }
                if (name == "CollimatorFovX")
                {
                    if (!(double.TryParse(collimatorFovXField.ToString(), out double c)))
                    {
                        result = "Enter double Value";
                    }
                }
                if (name == "CollimatorFovY")
                {
                    if (!(double.TryParse(collimatorFovYField.ToString(), out double c)))
                    {
                        result = "Enter double Value";
                    }
                }

                if (name == "FL_FrameDose")
                {
                    if (!(double.TryParse(fL_FrameDoseField.ToString(), out double c)))
                    {
                        result = "Enter double Value";
                    }
                }

                if (name == "FL_MA")
                {
                    if (this.fL_MAField == 0)
                    {
                        result = "Select FL_MA";
                    }
                }
                if (name == "FL_MAS")
                {
                    if (this.fL_MASField == 0)
                    {
                        result = "Select FL_MAS";
                    }
                }

                if (name == "FL_Focus")
                {
                    if (string.IsNullOrEmpty(this.fL_FocusField))
                    {
                        result = "Select FL_Fokus";
                    }

                }

                return result;
            }
        }

        /// <remarks/>
        public int IDTechnique
        {
            get
            {
                return this.iDTechniqueField;
            }
            set
            {
                this.iDTechniqueField = value;
            }
        }

        /// <remarks/>
        public int IdProgram
        {
            get
            {
                return this.idProgramField;
            }
            set
            {
                this.idProgramField = value;
                OnPropertyChanged(nameof(IdProgram));
            }
        }

        /// <remarks/>
        public int IdPatientSize
        {
            get
            {
                return this.idPatientSizeField;
            }
            set
            {
                this.idPatientSizeField = value;
                OnPropertyChanged(nameof(IdPatientSize));
            }
        }

        /// <remarks/>
        public int KV
        {
            get
            {
                return this.kvField;
            }
            set
            {
                this.kvField = value;
                OnPropertyChanged(nameof(KV));
            }
        }

        /// <remarks/>
        public double RAD_MA
        {
            get
            {
                return this.rAD_MAField;
            }
            set
            {
                this.rAD_MAField = value;
                OnPropertyChanged(nameof(RAD_MA));
            }
        }

        /// <remarks/>
        public string RAD_Focus
        {
            get
            {
                return this.rAD_FocusField;
            }
            set
            {
                this.rAD_FocusField = value;
                OnPropertyChanged(nameof(RAD_Focus));
            }
        }

        /// <remarks/>
        public double RAD_MAS
        {
            get
            {
                return this.rAD_MASField;
            }
            set
            {
                this.rAD_MASField = value;
                OnPropertyChanged(nameof(RAD_MAS));
            }
        }

        /// <remarks/>
        public int IdFilter_RAD
        {
            get
            {
                return this.idFilter_RADField;
            }
            set
            {
                this.idFilter_RADField = value;
                OnPropertyChanged(nameof(IdFilter_RAD));
            }
        }

        /// <remarks/>
        public string AEC
        {
            get
            {
                return this.aECField;
            }
            set
            {
                this.aECField = value;
                OnPropertyChanged(nameof(AEC));
            }
        }

        /// <remarks/>
        public double BackupMAS
        {
            get
            {
                return this.backupMASField;
            }
            set
            {
                this.backupMASField = value;
                OnPropertyChanged(nameof(BackupMAS));
            }
        }

        /// <remarks/>
        public int Denesity
        {
            get
            {
                return this.denesityField;
            }
            set
            {
                this.denesityField = value;
                OnPropertyChanged(nameof(Denesity));
            }
        }

        /// <remarks/>
        public double CollimatorFovX
        {
            get
            {
                return this.collimatorFovXField;
            }
            set
            {
                this.collimatorFovXField = value;
                OnPropertyChanged(nameof(CollimatorFovX));
            }
        }

        /// <remarks/>
        public double CollimatorFovY
        {
            get
            {
                return this.collimatorFovYField;
            }
            set
            {
                this.collimatorFovYField = value;
                OnPropertyChanged(nameof(CollimatorFovY));
            }
        }

        /// <remarks/>
        public double FL_FrameDose
        {
            get
            {
                return this.fL_FrameDoseField;
            }
            set
            {
                this.fL_FrameDoseField = value;
                OnPropertyChanged(nameof(FL_FrameDose));
            }
        }

        /// <remarks/>
        public double FL_MA
        {
            get
            {
                return this.fL_MAField;
            }
            set
            {
                this.fL_MAField = value;
                OnPropertyChanged(nameof(FL_MA));
            }
        }

        /// <remarks/>
        public double FL_MAS
        {
            get
            {
                return this.fL_MASField;
            }
            set
            {
                this.fL_MASField = value;
                OnPropertyChanged(nameof(FL_MAS));
            }
        }

        /// <remarks/>
        public string FL_Focus
        {
            get
            {
                return this.fL_FocusField;
            }
            set
            {
                this.fL_FocusField = value;
                OnPropertyChanged(nameof(FL_Focus));
            }
        }

        /// <remarks/>
        public int IdFilter_FL
        {
            get
            {
                return this.idFilter_FLField;
            }
            set
            {
                this.idFilter_FLField = value;
                OnPropertyChanged(nameof(IdFilter_FL));
            }
        }

        [XmlIgnore]
        public int RAD_MS
        {

            get
            {
                if (RAD_MAS != 0 && RAD_MA != 0)
                {
                    return (int)(RAD_MAS / RAD_MA * 1000);
                }
                else
                {
                    return 0;
                }

            }
            set { OnPropertyChanged(nameof(RAD_MS)); }

        }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/MedicalData.xsd")]
    public partial class MedicalDataViewPosition : ObservableObject, IDataErrorInfo
    {
        private int _iDViewPositionField;
        public int iDViewPositionField
        {
            get
            {
                return _iDViewPositionField;
            }
            set
            {
                _iDViewPositionField = value;
                OnPropertyChanged(nameof(iDViewPositionField));
            }
        }
        private string _codingSchemaField;
        public string codingSchemaField
        {
            get
            {
                return _codingSchemaField;
            }
            set
            {
                _codingSchemaField = value;
                OnPropertyChanged(nameof(codingSchemaField));
            }
        }

        private string _schemaVersionField;
        public string schemaVersionField
        {
            get
            {
                return _schemaVersionField;
            }
            set
            {
                _schemaVersionField = value;
                OnPropertyChanged(nameof(schemaVersionField));
            }
        }

        private string _codeValueField;
        public string codeValueField
        {
            get
            {
                return _codeValueField;
            }
            set
            {
                _codeValueField = value;
                OnPropertyChanged(nameof(codeValueField));
            }
        }

        private string _descriptionField;
        public string descriptionField
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
                OnPropertyChanged(nameof(descriptionField));
            }
        }
        private string _viewPositionField;
        public string viewPositionField
        {
            get
            {
                return _viewPositionField;
            }
            set
            {
                _viewPositionField = value;
                OnPropertyChanged(nameof(viewPositionField));
            }
        }

        private int _iDAnatomicRegionTableDefinitionField;
        public int iDAnatomicRegionTableDefinitionField
        {
            get
            {
                return _iDAnatomicRegionTableDefinitionField;
            }
            set
            {
                _iDAnatomicRegionTableDefinitionField = value;
                OnPropertyChanged(nameof(iDAnatomicRegionTableDefinitionField));
            }
        }

        //private int iDViewPositionField;

        //private string codingSchemaField;

        //private string schemaVersionField;

        //private string codeValueField;

        //private string descriptionField;

        //private string viewPositionField;

        //private int iDAnatomicRegionTableDefinitionField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MedicalDataViewPosition()
        {
            this.codingSchemaField = "";
            this.schemaVersionField = "1.0.0";
            this.codeValueField = "";
            this.descriptionField = "";
            this.viewPositionField = "";
        }
        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {

                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }
                return error.Length == 0 ? null : error.ToString();
            }
        }
        public string this[string name]
        {
            get
            {
                string result = null;


                if (name == "IDAnatomicRegionTableDefinition")
                {
                    if (this.iDAnatomicRegionTableDefinitionField == 0)
                    {
                        result = "Select Anatomic Region Table Definition";
                    }
                }
                if (name == "ViewPosition")
                {
                    if (string.IsNullOrEmpty(this.viewPositionField))
                    {
                        result = "ViewPosition cannot be empty";
                    }
                }
                return result;
            }
        }

        /// <remarks/>
        public int IDViewPosition
        {
            get
            {
                return this.iDViewPositionField;
            }
            set
            {
                this.iDViewPositionField = value;
            }
        }

        /// <remarks/>
        public string CodingSchema
        {
            get
            {
                return this.codingSchemaField;
            }
            set
            {
                this.codingSchemaField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute("1.0.0")]
        public string SchemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public string ViewPosition
        {
            get
            {
                return this.viewPositionField;
            }
            set
            {
                this.viewPositionField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        public int IDAnatomicRegionTableDefinition
        {
            get
            {
                return this.iDAnatomicRegionTableDefinitionField;
            }
            set
            {
                this.iDAnatomicRegionTableDefinitionField = value;
                OnPropertyChanged();
            }
        }

    }

    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
