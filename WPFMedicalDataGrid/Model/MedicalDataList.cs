using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Windows.Data;

namespace WPFMedicalDataGrid.Model
{
    [XmlInclude(typeof(MedicalDataAnatomicRegionTableDefinition))]
    [XmlInclude(typeof(MedicalDataSpecies))]
    [XmlInclude(typeof(MedicalDataAvanseHumanBodyPart))]
    [XmlInclude(typeof(MedicalDataAnatomicRegion))]
    [XmlInclude(typeof(MedicalDataViewPosition))]
    [XmlInclude(typeof(MedicalDataPatientSize))]
    [XmlInclude(typeof(MedicalDataApplicationMode))]
    [XmlInclude(typeof(MedicalDataProcedure))]
    [XmlInclude(typeof(MedicalDataProcedureProgram))]
    [XmlInclude(typeof(MedicalDataProgram))]
    [XmlInclude(typeof(MedicalDataTechnique))]
    [XmlInclude(typeof(MedicalDataStandPosition))]
    [XmlInclude(typeof(MedicalDataFilter))]
    [Serializable]
    [XmlRoot(ElementName = "MedicalData")]
    public class MedicalDataList : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [XmlArray("anatomicRegionTableDefinition")]
        [XmlArrayItem("r")]
        public ObservableCollection<MedicalDataAnatomicRegionTableDefinition> AnatomicRegionTableDefinition { get; set; } = new ObservableCollection<MedicalDataAnatomicRegionTableDefinition>();

        [XmlArray("species")]
        [XmlArrayItem("s")]
        public ObservableCollection<MedicalDataSpecies> Species = new ObservableCollection<MedicalDataSpecies>();

        [XmlArray("bodyPart")]
        [XmlArrayItem("bp")]
        public ObservableCollection<MedicalDataAvanseHumanBodyPart> AvanseHumanBodyPart { get; set; } = new ObservableCollection<MedicalDataAvanseHumanBodyPart>();

        [XmlArray("anatomicRegion")]
        [XmlArrayItem("ar")]
        public ObservableCollection<MedicalDataAnatomicRegion> AnatomicRegion { get; set; } = new ObservableCollection<MedicalDataAnatomicRegion>();

        [XmlArray("viewPosition")]
        [XmlArrayItem("vp")]
        public ObservableCollection<MedicalDataViewPosition> ViewPosition { get; set; } = new ObservableCollection<MedicalDataViewPosition>();

        [XmlArray("patientSize")]
        [XmlArrayItem("ps")]
        public ObservableCollection<MedicalDataPatientSize> PatientSize { get; set; } = new ObservableCollection<MedicalDataPatientSize>();

        [XmlArray("applicationMode")]
        [XmlArrayItem("am")]
        public ObservableCollection<MedicalDataApplicationMode> ApplicationMode { get; set; } = new ObservableCollection<MedicalDataApplicationMode>();

        [XmlArray("procedure")]
        [XmlArrayItem("p")]
        public ObservableCollection<MedicalDataProcedure> Procedure { get; set; } = new ObservableCollection<MedicalDataProcedure>();

        [XmlArray("procedureProgram")]
        [XmlArrayItem("pp")]
        public ObservableCollection<MedicalDataProcedureProgram> ProcedureProgram { get; set; } = new ObservableCollection<MedicalDataProcedureProgram>();

        [XmlArray("program")]
        [XmlArrayItem("pr")]
        public ObservableCollection<MedicalDataProgram> Program { get; set; } = new ObservableCollection<MedicalDataProgram>();

        [XmlArray("technique")]
        [XmlArrayItem("t")]
        public ObservableCollection<MedicalDataTechnique> Technique { get; set; } = new ObservableCollection<MedicalDataTechnique>();

        [XmlArray("standPosition")]
        [XmlArrayItem("sp")]
        public ObservableCollection<MedicalDataStandPosition> StandPosition { get; set; } = new ObservableCollection<MedicalDataStandPosition>();

        [XmlArray("filter")]
        [XmlArrayItem("f")]
        public ObservableCollection<MedicalDataFilter> Filter { get; set; } = new ObservableCollection<MedicalDataFilter>();


        public MedicalDataList()
        {

        }
    }
}
