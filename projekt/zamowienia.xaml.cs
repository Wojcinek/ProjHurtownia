﻿using System;
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
            ZamowieniaTabela.ItemsSource = baza.Platnosc.ToList();
        }

        
        private void Zamowienia_dodaj(object sender, RoutedEventArgs e)
        {

        }

        private void main_click(object sender, RoutedEventArgs e)
        {

           MainWindow tb = new MainWindow();
           tb.Show();
           this.Close();

        }
    }
}
