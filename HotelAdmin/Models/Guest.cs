using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace HotelAdmin.Models
{
    class Guest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(value);
                if (match.Success)
                    _email = value;
                else
                    throw new FormatException("Неправильный формат email");
            }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                Regex regex = new Regex(@"^(\+){0,1}(\d]){11}$");
                Match match = regex.Match(value);
                if (match.Success)
                    _phone = value;
                else
                    throw new FormatException("Неправильный формат номера телефона");
                _phone = value;
            }
        }

        public Payment PaymentInfo { get; set; }

        private string _pass;

        public string Pass
        {
            get { return _pass; }
            set
            {
                MD5 md5 = MD5.Create();
                var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
                _pass = Convert.ToBase64String(hash);
            }
        }

    }
}
