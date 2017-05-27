using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    [Serializable]
    public class Room
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

        public string PreviewPic { get; set; }

        public string Description { get; set; }

        public bool BreakfastIncl { get; set; }
        public bool WifiIncl { get; set; }
        public bool TvIncl { get; set; }
        public bool FridgeIncl { get; set; }
        public bool PhoneIncl { get; set; }
        public bool SafeIncl { get; set; }
        public bool AllIncl
        {
            get
            {
                if (BreakfastIncl && WifiIncl && TvIncl && FridgeIncl && PhoneIncl && SafeIncl)
                    return true;
                else
                    return false;
            }
        }
    }

    public enum Class
    {
        Comfort, Standart, Econom
    }
}
