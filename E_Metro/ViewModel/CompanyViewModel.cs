using E_Metro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Metro.ViewModel
{
    class CompanyViewModel : BaseViewModel
    {
        private ObservableCollection<RailWay> _myList;
        public ObservableCollection<RailWay> myList { get => _myList; set { _myList = value; OnPropertyChanged(); } }
        private ObservableCollection<Station> _staionList;
        public ObservableCollection<Station> staionList { get => _staionList; set { _staionList = value; OnPropertyChanged(); } }

        public string keeper = LoginViewModel.idR;


        public CompanyViewModel()
        {   
            if (!string.IsNullOrEmpty(keeper))
            {
                int code = int.Parse(keeper);

                myList = new ObservableCollection<RailWay>(DataProvider.Ins.DB.RailWays.Where(a => a.OwnedCompanyId == code));
                staionList = new ObservableCollection<Station>(DataProvider.Ins.DB.Stations);
            }
        }
    }
}
