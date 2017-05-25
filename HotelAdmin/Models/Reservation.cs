using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    class Reservation
    {
        private Room _room;
        public Room Room
        {
            get { return _room; }
            set { _room = value; }
        }

        private Guest _guest;
        public Guest Guest
        {
            get { return _guest; }
            set { _guest = value; }
        }

        private DateTime _startPeriod;
        public DateTime StartPeriod
        {
            get { return _startPeriod; }
            set { _startPeriod = value; }
        }

        private DateTime _endPeriod;
        public DateTime EndPeriod
        {
            get { return _endPeriod; }
            set { _endPeriod = value; }
        }

        private Status _status;
        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }

    public enum Status
    {
        NotPaid, Paid
    }
}
