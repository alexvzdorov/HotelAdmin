using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    [Serializable]
    public class Reservation
    {
        public int ReserveNumber { get; set; }

        public Room Room { get; set; }

        public Guest Guest { get; set; }

        public DateTime StartPeriod { get; set; }

        public DateTime EndPeriod { get; set; }

        public Status Status { get; set; }

        public Reservation(Room room, Guest guest, DateTime startPeriod, DateTime endPeriod, bool paid)
        {
            if (startPeriod < DateTime.Now)
                throw new ArgumentException("Период брони не может начаться раньше текущего времени");
            if (endPeriod < startPeriod)
                throw new ArgumentException("Конец периода брони не может быть раньше начала брони");
            if (room == null || guest == null)
                throw new ArgumentNullException();

            Room = room;
            Guest = guest;
            StartPeriod = startPeriod;
            EndPeriod = endPeriod;
            Status = paid ? Status.Paid : Status.Prepared;
            ReserveNumber = new Random().Next(1000000);
        }

        public Reservation()
        { }
    }

    public enum Status
    {
        Prepared, Paid, Canceled
    }
}
