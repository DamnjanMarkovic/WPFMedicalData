using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMedicalDataGrid.Model
{
    public class Side : ObservableCollection<Side>
    {
        public int IDSide { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
