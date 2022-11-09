using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelInClass
{
    internal class Reservation
    {
        private Room Room { get; set; }
        private Client Client { get; set; }
        private int Occupants { get; set; }
        private DateTime Date { get; set; }
        private bool isCurrent { get; set; }

        public Reservation(Room room, Client client, DateTime date, int occupants = 1)
        {
            Room = room;
            Client = client;
            Date = date;
            Occupants = occupants;
        }

        public string GetClientName()
        {
            return Client.Name;
        }
    }
}
