using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace E_Metro
{
    /// <summary>
    /// Interaction logic for TraffucWindow.xaml
    /// </summary>
    public partial class TraffucWindow : Window
    {
        public TraffucWindow()
        {
            InitializeComponent();
        }

        private void Click_Search1(object sender, RoutedEventArgs e)
        {
            SearchWindowTraffic wd = new SearchWindowTraffic();
            wd.ShowDialog();
        }

        private void Click_Add1(object sender, RoutedEventArgs e)
        {
            AddWindowTraffic wd = new AddWindowTraffic();
            wd.ShowDialog();
        }

        private void Click_Add2(object sender, RoutedEventArgs e)
        {
            AddWindowTraffic1 wd = new AddWindowTraffic1();
            wd.ShowDialog();
        }

        private void Click_Search2(object sender, RoutedEventArgs e)
        {
            SearchWindowTraffic1 wd = new SearchWindowTraffic1();
            wd.ShowDialog();
        }
    }
}
