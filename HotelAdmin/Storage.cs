using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    [Serializable]
    public class Storage
    {
        public List<Guest> Guests { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Payment> Payments { get; set; }

        private static Storage _storage;
        public static Storage Instance
        {
            get
            {
                if (_storage == null)
                    _storage = new Storage();
                return _storage;
            }
            set { _storage = value;}
        }
    }
}
