using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFMedicalDataGrid.ViewModels;

namespace WPFMedicalDataGrid.Commands
{
    public class MenuOpen : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private MainViewModel _viewModel;

        public MenuOpen(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {


            string fileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Xml files|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                fileName = openFileDialog.FileName;
                _viewModel.SetMedicalDataList(fileName);
            }
            else
            {
                return;
            }
        }
    }
}
