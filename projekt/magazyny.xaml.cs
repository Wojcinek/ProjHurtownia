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

namespace projekt
{
    /// <summary>
    /// Interaction logic for Mag.xaml
    /// </summary>
    public partial class Mag : Window
    {
        hurtowniaEntities baza = new hurtowniaEntities();

        public Mag()
        {
            InitializeComponent();
            MagazynyTabela.ItemsSource = baza.Magazyny.ToList();
        }

        private void Magazyn_dodaj(object sender, RoutedEventArgs e)
        {
            Magazyny mag = new Magazyny()
            {
               nazwa = NazwaText.Text,
               adres = AdresText.Text
            };

            baza.Magazyny.Add(mag);
            try
            {
                baza.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Nie można dodać");
            }
            MagazynyTabela.ItemsSource = baza.Magazyny.ToList();
       }

        private void main_click(object sender, RoutedEventArgs e)
        {
            MainWindow tb = new MainWindow();
            tb.Show();
            this.Close();
        }

        private void usun_click(object sender, RoutedEventArgs e)
        {
            if(MagazynyTabela.SelectedValue != null) 
            { 
            var magazyn = baza.Magazyny.FirstOrDefault(m => m.id_magazynu == ((Magazyny)MagazynyTabela.SelectedValue).id_magazynu);
            baza.Magazyny.Remove(magazyn);
            baza.SaveChanges();
            MagazynyTabela.ItemsSource = baza.Magazyny.ToList();
            }
        }

        private void zapisz_click(object sender, RoutedEventArgs e)
        {
            Magazyny mag = new Magazyny();
            try
            {
                baza.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Nie można zapisać");
            }
        }
    }
}
