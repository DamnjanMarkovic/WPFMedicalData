using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class MenuDelete : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel _viewModel;

        public MenuDelete(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        List<int> deletedIds = new List<int>();
        public List<object> objForDelete = new List<object>();

        public void Execute(object parameter)
        {

            BaseView view = _viewModel.NavigationViewModel.CurrentViewModel as BaseView;
            DataGrid dataGridView = StaticProperties.GetChildOfType<DataGrid>(view);
            MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete the selection ?", "Message", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes && _viewModel.MedicalDataListResult != null)
            {
                switch (view)
                {
                    case PositionView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();
                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataViewPosition)
                                objForDelete.Add(item);
                        }

                        foreach (MedicalDataViewPosition selectedItem in objForDelete)
                        {
                            deletedIds.Add(selectedItem.IDViewPosition);
                            _viewModel.MedicalDataListResult.ViewPosition.Remove(selectedItem);
                        }

                        foreach (MedicalDataProgram element in _viewModel.MedicalDataListResult.Program)
                        {
                            if (deletedIds.Contains(element.IdViewPosition))
                            {
                                element.IdViewPosition = 0;
                            }
                        }
                        break;

                    case PatientSizeView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();

                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataPatientSize)
                                objForDelete.Add(item);
                        }
                        foreach (MedicalDataPatientSize item in objForDelete)
                        {
                            deletedIds.Add(item.IDPatientSize);
                            _viewModel.MedicalDataListResult.PatientSize.Remove(item);
                        }

                        foreach (MedicalDataTechnique item in _viewModel.MedicalDataListResult.Technique)
                        {
                            if (deletedIds.Contains(item.IdPatientSize))
                            {
                                item.IdPatientSize = 0;
                            }
                        }
                        break;
                    case ProcedureView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();

                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataProcedure)
                                objForDelete.Add(item);
                        }
                        foreach (MedicalDataProcedure item in objForDelete)
                        {
                            deletedIds.Add(item.IDProcedure);
                            _viewModel.MedicalDataListResult.Procedure.Remove(item);
                        }

                        foreach (MedicalDataProcedureProgram item in _viewModel.MedicalDataListResult.ProcedureProgram)
                        {
                            if (deletedIds.Contains(item.IdProcedure))
                            {
                                item.IdProcedure = 0;
                            }
                        }
                        break;

                    case ProcedureProgramView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();

                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataProcedureProgram)
                                objForDelete.Add(item);
                        }
                        foreach (MedicalDataProcedureProgram item in objForDelete)
                        {
                            _viewModel.MedicalDataListResult.ProcedureProgram.Remove(item);
                        }
                        break;

                    case ProgramView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();

                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataProgram)
                                objForDelete.Add(item);
                        }
                        foreach (MedicalDataProgram item in objForDelete)
                        {
                            deletedIds.Add(item.IDProgram);
                            _viewModel.MedicalDataListResult.Program.Remove(item);
                        }

                        foreach (MedicalDataProcedureProgram item in _viewModel.MedicalDataListResult.ProcedureProgram)
                        {
                            if (deletedIds.Contains(item.IdProgram))
                            {
                                item.IdProgram = 0;
                            }
                        }
                        foreach (MedicalDataTechnique item in _viewModel.MedicalDataListResult.Technique)
                        {
                            if (deletedIds.Contains(item.IdProgram))
                            {
                                item.IdProgram = 0;
                            }
                        }
                        break;

                    case TechniqueView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();

                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataTechnique)
                                objForDelete.Add(item);
                        }
                        foreach (MedicalDataTechnique item in objForDelete)
                        {
                            _viewModel.MedicalDataListResult.Technique.Remove(item);
                        }
                        break;
                    case StandPositionView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();

                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataStandPosition)
                                objForDelete.Add(item);
                        }
                        foreach (MedicalDataStandPosition item in objForDelete)
                        {
                            _viewModel.MedicalDataListResult.StandPosition.Remove(item);
                        }
                        break;

                    case FilterView currentView:

                        deletedIds = new List<int>();
                        objForDelete = new List<object>();

                        foreach (var item in dataGridView.SelectedItems)
                        {
                            if (item is MedicalDataFilter)
                                objForDelete.Add(item);
                        }
                        foreach (MedicalDataFilter item in objForDelete)
                        {
                            deletedIds.Add(item.IDFilter);
                            _viewModel.MedicalDataListResult.Filter.Remove(item);
                        }

                        foreach (MedicalDataTechnique item in _viewModel.MedicalDataListResult.Technique)
                        {
                            if (deletedIds.Contains((int)item.IdFilter_FL))
                            {
                                item.IdFilter_FL = 0;
                            }
                            if (deletedIds.Contains((int)item.IdFilter_RAD))
                            {
                                item.IdFilter_RAD = 0;
                            }
                        }
                        break;
                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("You have not selected anything to delete. Select the row or rows you want to delete.", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

        }

    }
}
