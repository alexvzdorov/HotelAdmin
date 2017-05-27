using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HotelAdmin.Models
{
    [Serializable]
    public class Storage
    {
        public List<Guest> Guests { get; set; } = new List<Guest>();
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        public List<Payment> Payments { get; set; } = new List<Payment>();

        private static Storage _storage;
        public static Storage Instance
        {
            get
            {
                if (_storage == null)
                    _storage = new Storage();
                return _storage;
            }
            set { _storage = value; }
        }

        public static void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Storage));
            StreamWriter streamWriter = new StreamWriter("storage.xml");
            xmlSerializer.Serialize(streamWriter, Instance);

            streamWriter.Close();
        }

        public static void Load()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Storage));
                StreamReader sr = new StreamReader("storage.xml");
                Instance = (Storage)xmlSerializer.Deserialize(sr);
                sr.Close();
            }
            catch
            {
                Instance = new Storage
                {
                    Rooms = new List<Room>
                {
                    new Room
                    {
                        Number = 1,
                        Price = 1500,
                        Class = Class.Comfort,
                        PlaceQty = 1,
                        PreviewPic = @"..\..\Images\sample.jpg"
                    },
                    new Room
                    {
                        Number = 2,
                        Price = 1800,
                        Class = Class.Standart,
                        PlaceQty = 2
                    },
                    new Room
                    {
                        Number = 3,
                        Price = 1200,
                        Class = Class.Econom,
                        PlaceQty = 3
                    }
                },
                    Guests = new List<Guest>
                {
                    new Guest
                    {
                        FirstName = "Max",
                        LastName = "Petrov",
                        Email = "max_petrov@mail.ru",
                        Phone = "82345678901"
                    },
                    new Guest
                    {
                        FirstName = "Aleksey",
                        LastName = "Vzdorov",
                        Email = "aleksey_vzdorov@gmail.com",
                        Phone = "+72345678901"
                    }
                },
                };
                Save();
            }
        }

        public void AddReservation(Reservation r)
        {
            Instance.Reservations.Add(r);
        }
    }
}
