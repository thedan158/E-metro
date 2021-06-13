using E_Metro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Metro.ViewModel
{
    class Sold : BaseViewModel
    {
        private ObservableCollection<TicketSold> _DayList;
        public ObservableCollection<TicketSold> DayList { get => _DayList; set { _DayList = value; OnPropertyChanged(); } }

        private ObservableCollection<MonthlyTicket> _MonthList;
        public ObservableCollection<MonthlyTicket> MonthList { get => _MonthList; set { _MonthList = value; OnPropertyChanged(); } }

        public Sold()
        {

            _DayList = new ObservableCollection<TicketSold>(DataProvider.Ins.DB.TicketSolds);
            _MonthList = new ObservableCollection<MonthlyTicket>(DataProvider.Ins.DB.MonthlyTickets);
        }
    }
}
