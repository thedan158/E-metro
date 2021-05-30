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
    /// Interaction logic for CompanyWindow.xaml
    /// </summary>
    public partial class CompanyWindow : Window
    {

        public CompanyWindow()
        {
            InitializeComponent();

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow wd = new SearchWindow();
            wd.ShowDialog();
        }

       
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow wd = new AddWindow();
            wd.ShowDialog();
        }


    }
}
