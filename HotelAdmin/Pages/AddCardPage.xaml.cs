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
    /// Interaction logic for AddCardPage.xaml
    /// </summary>
    public partial class AddCardPage : Page
    {
        private Guest _guest;
        private Room _room;
        public AddCardPage()
        {
            InitializeComponent();
        }

        public AddCardPage(Guest guest, Room room) : this()
        {
            _guest = guest;
            _room = room;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var payment = new Payment
                {
                    CardNumber = textBoxCardNumber.Text,
                    Code = textBoxCVV.Text,
                    Owner = textBoxOwner.Text,
                    TillMonth = int.Parse(textBoxTillMonth.Text),
                    TillYear = int.Parse(textBoxTillYear.Text),
                    CardType = (comboBox.SelectedIndex == 0) ? CardType.Visa : CardType.Mastercard
                };
                _guest.PaymentInfo = payment;
                Storage.Instance.Guests.Add(_guest);
                NavigationService.Navigate(new OrderDetailPage(_guest, _room));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.MainPage);
        }
    }
}
