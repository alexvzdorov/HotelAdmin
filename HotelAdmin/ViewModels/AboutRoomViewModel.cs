using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.ViewModels
{
    class AboutRoomViewModel
    {
        public string Number { get; set; }
        public string PlaceQty { get; set; }
        public string Class { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public List<string> Pictures { get; set; }
    }
}
