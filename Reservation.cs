using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelInClass
{
    internal class Reservation
    {
        public Room Room { get; set; }
        public Client Client { get; set; }
        public int Occupants { get; set; }
        public DateTime Date { get; set; }
        public bool isCurrent { get; set; }

        public Reservation(Room room, Client client, DateTime date)
        {
            Room = room;
            Client = client;
            Date = date;
        }
    }
}
