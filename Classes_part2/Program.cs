namespace Classes_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Brand = "BMW",
                Model = "M3",
                CurrentFuel = 10,
                FuelFor1m = 0.16,
                Millage = 52000
            };
            car.Drive();


            Student student = new Student("Eli", "Mireli", "ab107", 73.4);

            student.GetInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();

        }
    }
}