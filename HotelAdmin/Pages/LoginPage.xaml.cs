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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelAdmin.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.MainPage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBoxLogin.Text == "Admin" && textBoxPass.Password == "12345")
            {
                NavigationService.Navigate(PageControl.AdminPage);
            }
            else
                MessageBox.Show("Неправильный логин или пароль.");
        }
    }
}
