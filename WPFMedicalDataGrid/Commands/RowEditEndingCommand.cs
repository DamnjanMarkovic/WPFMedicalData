using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPFMedicalDataGrid.Model;
using WPFMedicalDataGrid.ViewModels;
using WPFMedicalDataGrid.Views;

namespace WPFMedicalDataGrid.Commands
{
    public class RowEditEndingCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private BaseView _view;
        private MainViewModel _viewModel;

        public RowEditEndingCommand(BaseView view, MainViewModel viewModel)
        {
            _view = view;
            _viewModel = viewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var e = parameter as DataGridRowEditEndingEventArgs;

            if (e.EditAction == DataGridEditAction.Commit)
            {
                switch (_view)
                {
                    case PositionView view:

                        MedicalDataViewPosition mDViewPosition = e.Row.DataContext as MedicalDataViewPosition;
                        if (mDViewPosition.IDViewPosition == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataViewPosition item in _viewModel.MedicalDataListResult.ViewPosition)
                            {
                                if (item.IDViewPosition > id)
                                {
                                    id = item.IDViewPosition;
                                }
                            }
                            mDViewPosition.IDViewPosition = id + 1;
                        }

                        view.DataChanged = true;
                        break;

                    case PatientSizeView view:

                        MedicalDataPatientSize mDPatientSize = e.Row.DataContext as MedicalDataPatientSize;
                        if (mDPatientSize.IDPatientSize == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataPatientSize item in _viewModel.MedicalDataListResult.PatientSize)
                            {
                                if (item.IDPatientSize > id)
                                {
                                    id = item.IDPatientSize;
                                }
                            }
                            mDPatientSize.IDPatientSize = id + 1;
                        }

                        view.DataChanged = true;
                        break;

                    case ProcedureView view:

                        MedicalDataProcedure mDProcedure = e.Row.DataContext as MedicalDataProcedure;
                        if (mDProcedure.IDProcedure == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataProcedure item in _viewModel.MedicalDataListResult.Procedure)
                            {
                                if (item.IDProcedure > id)
                                {
                                    id = item.IDProcedure;
                                }
                            }
                            mDProcedure.IDProcedure = id + 1;
                        }

                        view.DataChanged = true;
                        break;

                    case ProcedureProgramView view:

                        MedicalDataProcedureProgram mDProcedureProgram = e.Row.DataContext as MedicalDataProcedureProgram;
                        if (mDProcedureProgram.IDProcedureProgram == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataProcedureProgram item in _viewModel.MedicalDataListResult.ProcedureProgram)
                            {
                                if (item.IDProcedureProgram > id)
                                {
                                    id = item.IDProcedureProgram;
                                }
                            }
                            mDProcedureProgram.IDProcedureProgram = id + 1;
                        }

                        view.DataChanged = true;
                        break;

                    case ProgramView view:

                        MedicalDataProgram mDProgram = e.Row.DataContext as MedicalDataProgram;
                        if (mDProgram.IDProgram == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataProgram item in _viewModel.MedicalDataListResult.Program)
                            {
                                if (item.IDProgram > id)
                                {
                                    id = item.IDProgram;
                                }
                            }
                            mDProgram.IDProgram = id + 1;
                        }

                        view.DataChanged = true;
                        break;

                    case TechniqueView view:

                        MedicalDataTechnique mDTechnique = e.Row.DataContext as MedicalDataTechnique;
                        if (mDTechnique.IDTechnique == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataTechnique item in _viewModel.MedicalDataListResult.Technique)
                            {
                                if (item.IDTechnique > id)
                                {
                                    id = item.IDTechnique;
                                }
                            }
                            mDTechnique.IDTechnique = id + 1;
                        }

                        view.DataChanged = true;
                        break;

                    case StandPositionView view:

                        MedicalDataStandPosition mDStandPosition = e.Row.DataContext as MedicalDataStandPosition;
                        if (mDStandPosition.IDStandPosition == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataStandPosition item in _viewModel.MedicalDataListResult.StandPosition)
                            {
                                if (item.IDStandPosition > id)
                                {
                                    id = item.IDStandPosition;
                                }
                            }
                            mDStandPosition.IDStandPosition = id + 1;
                        }

                        view.DataChanged = true;
                        break;

                    case FilterView view:

                        MedicalDataFilter mDFilter = e.Row.DataContext as MedicalDataFilter;
                        if (mDFilter.IDFilter == 0)
                        {
                            int id = 0;
                            foreach (MedicalDataFilter item in _viewModel.MedicalDataListResult.Filter)
                            {
                                if (item.IDFilter > id)
                                {
                                    id = item.IDFilter;
                                }
                            }
                            mDFilter.IDFilter = id + 1;
                        }

                        view.DataChanged = true;
                        break;


                    default:
                        break;
                }
            }
        }
    }
}
