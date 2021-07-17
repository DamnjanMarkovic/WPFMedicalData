using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WPFMedicalDataGrid.Commands;
using WPFMedicalDataGrid.Views;

namespace WPFMedicalDataGrid.ViewModels
{
    public class NavigationViewModel : ObservableObject
    {

        private ICommand _updateCurrentViewModelCommand;
        public ICommand UpdateCurrentViewModelCommand
        {
            get
            {
                if (_updateCurrentViewModelCommand == null)
                {
                    _updateCurrentViewModelCommand = new RelayCommand(
                        p => ChangeViewModel((BaseView)p),
                        p => p is BaseView);
                }

                return _updateCurrentViewModelCommand;
            }
        }

        private BaseView _currentViewModel;
        public BaseView CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        private List<BaseView> _views;
        public List<BaseView> Views
        {
            get
            {
                if (_views == null)
                    _views = new List<BaseView>();
                return _views;
            }
        }

        public NavigationViewModel()
        {
            AddViewModelsToList();
            CurrentViewModel = Views[0];
        }

        private void AddViewModelsToList()
        {
            Views.Add(new PositionView());
            Views.Add(new PatientSizeView());
            Views.Add(new ProcedureView());
            Views.Add(new ProcedureProgramView());
            Views.Add(new ProgramView());
            Views.Add(new TechniqueView());
            Views.Add(new StandPositionView());
            Views.Add(new FilterView());
        }


        private void ChangeViewModel(BaseView view)
        {
            if (!Views.Contains(view))
                Views.Add(view);

            MenuResetFilters resetCommand = new MenuResetFilters(this);
            resetCommand.Execute(this);

            CurrentViewModel = Views
                .FirstOrDefault(vm => vm == view);
        }

        private bool CanSubmitExecute(object parameter)
        {
            return true;
        }


    }
}
