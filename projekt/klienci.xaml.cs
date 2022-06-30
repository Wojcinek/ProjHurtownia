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
            baza.SaveChanges();
            KlienciTabela.ItemsSource = baza.Klienci.ToList();
        }
    }
}
