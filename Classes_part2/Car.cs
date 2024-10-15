namespace Classes_part2
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1m;
        public double Millage;
        public void Drive()
        {
            double.TryParse(Console.ReadLine(), out double m);

            if (m * FuelFor1m <= CurrentFuel)
            {
                Millage += m;
                CurrentFuel -= m * FuelFor1m;
            }
            else Console.WriteLine("Kifayet qeder benzin yoxdur\n");
        }
    }
}
