using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFMedicalDataGrid.Helpers;
using WPFMedicalDataGrid.Model;
using WPFMedicalDataGrid.ViewModels;
using WPFMedicalDataGrid.Views;

namespace WPFMedicalDataGrid.Commands
{
    public class MenuCopy : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private MainViewModel _viewModel;

        public MenuCopy(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        List<int> deletedIds = new List<int>();
        public List<object> objForDelete = new List<object>();
        int id;

        public void Execute(object parameter)
        {
            BaseView view = _viewModel.NavigationViewModel.CurrentViewModel as BaseView;
            DataGrid dataGridView = StaticProperties.GetChildOfType<DataGrid>(view);

            switch (view)
            {
                case PositionView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();
                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataViewPosition y = item as MedicalDataViewPosition;
                        MedicalDataViewPosition vp = new MedicalDataViewPosition();

                        List<int> listIds = new List<int>();

                        foreach (MedicalDataViewPosition m in _viewModel.MedicalDataListResult.ViewPosition)
                        {
                            listIds.Add(m.IDViewPosition);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;
                        if (y == null)
                        {
                            return;
                        }
                        else
                        {
                            vp.IDViewPosition = id + 1;
                            vp.CodingSchema = y.CodingSchema;
                            vp.SchemaVersion = y.SchemaVersion;
                            vp.CodeValue = y.CodeValue;
                            vp.Description = y.Description;
                            vp.ViewPosition = y.ViewPosition;
                            vp.IDAnatomicRegionTableDefinition = y.IDAnatomicRegionTableDefinition;

                            _viewModel.MedicalDataListResult.ViewPosition.Add(vp);
                        }
                    }
                    break;

                case PatientSizeView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();

                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataPatientSize aps = item as MedicalDataPatientSize;

                        List<int> listIds = new List<int>();

                        foreach (MedicalDataPatientSize m in _viewModel.MedicalDataListResult.PatientSize)
                        {
                            listIds.Add(m.IDPatientSize);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;

                        if (aps == null)
                        {
                            return;
                        }
                        else
                        {
                            aps.IDPatientSize = id + 1;
                            aps.Name = aps.Name;
                            aps.MinAgeMonths = aps.MinAgeMonths;
                            aps.MaxAgeMonths = aps.MaxAgeMonths;
                            aps.MinWeightKgs = aps.MinWeightKgs;
                            aps.MaxWeightKgs = aps.MaxWeightKgs;
                            aps.Thumbnail = aps.Thumbnail;

                            _viewModel.MedicalDataListResult.PatientSize.Add(aps);
                        }

                    }
                    break;
                case ProcedureView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();

                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataProcedure aProc = item as MedicalDataProcedure;
                        MedicalDataProcedure proc = new MedicalDataProcedure();


                        List<int> listIds = new List<int>();

                        foreach (MedicalDataProcedure m in _viewModel.MedicalDataListResult.Procedure)
                        {
                            listIds.Add(m.IDProcedure);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;

                        if (aProc == null)
                        {
                            return;
                        }
                        else
                        {
                            proc.IDProcedure = id + 1;
                            proc.CodingSchema = aProc.CodingSchema;
                            proc.SchemaVersion = aProc.SchemaVersion;
                            proc.CodeValue = aProc.CodeValue;
                            proc.Description = aProc.Description;
                            proc.IdAvanseHumanBodyPart = aProc.IdAvanseHumanBodyPart;
                            proc.Side = aProc.Side;
                            proc.Order = aProc.Order;
                            proc.ReadingPhysician = aProc.ReadingPhysician;

                            _viewModel.MedicalDataListResult.Procedure.Add(proc);
                        }
                    }
                    break;

                case ProcedureProgramView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();

                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataProcedureProgram aPP = item as MedicalDataProcedureProgram;
                        MedicalDataProcedureProgram procProg = new MedicalDataProcedureProgram();


                        List<int> listIds = new List<int>();

                        foreach (MedicalDataProcedureProgram m in _viewModel.MedicalDataListResult.ProcedureProgram)
                        {
                            listIds.Add(m.IDProcedureProgram);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;

                        procProg.IDProcedureProgram = id + 1;
                        procProg.IdProcedure = aPP.IdProcedure;
                        procProg.IdProgram = aPP.IdProgram;

                        _viewModel.MedicalDataListResult.ProcedureProgram.Add(procProg);
                    }
                    break;

                case ProgramView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();

                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataProgram aProg = item as MedicalDataProgram;
                        MedicalDataProgram prog = new MedicalDataProgram();


                        List<int> listIds = new List<int>();

                        foreach (MedicalDataProgram m in _viewModel.MedicalDataListResult.Program)
                        {
                            listIds.Add(m.IDProgram);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;

                        if (aProg == null)
                        {
                            return;
                        }
                        else
                        {
                            prog.IDProgram = id + 1;
                            prog.IdAnatomicRegion = aProg.IdAnatomicRegion;
                            prog.IdViewPosition = aProg.IdViewPosition;
                            prog.IdApplicationMode = aProg.IdApplicationMode;
                            prog.Laterality = aProg.Laterality;
                            prog.ExternalMapping = aProg.ExternalMapping;
                            prog.IdSystemWS = aProg.IdSystemWS;
                            prog.Grid = aProg.Grid;
                            prog.RADDetectorMode = aProg.RADDetectorMode;
                            prog.RADFps = aProg.RADFps;
                            prog.RADMaxNFrames = aProg.RADMaxNFrames;
                            prog.RADSequenceDescription = aProg.RADSequenceDescription;
                            prog.FLDetectorMode = aProg.FLDetectorMode;
                            prog.FLFps = aProg.FLFps;
                            prog.FLEnableABC = aProg.FLEnableABC;
                            prog.FLMaxExpTimeSec = aProg.FLMaxExpTimeSec;
                            prog.FLEnableStoreAll = aProg.FLEnableStoreAll;
                            prog.BeamAngle = aProg.BeamAngle;
                            prog.SID = aProg.SID;
                            prog.MaxTotalDose = aProg.MaxTotalDose;
                            prog.MaxTotalDAP = aProg.MaxTotalDAP;
                            prog.EILowerBound = aProg.EILowerBound;
                            prog.EIUpperBound = aProg.EIUpperBound;
                            prog.ScatterToPrimaryRatio = aProg.ScatterToPrimaryRatio;
                            prog.ImageRotation = aProg.ImageRotation;
                            prog.ImageMirror = aProg.ImageMirror;
                            prog.AutoCorp = aProg.AutoCorp;
                            prog.AutoRotate = aProg.AutoRotate;
                            prog.XipAlgo = aProg.XipAlgo;
                            prog.XipGroup = aProg.XipGroup;
                            prog.Active = aProg.Active;
                            prog.ThumbPath = aProg.ThumbPath;
                            prog.Order = aProg.Order;
                            prog.AtlasFilename = aProg.AtlasFilename;
                            prog.Demo = aProg.Demo;


                            _viewModel.MedicalDataListResult.Program.Add(prog);
                        }
                    }
                    break;

                case TechniqueView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();

                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataTechnique y = item as MedicalDataTechnique;
                        MedicalDataTechnique a = new MedicalDataTechnique();


                        List<int> listIds = new List<int>();

                        foreach (MedicalDataTechnique m in _viewModel.MedicalDataListResult.Technique)
                        {
                            listIds.Add(m.IDTechnique);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;
                        if (y == null)
                        {
                            return;
                        }
                        else
                        {
                            a.IDTechnique = id + 1;
                            a.IdProgram = y.IdProgram;
                            a.IdPatientSize = y.IdPatientSize;
                            a.KV = y.KV;
                            a.RAD_MA = y.RAD_MA;
                            a.RAD_Focus = y.RAD_Focus;
                            a.RAD_MAS = y.RAD_MAS;
                            a.IdFilter_RAD = y.IdFilter_RAD;
                            a.AEC = y.AEC;
                            a.BackupMAS = y.BackupMAS;
                            a.Denesity = y.Denesity;
                            a.CollimatorFovX = y.CollimatorFovX;
                            a.CollimatorFovY = y.CollimatorFovY;
                            a.FL_FrameDose = y.FL_FrameDose;
                            a.FL_MA = y.FL_MA;
                            a.FL_MAS = y.FL_MAS;
                            a.FL_Focus = y.FL_Focus;
                            a.IdFilter_FL = y.IdFilter_FL;

                            _viewModel.MedicalDataListResult.Technique.Add(a);
                        }

                    }
                    break;
                case StandPositionView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();

                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataStandPosition y = item as MedicalDataStandPosition;
                        MedicalDataStandPosition a = new MedicalDataStandPosition();


                        List<int> listIds = new List<int>();

                        foreach (MedicalDataStandPosition m in _viewModel.MedicalDataListResult.StandPosition)
                        {
                            listIds.Add(m.IDStandPosition);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;

                        if (y == null)
                        {
                            return;
                        }
                        else
                        {
                            a.IDStandPosition = id + 1;
                            a.Name = y.Name;
                            a.Command = y.Command;
                            a.ActiveDetector = y.ActiveDetector;

                            _viewModel.MedicalDataListResult.StandPosition.Add(a);
                        }
                    }
                    break;

                case FilterView currentView:

                    deletedIds = new List<int>();
                    objForDelete = new List<object>();

                    foreach (var item in dataGridView.SelectedItems)
                    {
                        MedicalDataFilter y = item as MedicalDataFilter;
                        MedicalDataFilter a = new MedicalDataFilter();

                        List<int> listIds = new List<int>();

                        foreach (MedicalDataFilter m in _viewModel.MedicalDataListResult.Filter)
                        {
                            listIds.Add(m.IDFilter);
                        }
                        if (listIds.Count == 0)
                        {
                            id = 0;
                        }

                        int maxValue = int.MinValue;

                        foreach (int t in listIds)
                        {
                            if (t > maxValue)
                            {
                                maxValue = t;
                            }
                        }
                        id = maxValue;

                        if (y == null)
                        {
                            return;
                        }
                        else
                        {
                            a.IDFilter = id + 1;
                            a.Name = y.Name;
                            a.mmAI = y.mmAI;
                            a.mmCu = y.mmCu;
                            a.Code = y.Code;

                            _viewModel.MedicalDataListResult.Filter.Add(a);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
