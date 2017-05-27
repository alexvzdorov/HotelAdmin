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
                var r = new Reservation
                {
                    Room = _room,
                    Guest = _guest,
                    StartPeriod = (DateTime)datePickerStart.SelectedDate,
                    EndPeriod = (DateTime)datePickerEnd.SelectedDate,
                };
                Storage.Instance.Reservations.Add(r);
                MessageBox.Show("Номер успешно зарезервирован");
                NavigationService.Navigate(PageControl.AddCardPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
