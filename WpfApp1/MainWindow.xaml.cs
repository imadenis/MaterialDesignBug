using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }
    }

    internal class MainVM
    {
        public ObservableCollection<string> Items { get; set; }
        public bool UseVWPForCodesList { get; set; } = false;
        public MainVM()
        {
            Items = new ObservableCollection<string>();
            for (int i = 0; i < 1000; i++)
            {
                Items.Add("ListViewItem " + i.ToString());
            }
        }
    }
}
