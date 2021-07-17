using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFMedicalDataGrid.Helpers;
using WPFMedicalDataGrid.ViewModels;

namespace WPFMedicalDataGrid.Commands
{
    public class MenuSaveAs : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private MainViewModel _viewModel;

        public MenuSaveAs(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "MedicalData"; // Default file name
            dlg.DefaultExt = ".xml"; // Default file extension
            dlg.Filter = "Xml documents (.xml)|*.xml"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string fileName = dlg.FileName;
                StaticProperties.Save(fileName, _viewModel.MedicalDataListResult);
                MessageBox.Show("Data saved successfully", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Error. Data is not saved", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
