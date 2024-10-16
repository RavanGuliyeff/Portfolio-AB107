namespace Encapsulation
{
    internal class Bicycle : Vehicle
    {
        private int _wheelNum;

        public int MyProperty
        {
            get
            {
                return _wheelNum;
            }
            set
            {
                if (value > 0 && value < 5) _wheelNum = value;
                else Console.WriteLine("0dan boyuk 5den kicik olmalidir\n");
            }
        }

        public Bicycle(string brand, string model) : base(brand, model)
        {
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nMile: {Mile}\nWheels count: {_wheelNum}");
        }

    }


}
