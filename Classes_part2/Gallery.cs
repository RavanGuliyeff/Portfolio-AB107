namespace Classes_part2
{
    internal class Gallery
    {
        public string name;
        Car2[] cars = {};

        public void AddCar(Car2 car)
        {
            Car2[] newCars = new Car2[cars.Length + 1];
            for (int i = 0; i < cars.Length; i++)
            {
                newCars[i] = cars[i];
            }
            newCars[^1] = car;
            cars = newCars;     
        }


        public void ShowAllCars()
        {
            foreach (Car2 car in cars)
            {
                Console.WriteLine($"Brand: {car.Brand}\nName: {car.Name}\nSpeed: {car.Speed}\n");
            }
        }

        public Car2[] GetAllCars()
        {
            return cars;
        }
    }

}
