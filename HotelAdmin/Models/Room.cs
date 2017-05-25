using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    class Room
    {
        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private Class _class;
        public Class Class
        {
            get { return _class; }
            set { _class = value; }
        }

        private int _placeQty;
        public int PlaceQty
        {
            get { return _placeQty; }
            set { _placeQty = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }

    public enum Class
    {
        Comfort, Standart, Econom
    }
}
