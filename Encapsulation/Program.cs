namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grade grade1 = new Grade()
            //{
            //    subject = "Mathematic",
            //    point = 73,
            //    creditCount = 5
            //};
            //Grade grade2 = new Grade()
            //{
            //    subject = "Biology",
            //    point = 55,
            //    creditCount = 3
            //};
            //Grade grade3 = new Grade()
            //{
            //    subject = "Geography",
            //    point = 70,
            //    creditCount = 3;
           

            Gallery gallery1 = new Gallery();


            Car car1 = new Car("BMW", "F30")
            {
                Mile = 125000,
                DoorsNum = 4
            };

            Car car2 = new Car("Porsche", "Taycan")
            {
                Mile = 62000,
                DoorsNum = 4
            };

            //car.ShowFullInfo();

            gallery1.AddCar(car1);
            gallery1.AddCar(car2);
            gallery1.ShowCars();


        }
    }


}
