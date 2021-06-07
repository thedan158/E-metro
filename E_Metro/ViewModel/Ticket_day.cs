using E_Metro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Metro.ViewModel
{
    class Ticket_day : BaseViewModel
    {
        private ObservableCollection<StandarTicket> _DayList;
        public ObservableCollection<StandarTicket> DayList { get => _DayList;set { _DayList = value; OnPropertyChanged(); } }
        public Ticket_day()
        {
            _DayList = new ObservableCollection<StandarTicket>(DataProvider.Ins.DB.StandarTickets);
        }


    }

}
