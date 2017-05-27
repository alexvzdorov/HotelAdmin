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
    /// Interaction logic for ReservePage.xaml
    /// </summary>
    public partial class ReservePage : Page
    {
        private Room _room;
        public ReservePage()
        {
            InitializeComponent();
        }

        public ReservePage(Room room) : this()
        {
            _room = room;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var g = new Guest
                {
                    FirstName = textBoxName.Text,
                    Email = textBoxEmail.Text,
                    LastName = textBoxSurname.Text,
                    Pass = passBox.Password,
                    Phone = textBoxPhone.Text
                };
                NavigationService.Navigate(new AddCardPage(g, _room));
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
