namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Hyundai", "Elantra")
            {
                Mile = 76.991,
                DoorsNum = 4,
            };

            Motorcycle moto1 = new Motorcycle("Yamaha", "YZF-R15");


            car1.ShowFullInfo();

            moto1.ShowFullInfo();

        }
    }


    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }


    class Car : Vehicle
    {
        public int DoorsNum;

        public Car(string brand, string model) : base(brand, model)
        {

        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nMile: {Mile}\nDoor number: {DoorsNum}\n");
        }
    }


    class Motorcycle : Vehicle
    {
        public int WheelNum;

        public Motorcycle(string brand, string model) : base(brand, model)
        {

        }


        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nMile: {Mile}\nWheel number: {WheelNum}\n");
        }

    }

}
