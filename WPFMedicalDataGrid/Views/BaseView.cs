﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WPFMedicalDataGrid.ViewModels;

namespace WPFMedicalDataGrid.Views
{
    public class BaseView : UserControl, INotifyPropertyChanged
    {
        public ICommand RowEditEndingFunction
        {
            get { return (ICommand)GetValue(RowEditEndingFunctionProperty); }
            set { SetValue(RowEditEndingFunctionProperty, value); }
        }
        public static readonly DependencyProperty RowEditEndingFunctionProperty =
            DependencyProperty.Register("RowEditEndingFunction", typeof(ICommand), typeof(BaseView), new PropertyMetadata(null));


        public ICommand FilterFunction
        {
            get { return (ICommand)GetValue(FilterFunctionProperty); }
            set { SetValue(FilterFunctionProperty, value); }
        }
        public static readonly DependencyProperty FilterFunctionProperty =
            DependencyProperty.Register("FilterFunction", typeof(ICommand), typeof(BaseView), new PropertyMetadata(null));



        public MainViewModel dataContext { get; set; }
        public ListCollectionView collectionView;


        private int _numberOfRowsShowing;
        public int NumberOfRowsShowing
        {
            get
            {
                return _numberOfRowsShowing;
            }
            set
            {
                _numberOfRowsShowing = value;
                OnPropertyChanged(nameof(NumberOfRowsShowing));
            }
        }


        public string ViewName { get; set; }
        public bool DataChanged { get; set; }


        public bool ErrorExists { get; set; } = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
