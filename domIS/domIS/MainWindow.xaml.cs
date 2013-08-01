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
using Data;
using Model;

namespace domIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ucastnikWindow = new UcastnikWindow(new Ucastnik());
            ucastnikWindow.Show();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource ucastnikViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ucastnikViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // ucastnikViewSource.Source = [generic data source]
        }
    }
}
