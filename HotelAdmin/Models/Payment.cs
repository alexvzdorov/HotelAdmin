using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Models
{
    class Payment
    {
        private CardType _cardType;

        public CardType CardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }

        private string _cardNumber;

        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        private int _code;

        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private int _tillMonth;

        public int TillMonth
        {
            get { return _tillMonth; }
            set { _tillMonth = value; }
        }

        private int _tillYear;

        public int TillYear
        {
            get { return _tillYear; }
            set { _tillYear = value; }
        }

        private string _owner;

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
    }

    public enum CardType
    {
        Visa, Mastercard
    }
}
