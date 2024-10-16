using System.Reflection;

namespace Encapsulation
{
    internal class Gallery
    {

        Car[] cars = { };

        public void AddCar(Car car)
        {
            Car[] newCars = new Car[cars.Length + 1];

            for (int i = 0; i < cars.Length; i++)
            {
                newCars[i] = cars[i];
            }

            newCars[^1] = car;
            cars = newCars;

        }

        public void ShowCars()
        {
            foreach (Car car in cars)
            {
                car.ShowFullInfo();
            }
        }

        public void FilterCar(string brand)
        {
            foreach (Car car in cars)
            {
                if (car.Brand == brand) Console.WriteLine($"Brand: {car.Brand}\nModel: {car.Model}\nMile: {car.Mile}\nDoors count: {car.DoorsNum}\n");
            }

        }

        public void FilterCar(double mile)
        {
            foreach (Car car in cars)
            {
                if (car.Mile == mile) Console.WriteLine($"Brand: {car.Brand}\nModel: {car.Model}\nMile: {car.Mile}\nDoors count: {car.DoorsNum}\n");
            }
        }

    }
}
