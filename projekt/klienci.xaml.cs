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
    /// Interaction logic for klienci.xaml
    /// </summary>
    public partial class klienci : Window
    {
        hurtowniaEntities baza = new hurtowniaEntities();
        public klienci()
        {
            InitializeComponent();
            KlienciTabela.ItemsSource = baza.Klienci.ToList();
        }

        private void Klienci_dodaj(object sender, RoutedEventArgs e)
        {
             Klienci klienci = new Klienci()
            {
                Imie = ImieText.Text,
                Nazwisko = NazwiskoText.Text,
                Adres = AdresText.Text,
                Telefon = TelefonText.Text,
                Email = EmailText.Text

            };

            baza.Klienci.Add(klienci);
            try
            {
                baza.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Nie można dodać");
            }
            KlienciTabela.ItemsSource = baza.Klienci.ToList();
        }

        private void main_click(object sender, RoutedEventArgs e)
        {
            MainWindow tb = new MainWindow();
            tb.Show();
            this.Close();
        }

        private void zapisz_click(object sender, RoutedEventArgs e)
        {
            Klienci mag = new Klienci();
            try
            {
                baza.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Nie można zapisać");
            }
        }

        private void usun_click(object sender, RoutedEventArgs e)
        {
            if (KlienciTabela.SelectedValue != null)
            {
                var klienci = baza.Klienci.FirstOrDefault(m => m.id_klienta == ((Klienci)KlienciTabela.SelectedValue).id_klienta);
                baza.Klienci.Remove(klienci);
                baza.SaveChanges();
                KlienciTabela.ItemsSource = baza.Klienci.ToList();
            }
        }
    }
}
