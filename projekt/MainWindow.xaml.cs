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

namespace projekt
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

        private void magazyn_Click(object sender, RoutedEventArgs e)
        {
            Mag tb = new Mag();
            tb.Show();
            this.Close();
        }

        private void zamowienie_Click(object sender, RoutedEventArgs e)
        {
            zamowienia tb = new zamowienia();
            tb.Show();
            this.Close();

        }
        private void produkt_Click(object sender, RoutedEventArgs e)
        {
            produkty tb = new produkty();
            tb.Show();
            this.Close();
        }
        private void klient_Click(object sender, RoutedEventArgs e)
        {
            klienci tb = new klienci();
            tb.Show();
            this.Close();
        }
        
    }
}
