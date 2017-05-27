using HotelAdmin.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace HotelAdmin.Pages
{
    /// <summary>
    /// Interaction logic for AboutRoomPage.xaml
    /// </summary>
    public partial class AboutRoomPage : Page
    {
        private Room _room;
        public AboutRoomPage()
        {
            InitializeComponent();
        }
        public AboutRoomPage(Room room) : this()
        {
            _room = room;
            DataContext = _room;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.MainPage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReservePage(_room));
        }
    }
}
