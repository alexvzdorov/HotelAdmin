using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    class Reservation
    {
        private static int _counter = 1;
        public int ReserveNumber { get; private set; }

        public Room Room { get; private set; }

        public Guest Guest { get; private set; }

        public DateTime StartPeriod { get; private set; }

        public DateTime EndPeriod { get; private set; }

        public Status Status { get; private set; }

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
            ReserveNumber = _counter++;
        }
    }

    public enum Status
    {
        Prepared, Paid, Canceled
    }
}
