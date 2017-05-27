using HotelAdmin.Models;
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
        private Room _room;
        public OrderDetailPage()
        {
            InitializeComponent();
        }

        public OrderDetailPage(Guest guest, Room room) : this()
        {
            _guest = guest;
            _room = room;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var r = new Reservation(
                    _room,
                    _guest,
                    (DateTime)datePickerStart.SelectedDate,
                    (DateTime)datePickerEnd.SelectedDate,
                    true);
                Storage.Instance.Reservations.Add(r);
                MessageBox.Show("Номер успешно зарезервирован");
                NavigationService.Navigate(PageControl.MainPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textBlockRoom.Text = _room.Number.ToString();
        }

        private void datePickerEnd_CalendarClosed(object sender, RoutedEventArgs e)
        {
            try
            {
                var days =
                    ((DateTime)datePickerEnd.SelectedDate - (DateTime)datePickerStart.SelectedDate).Days;
                textBlockNoches.Text = days.ToString();
                textBlockPrice.Text = (days * _room.Price).ToString();
            }
            catch { }
        }
    }
}
