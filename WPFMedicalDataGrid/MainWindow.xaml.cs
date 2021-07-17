using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Windows.Input;

namespace WPFMedicalDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            InitializeConfiguration();
            this.Left = 1920 * 2;
        }


        private void InitializeConfiguration()
        {
            //Avanse.Core5.Base.Utils.Configuration.InitializeConfig();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }
    }
}
