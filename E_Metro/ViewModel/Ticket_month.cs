using E_Metro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Metro.ViewModel
{
    class Ticket_month : BaseViewModel
    {
        private ObservableCollection<MonthlyTicket> _MonthList;
        public ObservableCollection<MonthlyTicket> MonthList { get => _MonthList; set { _MonthList = value; OnPropertyChanged(); } }
        public Ticket_month()
        {
            _MonthList = new ObservableCollection<MonthlyTicket>(DataProvider.Ins.DB.MonthlyTickets);
        }


    }
}
