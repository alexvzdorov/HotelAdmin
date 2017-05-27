using HotelAdmin.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    class PageControl
    {
        private static MainPage _mainPage = new MainPage();
        private static LoginPage _loginPage = new LoginPage();
        //private static AboutRoomPage _aboutRoomPage = new AboutRoomPage();
        private static AddCardPage _addCardPage = new AddCardPage();
        private static ReservePage _reservePage = new ReservePage();
        //private static OrderDetailPage _orderDetailPage = new OrderDetailPage();
        private static AdminPage _adminPage = new AdminPage();
        private static RoomManagementPage _roomManagementPage = new RoomManagementPage();
        private static ReserveManagementPage _reserveManagementPage = new ReserveManagementPage();

        public static ReserveManagementPage ReserveManagementPage
        {
            get { return _reserveManagementPage; }
        }


        public static RoomManagementPage RoomManagementPage
        {
            get { return _roomManagementPage = new RoomManagementPage(); }
        }

        public static AdminPage AdminPage
        {
            get { return _adminPage; }

        }

        //public static OrderDetailPage OrderDetailPage
        //{
        //    get { return _orderDetailPage; }
        //}

        public static MainPage MainPage
        {
            get { return _mainPage; }
        }

        public static LoginPage LoginPage
        {
            get { return _loginPage; }
        }

        //public static AboutRoomPage AboutRoomPage
        //{
        //    get { return _aboutRoomPage; }
        //}

        public static AddCardPage AddCardPage
        {
            get
            {
                return _addCardPage;
            }
        }

        public static ReservePage ReservePage
        {
            get
            {
                return _reservePage;
            }
        }
    }
}
