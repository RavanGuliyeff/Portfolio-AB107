namespace Classes_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car()
            //{
            //    Brand = "BMW",
            //    Model = "M3",
            //    CurrentFuel = 10,
            //    FuelFor1m = 0.16,
            //    Millage = 52000
            //};
            //car.Drive();


            //Student student = new Student("Eli", "Mireli", "ab107", 73.4);

            //student.GetInfo();
            //student.CheckGraduation();
            //student.GetDiplomDegree();


            //Car2 car1 = new Car2()
            //{
            //    Brand = "BMW",
            //    Name = "F30",
            //    Speed = 230,
            //};

            //Car2 car2 = new Car2()
            //{
            //    Brand = "Porsche",
            //    Name = "Taycan",
            //    Speed = 280,
            //};

            //Gallery gallery1 = new Gallery()
            //{
            //    name = "Oba Gallery"
            //};
            //gallery1.AddCar(car1);
            //gallery1.AddCar(car2);

            //gallery1.ShowAllCars();

            //Book book1 = new Book()
            //{
            //    Name = "Rats and Humans",
            //    Price = 13.99
            //};

            //Book book2 = new Book()
            //{
            //    Name = "80,000 Hours",
            //    Price = 21.13
            //};

            //Library lib1 = new Library();
            //lib1.AddBook(book1);
            //lib1.AddBook(book2);
            //lib1.ShowAllBooks();
            //lib1.SearchBook();

            Department department1 = new Department()
            {
                No = 1,
                EmployeeLimit = 2
            };


            Employee employee1 = new Employee()
            {
                Name = "Rustam",
                Surname = "Aliyev",
                Age = 35,
                DepartmentNo = 1,
                Salary = 1450,
                ID = "1098236"
            };
            
            Employee employee2 = new Employee()
            {
                Name = "Eliabbas",
                Surname = "Ilhamov",
                Age = 60,
                DepartmentNo = 1,
                Salary = 1150,
                ID = "1062456"
            };

            Employee employee3 = new Employee()
            {
                Name = "Huseyn",
                Surname = "Akifli",
                Age = 43,
                DepartmentNo = 1,
                Salary = 1750,
                ID = "1053267"
            };
            
            department1.AddEmployee(employee1);
            department1.AddEmployee(employee2);
            department1.AddEmployee(employee3);

            //department1.GetEmployeeInfo();
            department1.GetAllEmployeesBySalary();

        }
    }
}