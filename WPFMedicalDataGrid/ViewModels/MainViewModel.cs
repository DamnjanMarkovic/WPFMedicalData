using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using System.ComponentModel;
using System.Windows.Data;
using WPFMedicalDataGrid.Views;
using WPFMedicalDataGrid.Commands;
using WPFMedicalDataGrid.Model;
using WPFMedicalDataGrid.Helpers;

namespace WPFMedicalDataGrid.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        #region Properties

        double[] mAs = {0.25, 0.27, 0.32, 0.35, 0.4, 0.45, 0.5,
                        0.55, 0.63, 0.7, 0.8, 0.9, 1.0, 1.1, 1.25, 1.4,
                        1.6, 1.8, 2.0, 2.2, 2.5, 2.8, 3.2, 3.6, 4.0, 4.5,
                        5.0, 5.6, 6.3, 7.1, 8.0, 9.0, 10.0, 11.0, 12.5,
                        14.0, 16.0, 18.0, 20.0, 22.0, 25.0, 28.0, 32.0,
                        36.0, 40.0, 45.0, 50.0, 56.0, 63.0, 71.0, 80.0,
                        90.0, 100.0, 110.0, 125.0, 140.0, 160.0, 180.0,
                        200.0, 220.0, 250.0, 280.0, 320.0, 360.0, 400.0, 450.0,
                        500.0, 560.0, 630.0, 710.0, 800.0, 900.0, 1000.0
                        };
        double[] mA =
        {
            10.0,11.0,12.5,14.0,16.0,18.0,20.0,22.0,25.0,28.0,32.0,36.0,40.0,45.0,
            50.0,56.0,63.0,71.0,80.0,90.0,100.0,110.0,125.0,140.0,160.0,180.0,200.0,
            220.0,250.0,280.0,320.0,360.0,400.0,450.0,500.0,560.0,630.0,710.0,
            800.0,900.0,1000.0
        };

        private List<Side> _listSide = new List<Side>();
        public List<Side> ListSide
        {
            get
            {
                return _listSide;
            }
            set
            {
                _listSide = value;
                OnPropertyChanged(nameof(ListSide));
            }
        }

        private List<Laterality> _listLaterality = new List<Laterality>();
        public List<Laterality> ListLaterality
        {
            get
            {
                return _listLaterality;
            }
            set
            {
                _listLaterality = value;
                OnPropertyChanged(nameof(ListLaterality));
            }
        }

        private List<MAS> _listMAS = new List<MAS>();
        public List<MAS> ListMAS
        {
            get
            {
                return _listMAS;
            }
            set
            {
                _listMAS = value;
                OnPropertyChanged(nameof(ListMAS));
            }
        }

        private List<MA> _listMA = new List<MA>();
        public List<MA> ListMA
        {
            get
            {
                return _listMA;
            }
            set
            {
                _listMA = value;
                OnPropertyChanged(nameof(ListMA));
            }
        }

        private List<Fokus> _listFokus = new List<Fokus>();
        public List<Fokus> ListFokus
        {
            get
            {
                return _listFokus;
            }
            set
            {
                _listFokus = value;
                OnPropertyChanged(nameof(ListFokus));
            }
        }

        private MedicalDataList _medicalDataList;
        public MedicalDataList MedicalDataListResult
        {
            get
            {
                return _medicalDataList;
            }
            set
            {
                _medicalDataList = value;
                OnPropertyChanged(nameof(MedicalDataListResult));
            }
        }

        private SolidColorBrush _backgroundColor = Brushes.Wheat;
        public SolidColorBrush BackgroundColor
        {
            get
            {
                return _backgroundColor;
            }
            set
            {
                _backgroundColor = value;
                OnPropertyChanged(nameof(BackgroundColor));
            }
        }

        private string _statusMedicalDataFileName = "XML File Name";
        public string StatusMedicalDataFileName
        {
            get
            {
                return _statusMedicalDataFileName;
            }
            set
            {
                _statusMedicalDataFileName = value;
                OnPropertyChanged(nameof(StatusMedicalDataFileName));
            }

        }

        private string _statusBoxDate = DateTime.Now.ToShortDateString();
        public string StatusBoxDate
        {
            get
            {
                return _statusBoxDate;
            }
            set
            {
                _statusBoxDate = value;
                OnPropertyChanged(nameof(StatusBoxDate));
            }
        }

        private NavigationViewModel _navigationViewModel;
        public NavigationViewModel NavigationViewModel
        {
            get
            {
                return _navigationViewModel;
            }
            set
            {
                _navigationViewModel = value;
                OnPropertyChanged(nameof(NavigationViewModel));
            }
        }

        private int _selectedRowIndex;
        public int SelectedRowIndex
        {
            get
            {
                return _selectedRowIndex;
            }
            set
            {
                _selectedRowIndex = value;
                OnPropertyChanged(nameof(SelectedRowIndex));
            }
        }

        #endregion

        #region Commands

        public ICommand FilterFunction(BaseView viewClicked, ListCollectionView collectionView) => new FilterCommand(this, collectionView);
        public ICommand RowEditEndingFunction(BaseView viewClicked) => new RowEditEndingCommand(viewClicked, this);

        public ICommand MenuOpen => new MenuOpen(this);

        private ICommand _menuSave;
        public ICommand MenuSave
        {
            get
            {
                if (_menuSave == null && !ErrorExists())
                {
                    _menuSave = new MenuSave(this);
                }
                return _menuSave;
            }
        }

        private ICommand _menuSaveAs;
        public ICommand MenuSaveAs
        {
            get
            {
                if (_menuSaveAs == null && !ErrorExists())
                {
                    _menuSaveAs = new MenuSaveAs(this);
                }
                return _menuSaveAs;
            }
        }

        public ICommand MenuDelete => new MenuDelete(this);

        private ICommand _menuCopy;
        public ICommand MenuCopy
        {
            get
            {
                if (_menuCopy == null && !ErrorExists())
                {
                    _menuCopy = new MenuCopy(this);
                }
                return _menuCopy;
            }
        }

        private ICommand _menuResetFilters;
        public ICommand MenuResetFilters
        {
            get
            {
                if (_menuResetFilters == null && !ErrorExists())
                {
                    _menuResetFilters = new MenuResetFilters(NavigationViewModel);
                }
                return _menuResetFilters;
            }
        }


        #endregion







        #region Constructor
        public MainViewModel()
        {
            SetSide();
            SetLaterality();
            SetFokus();
            SetListMAS();
            SetListMA();
            SetMedicalDataList(StaticProperties.MedicalXMLFile);

        }

        #endregion

        #region Functions

        private bool ErrorExists()
        {
            foreach (var view in NavigationViewModel.Views)
            {
                if (view.ErrorExists)
                {
                    MessageBox.Show("Some tables are incorrect!" +
                                    "\nPlease verify that none of the tables have red cells.",
                                    "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return true;
                }
            }
            return false;
        }
        private void SetListMA()
        {
            for (int i = 0; i < mA.Length; i++)
            {
                MA ma = new MA();
                ma.IDmA = i + 1;
                ma.ValuemA = mA[i];
                ListMA.Add(ma);
            }
        }
        private void SetListMAS()
        {
            for (int i = 0; i < mAs.Length; i++)
            {
                MAS mas = new MAS();
                mas.IDmAs = i + 1;
                mas.ValuemAs = mAs[i];
                ListMAS.Add(mas);
            }
        }
        private void SetFokus()
        {
            Fokus f = new Fokus { IDFocus = 0, Member = "Undef", StringValue = "U" };
            Fokus f1 = new Fokus { IDFocus = 1, Member = "Micro", StringValue = "M" };
            Fokus f2 = new Fokus { IDFocus = 2, Member = "Small", StringValue = "S" };
            Fokus f3 = new Fokus { IDFocus = 3, Member = "Large", StringValue = "L" };
            ListFokus = new List<Fokus>() { f, f1, f2, f3 };
        }
        private void SetLaterality()
        {
            Laterality l1 = new Laterality { IDLaterality = 1, Name = "P", Description = "Paired" };
            Laterality l2 = new Laterality { IDLaterality = 2, Name = "U", Description = "UnPaired" };
            Laterality l3 = new Laterality { IDLaterality = 3, Name = "B", Description = "Both" };
            ListLaterality = new List<Laterality>() { l1, l2, l3 };
        }
        private void SetSide()
        {
            Side s0 = new Side { IDSide = 0, Name = null, Description = "" };
            Side s1 = new Side { IDSide = 1, Name = "L", Description = "Left" };
            Side s2 = new Side { IDSide = 2, Name = "R", Description = "Right" };
            ListSide = new List<Side>() { s0, s1, s2 };
        }
        public void SetMedicalDataList(string xmlFile)
        {
            MedicalDataListResult = new MedicalDataList();
            MedicalDataListResult = StaticProperties.Load(xmlFile);

            if (MedicalDataListResult != null)
            {

                foreach (MedicalDataProgram element in MedicalDataListResult.Program)
                {
                    element.Description = SetElementDescription(element, MedicalDataListResult);
                }
            }
            else
            {
                MessageBox.Show("XML file not loaded!");
            }
            NavigationViewModel = new NavigationViewModel();
        }

        private string SetElementDescription(MedicalDataProgram e, MedicalDataList aprList)
        {
            string opisPrograma = "";
            if (e.Laterality == "B")
            {
                var str = from i in aprList.Program
                          join o in aprList.AnatomicRegion on i.IdAnatomicRegion equals o.IDAnatomicRegion
                          join p in aprList.ViewPosition on i.IdViewPosition equals p.IDViewPosition
                          join q in aprList.ApplicationMode on i.IdApplicationMode equals q.IDApplicationMode
                          join l in ListLaterality on i.Laterality equals l.Name
                          select (o.Description + " " + p.Description + " " + "Both" + " " + "(" + q.Name + ")");

                foreach (var item in str)
                {
                    opisPrograma = item;
                }
            }
            else
            {
                var rts = from i in aprList.Program
                          join o in aprList.AnatomicRegion on i.IdAnatomicRegion equals o.IDAnatomicRegion
                          join p in aprList.ViewPosition on i.IdViewPosition equals p.IDViewPosition
                          join q in aprList.ApplicationMode on i.IdApplicationMode equals q.IDApplicationMode
                          join l in ListLaterality on i.Laterality equals l.Name
                          select (o.Description + " " + p.Description + " " + "(" + q.Name + ")");

                foreach (var item in rts)
                {
                    opisPrograma = item;
                }
            }
            return opisPrograma;
        }


        public bool CheckAllErrorsFunc(DataGrid dataGrid)
        {
            foreach (var item in dataGrid.Items)
            {
                DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (row != null)
                {
                    if (Validation.GetHasError(row)) return true;
                }
            }

            return false;
        }


        #endregion

    }
}
