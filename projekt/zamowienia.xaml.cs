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
    /// Interaction logic for zamowienia.xaml
    /// </summary>
    public partial class zamowienia : Window
    {
        hurtowniaEntities baza = new hurtowniaEntities();
        public zamowienia()
        {
            InitializeComponent();
            ZamowieniaTabela.ItemsSource = baza.Zamowienia_klientow.ToList();
        }
    }
}
