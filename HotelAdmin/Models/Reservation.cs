using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    class Reservation
    {
        public Room Room { get; private set; }

        public Guest Guest { get; private set; }

        private DateTime _startPeriod;
        public DateTime StartPeriod
        {
            get { return _startPeriod; }
        }

        private DateTime _endPeriod;
        public DateTime EndPeriod
        {
            get { return _endPeriod; }
        }

        public Status Status { get; set; }

        public Reservation(Room room, Guest guest, DateTime startPeriod, DateTime endPeriod)
        {
            if (_startPeriod < DateTime.Now)
                throw new ArgumentException("Период брони не может начаться раньше текущего времени");
            if (_endPeriod < _startPeriod)
                throw new ArgumentException("Конец периода брони не может быть раньше начала брони");
            if (room == null || guest == null)
                throw new ArgumentNullException();

            Room = room;
            Guest = guest;
            _startPeriod = startPeriod;
            _endPeriod = endPeriod;
        }
    }

    public enum Status
    {
        NotPaid, Paid
    }
}
