using E_Metro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Metro.ViewModel
{
    class TrafficViewModel : BaseViewModel
    {
        private ObservableCollection<Company> _myList1;
        public ObservableCollection<Company> myList1 { get => _myList1; set { _myList1 = value; OnPropertyChanged(); } }
        private ObservableCollection<Station> _myList2;
        public ObservableCollection<Station> myList2 { get => _myList2; set { _myList2 = value; OnPropertyChanged(); } }

        public TrafficViewModel()
        {
            myList1 = new ObservableCollection<Company>(DataProvider.Ins.DB.Companies);
            myList2 = new ObservableCollection<Station>(DataProvider.Ins.DB.Stations);
        }
    }
}
