using HotelAdmin.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace HotelAdmin.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private bool _inSearch = false;
        public MainPage()
        {
            InitializeComponent();

            listView.ItemsSource = Storage.Instance.Rooms;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.LoginPage);
        }

        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new AboutRoomPage(listView.SelectedItem as Room));
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            if (_inSearch)
            {
                listView.ItemsSource = Storage.Instance.Rooms;
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(@"..\..\Images/search.PNG", UriKind.Relative);
                bi3.EndInit();
                searchIcon.Source = bi3;

                _inSearch = false;
            }
            else
            {
                try
                {
                    var price = int.Parse(textBoxPrice.Text);
                    listView.ItemsSource = Storage.Instance.Rooms.Where(r => r.Price < price);
                    Image myImage3 = new Image();
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri(@"..\..\Images\close.png", UriKind.Relative);
                    bi3.EndInit();
                    searchIcon.Source = bi3;

                    _inSearch = true;
                }
                catch
                {
                    MessageBox.Show("Введите число!");
                }
            }
        }
    }
}
