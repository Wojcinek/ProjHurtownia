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
    /// Interaction logic for produkty.xaml
    /// </summary>
    public partial class produkty : Window
    {
        hurtowniaEntities baza = new hurtowniaEntities();
        public produkty()
        {
            InitializeComponent();
            ProduktyTabela.ItemsSource = baza.Produkty.ToList();
        }

        private void Produkty_dodaj(object sender, RoutedEventArgs e)
        {
            Produkty produkt = new Produkty()
            {
                cena = Convert.ToDecimal(CenaText.Text),
                nazwa = NazwaText.Text
            };

            baza.Produkty.Add(produkt);
            baza.SaveChanges();
            ProduktyTabela.ItemsSource = baza.Produkty.ToList();
        }

        private void main_click(object sender, RoutedEventArgs e)
        {
            MainWindow tb = new MainWindow();
            tb.Show();
            this.Close();
        }
    }
}


