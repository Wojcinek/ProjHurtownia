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
    /// Interaction logic for produkty.xaml
    /// </summary>
    public partial class produkty : Window
    {
        hurtowniaEntities baza = new hurtowniaEntities();
        public produkty()
        {
            InitializeComponent();
            ProduktyTabela.ItemsSource = baza.Produkty_Magazyn.ToList();
        }
    }
}


