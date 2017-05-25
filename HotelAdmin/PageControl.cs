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
        private static AboutRoomPage _aboutRoomPage = new AboutRoomPage();
        private static AddRoomPage _addRoomPage = new AddRoomPage();
        private static PaymentsPage _paymentsPage = new PaymentsPage();
        private static ReservePage _reservePage = new ReservePage();

        public static MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }

        public static LoginPage LoginPage
        {
            get
            {
                return _loginPage;
            }
        }

        public static AboutRoomPage AboutRoomPage
        {
            get
            {
                return _aboutRoomPage;
            }
        }

        public static AddRoomPage AddRoomPage
        {
            get
            {
                return _addRoomPage;
            }
        }

        public static PaymentsPage PaymentsPage
        {
            get
            {
                return _paymentsPage;
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
