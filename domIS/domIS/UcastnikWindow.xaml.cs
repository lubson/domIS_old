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

        public Ucastnik Ucastnik;
        private UnitOfWork uow;
        private UcastniciRepository ucastniciRepository;

        public UcastnikWindow(Ucastnik ucastnik)
        {
            InitializeComponent();
            Ucastnik = ucastnik;
            uow = new UnitOfWork();
            ucastniciRepository = new UcastniciRepository();
        }

        private void SaveUcastnik(object sender, RoutedEventArgs e)
        {
                Ucastnik.Jmeno = jmenoTextBox.Text;
                Ucastnik.Prijmeni = prijmeniTextBox.Text;
                Ucastnik.Narozen = (DateTime)narozenDatePicker.SelectedDate;
                if ((bool)pohlaviRadioButton.IsChecked)
                    Ucastnik.Pohlavi = Pohlavi.muzske;
                else
                    Ucastnik.Pohlavi = Pohlavi.zenske;
                            
                ucastniciRepository.InsertOrUpdate(Ucastnik);

                uow.Save();
                uow.Dispose();
                Close();
            }
   

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            //mozna zbytecne objevilo se tady, kdyz jsem pridal source pro ucastnika
            System.Windows.Data.CollectionViewSource ucastnikViewSource = 
                ((System.Windows.Data.CollectionViewSource)(this.FindResource("ucastnikViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // ucastnikViewSource.Source = [generic data source]
          
            
            
        }

        
    }
}
