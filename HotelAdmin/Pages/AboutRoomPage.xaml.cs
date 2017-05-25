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
    /// Interaction logic for AboutRoomPage.xaml
    /// </summary>
    public partial class AboutRoomPage : Page
    {
        public AboutRoomPage()
        {
            InitializeComponent();

            var arvm = new AboutRoomViewModel
            {
                Class = Class.Comfort.ToString(),
                Description = "Sample Description",
                Number = "Номер: 123",
                Price = "2000 р./сут.",
                PlaceQty = "Количество мест: 2",
                Pictures = new List<string>
                {
                    @"D:\DEv\VS PROJECTS\HotelAdmin\HotelAdmin\Images\sample.jpg",
                    @"D:\DEv\VS PROJECTS\HotelAdmin\HotelAdmin\Images\sample.jpg",
                    @"D:\DEv\VS PROJECTS\HotelAdmin\HotelAdmin\Images\sample.jpg",
                    @"D:\DEv\VS PROJECTS\HotelAdmin\HotelAdmin\Images\sample.jpg",
                }
            };

            DataContext = arvm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.MainPage);
        }
    }
}
