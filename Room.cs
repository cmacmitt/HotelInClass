using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelInClass
{
    internal class Room
    {
        public string Number { get; set; }
        public int Capacity { get; set; }
        private List<Reservation> _Reservations { get; set; }

        public Room(string number, int capacity)
        {
            Number = number;
            Capacity = capacity;
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
