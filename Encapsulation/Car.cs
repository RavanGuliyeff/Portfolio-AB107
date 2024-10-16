namespace Encapsulation
{
    internal class Car : Vehicle
    {
        private int _doorsNum;

        public int DoorsNum
        {
            get
            {
                return _doorsNum;
            }
            set
            {
                if (value > 0 && value < 5) _doorsNum = value;
                else Console.WriteLine("0dan boyuk 5den kicik olmalidir\n");
            }
        }

        public Car(string brand, string model) : base(brand, model)
        {

        }


        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nMile: {Mile}\nDoors count: {DoorsNum}\n");
        }

    }
}
