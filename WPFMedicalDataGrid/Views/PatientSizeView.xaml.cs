using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFMedicalDataGrid.Model;
using WPFMedicalDataGrid.ViewModels;

namespace WPFMedicalDataGrid.Views
{
    /// <summary>
    /// Interaction logic for PatientSizeView.xaml
    /// </summary>
    public partial class PatientSizeView : BaseView
    {

        public PatientSizeView()
        {
            InitializeComponent();
            ViewName = ViewTypes.Patient_Size.ToString();
        }


        private void tbox_a_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox control = e.OriginalSource as TextBox;
            if (FilterFunction != null)
                FilterFunction.Execute(control);
        }

        private void cmb_b_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox control = e.OriginalSource as ComboBox;
            if (FilterFunction != null)
                FilterFunction.Execute(control);
        }

        private void Row_Click(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (RowEditEndingFunction != null)
                RowEditEndingFunction.Execute(e);
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dataContext = DataContext as MainViewModel;
            if (dataContext.MedicalDataListResult != null)
            {
                collectionView = (ListCollectionView)(CollectionViewSource.GetDefaultView(dataContext.MedicalDataListResult.PatientSize));
                dataContext.MedicalDataListResult.PatientSize.CollectionChanged += CollectionChanged;
                SetNumberOfRows(dataContext.MedicalDataListResult.PatientSize);
                RowEditEndingFunction = dataContext.RowEditEndingFunction(this);
                FilterFunction = dataContext.FilterFunction(this, collectionView);
            }
            Loaded -= UserControl_Loaded;
        }

        private void SetNumberOfRows(ObservableCollection<MedicalDataPatientSize> collectionSending)
        {
            NumberOfRowsShowing = 0;
            foreach (var item in collectionSending)
            {
                if (item.ToString() != "{NewItemPlaceholder}")

                    NumberOfRowsShowing += 1;
            }
        }

        private void CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ObservableCollection<MedicalDataPatientSize> collectionSending = sender as ObservableCollection<MedicalDataPatientSize>;
            SetNumberOfRows(collectionSending);
        }
    }
}
