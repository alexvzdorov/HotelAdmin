using HotelAdmin.Models;
using HotelAdmin.ViewModels;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            var rvm = new RoomViewModel
            {
                Price = "1000 р.",
                Class = Class.Comfort.ToString(),
                Number = "Номер: 314",
                PlaceQty = "Количество мест: 2",
                Picture = @"D:\DEv\VS PROJECTS\HotelAdmin\HotelAdmin\Images\sample.jpg"
            };

            listView.Items.Add(rvm);
            listView.Items.Add(rvm);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.LoginPage);
        }
    }
}
