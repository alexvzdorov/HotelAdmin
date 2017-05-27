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
    /// Interaction logic for ReserveManagementPage.xaml
    /// </summary>
    public partial class ReserveManagementPage : Page
    {
        public ReserveManagementPage()
        {
            InitializeComponent();

            SetupDataGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.AdminPage);
        }

        private void SetupDataGrid()
        {
            dataGrid.ItemsSource = Storage.Instance.Reservations;
            dataGrid.CanUserSortColumns = true;
            dataGrid.CanUserResizeRows = true;
            dataGrid.CanUserDeleteRows = true;
            dataGrid.CanUserReorderColumns = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Storage.Save();
            MessageBox.Show("Успешно сохранено! Данные всегда сохраняются, когда вы закрываете приложение.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
