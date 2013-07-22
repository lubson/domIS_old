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
using Model;
using Data;

namespace domIS
{
    /// <summary>
    /// Interaction logic for UcastnikWindow.xaml
    /// </summary>
    public partial class UcastnikWindow : Window
    {

        private UcastniciUnitOfWork uow;
        private UcastnikRepository ucastniciRepository;

        public UcastnikWindow()
        {
            InitializeComponent();
            uow = new UcastniciUnitOfWork();
            ucastniciRepository = new UcastnikRepository(uow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


                Ucastnik ucastnik = new Ucastnik();
                ucastnik.Jmeno = jmenoTextBox.Text;
                ucastnik.Prijmeni = prijmeniTextBox.Text;
                pohlaviComboBox.ItemsSource = Enum.GetValues(typeof(Pohlavi)).Cast<Pohlavi>();
                ucastnik.Narozen = (DateTime)narozenDatePicker.SelectedDate;
                ucastniciRepository.Add(ucastnik);

                uow.Save();
                uow.Dispose();
            }
   

        //mozna zbytecne objevilo se tady, kdyz jsem pridal source pro ucastnika
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource ucastnikViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ucastnikViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // ucastnikViewSource.Source = [generic data source]
        }
        
    }
}
