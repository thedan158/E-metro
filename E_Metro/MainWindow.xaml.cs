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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E_Metro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //http://materialdesigninxaml.net/home
        public MainWindow()
        {
            InitializeComponent();
            List<Train> items = new List<Train>();
            items.Add(new Train() { money = 20000 });
            items.Add(new Train() { money = 50000 });
            items.Add(new Train() { money = 120000 });
            items.Add(new Train() { money = 200000 });
            items.Add(new Train() { money = 250000 });
            items.Add(new Train() { money = 30000 });

            

        }
            
        
    }
    public class Train
    {
        public int money { get; set; }
    }
}
