using Core.Helpers;
using Core.Helpers.Exceptions;


namespace Core.Models
{
    public static class AppDbContext
    {
        private static List<Hotel> _hotels = new List<Hotel>();


        public static void AddHotel()
        {
            try
            {
                string name = Helper.GetStringInput("Enter name:");
                foreach (Hotel h in _hotels)
                {
                    if (h.Name.ToLower() == name.ToLower()) throw new InvalidNameException("There cannot be 2 hotels with the same name");
                }
                Hotel hotel = new Hotel(name);
                _hotels.Add(hotel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

        }
        public static void AddHotel(params Hotel[] hotels)
        {
            foreach (Hotel hotel in hotels)
            {
                _hotels.Add(hotel);
            }
        }

        public static void RemoveHotel(string name)
        {
            foreach (Hotel hotel in _hotels)
            {
                if (hotel.Name == name) _hotels.Remove(hotel);
            }

        }

        public static void ShowHotels()
        {
            foreach (Hotel hotel in _hotels)
            {
                Console.WriteLine($"Id: {hotel.Id}\tName: {hotel.Name}");
            }
            Console.WriteLine();
        }

        public static Hotel GetHotel(string name)
        {
            foreach (Hotel hotel in _hotels)
            {
                if (hotel.Name.ToLower() == name.ToLower()) return hotel;
            }
            return null;
        }

    }
}
