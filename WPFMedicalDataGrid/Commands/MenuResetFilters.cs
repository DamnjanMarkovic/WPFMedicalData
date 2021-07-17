using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFMedicalDataGrid.Helpers;
using WPFMedicalDataGrid.ViewModels;
using WPFMedicalDataGrid.Views;

namespace WPFMedicalDataGrid.Commands
{
    public class MenuResetFilters : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private NavigationViewModel _navigationViewModel;

        public MenuResetFilters(NavigationViewModel navigationViewModel)
        {
            _navigationViewModel = navigationViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        List<int> deletedIds = new List<int>();
        public List<object> objForDelete = new List<object>();

        public void Execute(object parameter)
        {

            foreach (BaseView view in _navigationViewModel.Views)
            {
                DataGrid dataGrid = StaticProperties.GetChildOfType<DataGrid>(view);

                if (dataGrid != null)
                {

                    foreach (DataGridColumn col in dataGrid.Columns)
                    {
                        UIElement filterElement = ((Panel)col.Header).Children[1];
                        Type TType = filterElement.GetType();
                        if (TType == typeof(TextBox))
                        {
                            ((TextBox)filterElement).Text = "";
                        }
                        else if (TType == typeof(CheckBox))
                        {
                            ((CheckBox)filterElement).IsChecked = null;
                        }
                        else if (TType == typeof(ComboBox))
                        {
                            ((ComboBox)filterElement).SelectedIndex = 0;
                        }
                    }
                }
            }
        }
    }
}
