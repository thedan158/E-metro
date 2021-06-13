using E_Metro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace E_Metro.ViewModel
{
    class Ticket_day : BaseViewModel
    {

        private ObservableCollection<StandarTicket> _DayList;
        public ObservableCollection<StandarTicket> DayList { get => _DayList; set { _DayList = value; OnPropertyChanged(); } }
        //click 

        private int? _RId;
        public int? RId { get => _RId; set { _RId = value; OnPropertyChanged(); } }

        private int? _TId;
        public int? TId { get => _TId; set { _TId = value; OnPropertyChanged(); } }

        private String _TDate;
        public String TDate { get => _TDate; set { _TDate = value; OnPropertyChanged(); } }

        private int? _RGo;
        public int? RGo { get => _RGo; set { _RGo = value; OnPropertyChanged(); } }

        private int? _REnd;
        public int? REnd { get => _REnd; set { _REnd = value; OnPropertyChanged(); } }
        private decimal? _RPrice;
        public decimal? RPrice { get => _RPrice; set { _RPrice = value; OnPropertyChanged(); } }
        private String _THour;
        public String THour { get => _THour; set { _THour = value; OnPropertyChanged(); } }
        private int? _IdT;
        public int? IdT { get => _IdT; set { _IdT = value; OnPropertyChanged(); } }


        private StandarTicket _SelectedItem;
        public StandarTicket SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    RId = SelectedItem.RailwayID;
                    TId = SelectedItem.Id;
                    RGo = SelectedItem.RailWay.DepartureID;
                    REnd = SelectedItem.RailWay.DestinationID;
                    TDate = SelectedItem.DepartDate.ToString();
                    THour = SelectedItem.DepartHour.ToString();
                    RPrice = SelectedItem.RailWay.Price;
                    IdT = SelectedItem.IdType;
                }
            }
        }
        public ICommand Savebtn { get; set; }


        public Ticket_day()
        {

            _DayList = new ObservableCollection<StandarTicket>(DataProvider.Ins.DB.StandarTickets);

            Savebtn = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(THour))
                {
                    return false;

                }

                return true;

            }, (p) =>
            {
                var Sold = new TicketSold() { RailwayID = RId, Id = TId, IdType = IdT };

                DataProvider.Ins.DB.TicketSolds.Add(Sold);
                DataProvider.Ins.DB.SaveChanges();

            });

        }


    }

}
