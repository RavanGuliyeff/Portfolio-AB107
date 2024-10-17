using System.Globalization;

namespace Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee("Eli", "Qemzeli", 33, 1, 1250);
            //Employee emp2 = new Employee("Eli", "Qemzeli", 33, 1, 1250);
            //Console.WriteLine(emp2.ID);

            //Department department1 = new Department();
            //Department department2 = new Department();
            //Department department3 = new Department();

            //Console.WriteLine(department3.No);

            Console.WriteLine("Departmentdeki isci limitini daxil edin: ");
            int.TryParse(Console.ReadLine(), out int lim);
            Department department1 = new Department(lim);



            bool c = false;
            do
            {
            Console.WriteLine("1. Employee elave et\r\n2. İşci axtar\r\n3. Bütün işçilere bax\r\n4. Maaş aralığına görə işçileri axtarış et\r\n5. Departamente göre işçileri axtarış et\r\n0. Proqramı bitir\n");
            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        c = true;
                        break;
                    case "1":
                        Console.WriteLine("Ad daxil et: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Soyad daxil et: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("yas daxil et: ");
                        byte.TryParse(Console.ReadLine(), out byte age);
                        Console.WriteLine("Departament nomresi daxil et: ");
                        int.TryParse(Console.ReadLine(), out int depNo);
                        Console.WriteLine("maasi daxil et: ");
                        double.TryParse(Console.ReadLine(), out double salary);
                        Employee emp = new Employee(name, surname, age, depNo, salary);
                        department1.AddEmployee(emp);
                        break;

                    case "2":
                        department1.GetEmployeeInfo();
                        break;

                    case "3":
                        department1.GetAllEmployees();
                        break;

                    case "4":
                        department1.GetAllEmployeesBySalary();
                        break;

                    case "5":
                        department1.GetAllEmployeesByDepartmentNo();
                        break;

                    default:
                        break;
                }
            }
            while (!c);
        }
    }
}
