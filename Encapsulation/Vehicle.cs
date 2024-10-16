namespace Encapsulation
{
    internal class Vehicle
    {                         
        private string _brand;
        private string _model;
        private double _mile;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _brand = value;
                }
                else { Console.WriteLine("3den boyuk 30dan kicik olmalidir\n"); }

            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _model = value;
                }
                else { Console.WriteLine("3den boyuk 30dan kicik olmalidir\n"); }

            }

        }

        public double Mile
        {
            get
            {
                return _mile;
            }
            set
            {
                if (value >= 0)
                {
                    _mile = value;
                }
                else { Console.WriteLine("0dan boyuk olmalidir\n"); }

            }
        }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }



    }
}
