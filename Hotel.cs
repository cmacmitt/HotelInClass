using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelInClass
{
    internal class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Room> _Rooms { get; set; }
        private List<Client> _Clients { get; set; }
        private List<Reservation> _Reservations { get; set; }

        public Hotel(string name, string address)
        {
            Name = name;
            Address = address;
            _Rooms = new List<Room>();
            _Clients = new List<Client>();
            _Reservations = new List<Reservation>();
        }

        public void AddRoom(Room room)
        {
            _Rooms.Add(room);
        }

        public void AddClient(Client client)
        {
            _Clients.Add(client);
        }

        public void AddReservation(Room room, Client client, DateTime date)
        {
            Reservation newReservation = new Reservation(room, client, date);
            _Reservations.Add(newReservation);
            client.AddReservation(newReservation);
            room.AddReservation(newReservation);
        }

        public void PrintReservations()
        {
            foreach (Reservation reservation in _Reservations)
            {
                Console.WriteLine(reservation.GetClientName());
            }
        }

        private Client FindClientByName(string name)
        {
            foreach (Client client in _Clients)
            {
                if (client.Name == name)
                {
                   return client;
                }
            }
            return null;
        }

        public void CheckIn(string name)
        {
            // check if the client exists
                // if they don't exist, create a new client
            // check if they have a reservation
                
            // check if the room has correct capacity for the 'party'
            // check if the room is occupied
            // if they don't have a reservation
                // do we have a room available
                // create a reservation for the room
            // check if the reservation is current   
        }

        public void CheckIn(int reservationId)
        {

        }
    }
}
