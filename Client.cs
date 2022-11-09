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
        private List<Reservation> _Reservations { get; set; }

        public Client(string name, long creditCard)
        {
            Name = name;
            CreditCard = creditCard;
            _Reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation reservation)
        {
            _Reservations.Add(reservation);
        }

        public List<Reservation> GetReservations()
        {
            return _Reservations;
        }

    }
}
