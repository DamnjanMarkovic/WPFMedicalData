using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using WPFMedicalDataGrid.ViewModels;

namespace WPFMedicalDataGrid.Commands
{
    public class FilterCommand : ICommand
    {
        /// <summary>
        /// This dictionary will have a list of all applied filters
        /// </summary>
        private Dictionary<string, FilterValueCondition> _columnFilters;
        /// <summary>
        /// Cache with properties for better performance
        /// </summary>
        private Dictionary<Type, Dictionary<string, PropertyInfo>> _propertyCache;
        private ListCollectionView _collectionView;


        public event EventHandler CanExecuteChanged;

        private MainViewModel _viewModel;

        public FilterCommand(MainViewModel viewModel, ListCollectionView collectionView)
        {
            _viewModel = viewModel;
            _collectionView = collectionView;
            _columnFilters = new Dictionary<string, FilterValueCondition>();
            _propertyCache = new Dictionary<Type, Dictionary<string, PropertyInfo>>();
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Control controlArrived = parameter as Control;
            DataGridColumnHeader header =
                TryFindParent<DataGridColumnHeader>(controlArrived);
            if (header != null)
            {
                UpdateFilter(controlArrived, header);
                Filter();
            }
        }

        /// <summary>
        /// Update filter rules
        /// </summary>
        /// <param name="control"></param>
        /// <param name="header"></param>
        private void UpdateFilter(Control control, DataGridColumnHeader header)
        {
            // Try to get the property bound to the column.
            // This should be stored as datacontext.

            //Get parent Bidning from header (inside header)
            string columnBinding = header.Column.SortMemberPath;
            //string childBinding = header.Column;
            FilterValueCondition filterCondition = new FilterValueCondition();
            if (control is TextBox)
            {
                filterCondition.value = ((TextBox)control).Text;
                filterCondition.compareLevel = CompareLevel.Contains;
            }
            else if (control is CheckBox)
            {
                filterCondition.value = ((CheckBox)control).IsChecked;
                filterCondition.compareLevel = CompareLevel.BoolCompare;
            }
            else if (control is ComboBox)
            {
                //Get child binding from header
                if (((ComboBox)control).SelectedItem != null)
                {
                    DataGridComboBoxColumn cbCol = (DataGridComboBoxColumn)header.Column;
                    filterCondition.value = GetPropertyValue(((ComboBox)control).SelectedItem, cbCol.SelectedValuePath);
                    filterCondition.compareLevel = CompareLevel.Equals;
                }
            }


            // Set the filter 
            if (!String.IsNullOrEmpty(columnBinding))
                _columnFilters[columnBinding] = filterCondition;
        }

        public class FilterValueCondition
        {
            public object value;
            public CompareLevel compareLevel;
        }

        public enum CompareLevel
        {
            Equals,
            Contains,
            BoolCompare
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        private object GetPropertyValue(object item, string property)
        {
            // No value
            object value = null;
            Type TType = item.GetType();
            // Get property  from cache
            PropertyInfo pi = null;
            Dictionary<string, PropertyInfo> cache;
            if (!_propertyCache.ContainsKey(TType))
            {
                _propertyCache.Add(TType, cache = new Dictionary<string, PropertyInfo>());
            }
            else
            {
                cache = _propertyCache[TType];
            }
            if (cache.ContainsKey(property))
                pi = cache[property];
            else
            {
                pi = item.GetType().GetProperty(property);
                cache.Add(property, pi);
            }
            // If we have a valid property, get the value
            if (pi != null)
                value = pi.GetValue(item, null);
            // Done
            return value;
        }

        /// <summary>
        /// Apply filter to data grid
        /// </summary>
        private void Filter()
        {
            if (_collectionView != null)
            {
                //Template.FindName("tbox_a", dataGrid.Columns[0]);
                try
                {
                    _collectionView.Filter = delegate (object item)
                    {
                        // Show the current object
                        bool show = true;
                        // Loop filters
                        foreach (KeyValuePair<string, FilterValueCondition> filter in _columnFilters)
                        {
                            object property = GetPropertyValue(item, filter.Key);
                            if (property != null)
                            {
                                // Check if the current column contains a filter
                                bool containsFilter = false;
                                switch (filter.Value.compareLevel)
                                {
                                    case CompareLevel.Contains:
                                        {
                                            containsFilter = property.ToString().ToLower().Contains(filter.Value.value.ToString().ToLower());
                                            break;
                                        }
                                    case CompareLevel.BoolCompare:
                                        {
                                            containsFilter = (filter.Value.value == null || (bool)property == (bool)filter.Value.value);
                                            break;
                                        }
                                    case CompareLevel.Equals:
                                        {
                                            containsFilter = (filter.Value.value == null ||
                                                                filter.Value.value.ToString().Equals(string.Empty) ||
                                                                property.ToString().Equals(filter.Value.value.ToString()));
                                            break;
                                        }
                                }
                                // Do the necessary things if the filter is not correct
                                if (!containsFilter)
                                {
                                    show = false;
                                    break;
                                }
                            }
                        }
                        // Return if it's visible or not
                        return show;
                    };
                }
                catch (InvalidOperationException ex)
                {
                }

            }
        }




        /// <summary>
        /// Finds a parent of a given item on the visual tree.
        /// </summary>
        /// <typeparam name="T">The type of the queried item.</typeparam>
        /// <param name="child">A direct or indirect
        /// child of the queried item.</param>
        /// <returns>The first parent item that matches the submitted
        /// type parameter. If not matching item can be found,
        /// a null reference is being returned.</returns>
        public static T TryFindParent<T>(DependencyObject child)
          where T : DependencyObject
        {
            //get parent item
            DependencyObject parentObject = GetParentObject(child);
            //we've reached the end of the tree
            if (parentObject == null) return null;
            //check if the parent matches the type we're looking for
            T parent = parentObject as T;
            if (parent != null)
            {
                return parent;
            }
            else
            {
                //use recursion to proceed with next level
                return TryFindParent<T>(parentObject);
            }
        }

        /// <summary>
        /// This method is an alternative to WPF's
        /// <see cref="VisualTreeHelper.GetParent"/> method, which also
        /// supports content elements. Do note, that for content element,
        /// this method falls back to the logical tree of the element.
        /// </summary>
        /// <param name="child">The item to be processed.</param>
        /// <returns>The submitted item's parent, if available. Otherwise null.</returns>
        public static DependencyObject GetParentObject(DependencyObject child)
        {
            if (child == null) return null;
            ContentElement contentElement = child as ContentElement;
            if (contentElement != null)
            {
                DependencyObject parent = ContentOperations.GetParent(contentElement);
                if (parent != null) return parent;
                FrameworkContentElement fce = contentElement as FrameworkContentElement;
                return fce != null ? fce.Parent : null;
            }
            // If it's not a ContentElement, rely on VisualTreeHelper
            return VisualTreeHelper.GetParent(child);
        }


    }
}
