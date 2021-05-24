using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace E_Metro.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand TicketWindowCommand { get; set; }
        public ICommand CompanyWindowCommand { get; set; }

        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                Isloaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
              );
            //load window khi nhấn 1 nút nào đấy 
            TicketWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => { Banve wd = new Banve(); wd.ShowDialog(); });
            CompanyWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => { CompanyWindow wd = new CompanyWindow(); wd.ShowDialog(); });
        }
    }
}
