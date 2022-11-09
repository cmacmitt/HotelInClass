using HotelInClass;

Hotel myHotel = new Hotel("My Fleabag Hotel", "123 Paper Street");

Console.WriteLine(myHotel.Name);

Room rm1 = new Room("rm1", 4);
Room rm2 = new Room("rm2", 6);

myHotel.AddRoom(rm1);
myHotel.AddRoom(rm2);

Client bob = new Client("bob", 1234123412341234);
Client mary = new Client("mary", 1234123412341234);

myHotel.AddClient(bob);
myHotel.AddClient(mary);

myHotel.AddReservation(rm1, mary, DateTime.Now);
myHotel.AddReservation(rm2, bob, DateTime.Now);

myHotel.PrintReservations();