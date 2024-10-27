using Core.Helpers;
using Core.Helpers.Exceptions;


namespace Core.Models
{
    public class Hotel
    {
        private static int _id;
        public readonly int Id;

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 2 && value.Length < 50) _name = value;
                else throw new InvalidNameException();
            }
        }

        private List<Room> _rooms = new List<Room>();



        public Hotel(string name)
        {
            Name = name;
            Id = ++_id;
        }


        public void AddRoom()
        {
            try
            {
                string name = Helper.GetStringInput("Enter name: ");
                double price = Helper.GetDoubleInput("Enter price: ");
                byte cap = (byte)Helper.GetDigitInput("Enter room capacity");

                Room room = new Room(name, price, cap);
                _rooms.Add(room);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddRoom(params Room[] rooms)
        {
            foreach (Room room in rooms)
            {
                _rooms.Add(room);
            }
        }


        public void RemoveRoom(ushort id)
        {
            foreach (Room room in _rooms)
            {
                if (room.Id == id)
                {
                    _rooms.Remove(room);
                    return;
                }
            }
        }

        public void ShowAllRooms()
        {
            foreach (Room room in _rooms)
            {
                Console.WriteLine(room);
            }
            Console.WriteLine();
        }

        public void FindRoomForId()
        {
            ushort id = (ushort)Helper.GetDigitInput("Enter Id: ");


            foreach (Room room in _rooms)
            {
                if (room.Id == id) Console.WriteLine(room);
            }
        }
        public void FindRoomForName()
        {
            string name = Helper.GetStringInput("Enter name: ");

            foreach (Room room in _rooms)
            {
                if (room.Name.ToLower().Contains(name.ToLower())) Console.WriteLine(room);
            }
        }
        public void FindAllRoomForPrice()
        {
            double minPrice = Helper.GetDoubleInput("Enter minimum price: ");
            double maxPrice = Helper.GetDoubleInput("Enter maximum price: ");

            foreach (Room room in _rooms)
            {
                if (room.Price >= minPrice && room.Price <= maxPrice)
                    Console.WriteLine(room);
            }
        }
        public void FindAllRoomForCapacity()
        {
            byte minCap = (byte)Helper.GetDigitInput("Enter minimum capacity: ");
            byte maxCap = (byte)Helper.GetDigitInput("Enter maximum capacity: ");


            foreach (Room room in _rooms)
            {
                if (room.PersonCapacity >= minCap && room.PersonCapacity <= maxCap)
                    Console.WriteLine(room);
            }


        }
        public void FindAllRoomForAvailability()
        {
            bool availability = Helper.GetBooleanInput("true/1 - for available or false/0 for unavailable: ");


            foreach (Room room in _rooms)
            {
                if (room.isAvailable == availability) Console.WriteLine(room);
            }

        }

        public void MakeReservation(int? roomId, int count)
        {
            try
            {
                foreach (Room room in _rooms)
                {
                    if (roomId == null) throw new NullReferenceException();
                    if (room.Id == roomId)
                    {
                        if (room.isAvailable)
                        {
                            if (room.PersonCapacity >= count)
                            {
                                room.isAvailable = false;
                                Console.WriteLine("Your request was recorded\n");
                                return;
                            }
                            else throw new InvalidCapacityException("Capacity is not enough\n");
                        }
                        throw new NotAvailableException();
                    }
                }
                Console.WriteLine("No room has been assigned with this id\b");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }

    }
}
