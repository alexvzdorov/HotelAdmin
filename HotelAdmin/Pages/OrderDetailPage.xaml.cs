﻿using HotelAdmin.Models;
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

namespace HotelAdmin.Pages
{
    /// <summary>
    /// Interaction logic for OrderDetailPage.xaml
    /// </summary>
    public partial class OrderDetailPage : Page
    {
        private Guest _guest;
        public OrderDetailPage()
        {
            InitializeComponent();
        }

        public OrderDetailPage(Guest guest)
        {
            _guest = guest;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.AddCardPage);
        }
    }
}
