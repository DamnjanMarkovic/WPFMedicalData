using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFMedicalDataGrid.Helpers;
using WPFMedicalDataGrid.ViewModels;

namespace WPFMedicalDataGrid.Commands
{
    public class MenuSave : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel _viewModel;

        public MenuSave(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            MessageBoxResult overwriteOriginalFileResult = new MessageBoxResult();

            overwriteOriginalFileResult = MessageBox.Show($"Do you want to overwrite original file ?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (_viewModel.MedicalDataListResult != null)
            {
                if (overwriteOriginalFileResult == MessageBoxResult.Yes)
                {
                    StaticProperties.Save(StaticProperties.MedicalXMLFile, _viewModel.MedicalDataListResult);
                }

                //ResetDataChanged();
                MessageBox.Show("Data saved successfully", "Message", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Error. Data is not saved", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
