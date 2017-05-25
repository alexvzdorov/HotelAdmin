using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    class Payment
    {
        public CardType CardType { get; set; }

        private string _cardNumber;
        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                Regex regex = new Regex(@"^(\d]){16}$");
                Match match = regex.Match(value);
                if (match.Success)
                    _cardNumber = value;
                else
                    throw new FormatException("Неправильный формат номера карты");
            }
        }

        private string _code;
        public string Code
        {
            get { return _code; }
            set
            {
                if (value.Length != 3 && !int.TryParse(value, out int i))
                    throw new FormatException("Неправильный формат кода карты (CVV)");
                _code = value;
            }
        }

        private int _tillMonth;
        public int TillMonth
        {
            get { return _tillMonth; }
            set
            {
                if (value < 1 || value > 12)
                    throw new FormatException("Неправельный формат месяца. Укажите значение от 1 до 12.");
                _tillMonth = value;
            }
        }

        private int _tillYear;
        public int TillYear
        {
            get { return _tillYear; }
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value < currentYear)
                    throw new ArgumentException("Значение не может быть меньше, чем значение текущего года - " + currentYear);
                if (value > currentYear + 10)
                    throw new ArgumentException("Значение не может быть больше, чем " + (currentYear + 10));
                _tillYear = value;
            }
        }

        private string _owner;

        public string Owner
        {
            get { return _owner; }
            set
            {
                _owner = value.ToUpper();
            }
        }
    }

    public enum CardType
    {
        Visa, Mastercard
    }
}
