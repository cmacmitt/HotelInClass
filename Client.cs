using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelInClass
{
    internal class Client
    {
        public string Name { get; set; }
        private long CreditCard { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Client(string name, long creditCard)
        {
            Name = name;
            CreditCard = creditCard;
            Reservations = new List<Reservation>();
        }


    }
}
