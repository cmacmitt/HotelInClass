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
        public List<Reservation> Reservations { get; set; }

        public Room(string number, int capacity)
        {
            Number = number;
            Capacity = capacity;
            Reservations = new List<Reservation>();
        }
    }
}
