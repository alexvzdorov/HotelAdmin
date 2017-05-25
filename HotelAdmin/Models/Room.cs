using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    class Room
    {
        public int Number { get; set; }

        public Class Class { get; set; }

        private int _placeQty;
        public int PlaceQty
        {
            get { return _placeQty; }
            set
            {
                if (value > 8 || value < 1)
                    throw new ArgumentException("Значение не может быть больше 8 или меньше 1");
                _placeQty = value;
            }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Значение не может быть меньше 0");
                _price = value;
            }
        }

        private List<string> _pictures;

        public IEnumerable<string> Pictures
        {
            get { return _pictures; }
        }

        public void AddPicture(string path)
        {
            _pictures.Add(path);
        }
    }

    public enum Class
    {
        Comfort, Standart, Econom
    }
}
