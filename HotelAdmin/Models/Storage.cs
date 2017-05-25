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
        public List<Payment> Payments { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
