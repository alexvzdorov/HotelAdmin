using HotelAdmin.Models;
using HotelAdmin.Pages;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace HotelAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Storage Storage { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            //var s = new Storage
            //{
            //    Rooms = new List<Room>
            //    {
            //        new Room
            //        {
            //            Number = 1,
            //            Price = 1500,
            //            Class = Class.Comfort,
            //            PlaceQty = 1,
            //            PreviewPic = AppDomain.CurrentDomain.BaseDirectory + @"\Images\sample.jpg"
            //        },
            //        new Room
            //        {
            //            Number = 2,
            //            Price = 1800,
            //            Class = Class.Standart,
            //            PlaceQty = 2
            //        },
            //        new Room
            //        {
            //            Number = 3,
            //            Price = 1200,
            //            Class = Class.Econom,
            //            PlaceQty = 3
            //        }
            //    },
            //    Guests = new List<Guest>
            //    {
            //        new Guest
            //        {
            //            FirstName = "Max",
            //            LastName = "Petrov",
            //            Email = "max_petrov@mail.ru",
            //            Phone = "82345678901"
            //        },
            //        new Guest
            //        {
            //            FirstName = "Aleksey",
            //            LastName = "Vzdorov",
            //            Email = "aleksey_vzdorov@gmail.com",
            //            Phone = "+72345678901"
            //        }
            //    },
            //};
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Storage));
            // StreamWriter streamWriter = new StreamWriter("storage.xml");
            // xmlSerializer.Serialize(streamWriter, s); // myClassCollection - наши данные

            // streamWriter.Close();

            // десериализация
            //var xmlSerializer = new XmlSerializer(typeof(Storage));
            StreamReader sr = new StreamReader("storage.xml");
            Storage = (Storage)xmlSerializer.Deserialize(sr);
            sr.Close();

            frameMain.Navigate(new MainPage());
        }
    }
}
