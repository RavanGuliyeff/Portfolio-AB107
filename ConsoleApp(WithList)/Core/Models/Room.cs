using Core.Helpers.Exceptions;


namespace Core.Models
{
    public class Room
    {
        private static ushort _id;
        public readonly ushort Id;

        private string _name;

        private double _price;

        private byte _personCapacity;

        public bool isAvailable = true;


        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 2 && value.Length < 30) _name = value;
                else throw new InvalidNameException();
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0) _price = value;
                else throw new InvalidPriceException();
            }
        }

        public byte PersonCapacity
        {
            get { return _personCapacity; }
            set
            {
                if (value < 1) throw new InvalidCapacityException("Capacity must be at least 1");
                else _personCapacity = value;
            }
        }



        public Room(string name, double price, byte personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            Id = ++_id;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nPrice: {Price}\nCapacity: {PersonCapacity}\nRoom is {(isAvailable ? "" : "un")}available now!\n";
        }
    }
}
