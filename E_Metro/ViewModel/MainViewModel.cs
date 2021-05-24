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
        public ICommand LoadSearchCommand { get; set; }

        public ICommand LoadAddCommand { get; set; }

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
            LoadSearchCommand = new RelayCommand<object>((p) => { return true; }, (p) => { SearchWindow wd = new SearchWindow(); wd.ShowDialog(); });
            LoadAddCommand = new RelayCommand<object>((p) => { return true; }, (p) => { AddWindow wd = new AddWindow(); wd.ShowDialog(); });
        }
    }
}
