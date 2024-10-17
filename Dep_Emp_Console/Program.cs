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


            int.TryParse(GetInput("Departmentdeki isci limitini daxil edin: "), out int lim);
            Department department1 = new Department(lim);



            bool c = false;
            do
            {
                Console.WriteLine("1. Employee elave et\n2. İşci axtar\n3. Bütün işçilere bax\n4. Maaş aralığına görə işçileri axtarış et\n5. Departamente göre işçileri axtarış et\n0. Proqramı bitir\n");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        c = true;
                        break;
                    case "1":
                        (string, string, byte, int, double) inf = NewEmployeeInfo();
                        Employee emp = new Employee(inf.Item1, inf.Item2, inf.Item3, inf.Item4, inf.Item5);
                        department1.AddEmployee(emp);
                        Console.WriteLine();
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


        public static (string, string, byte, int, double) NewEmployeeInfo()
        {
            string name = GetInput("Ad daxil et: ");
            string surname = GetInput("Soyad daxil et: ");
            byte.TryParse(GetInput("Yaş daxil et: "), out byte age);
            int.TryParse(GetInput("Departament nömresi daxil et: "), out int depNo);
            double.TryParse(GetInput("Maaşı daxil et: "), out double salary);

            return (name, surname, age, depNo, salary);

        }


        public static string GetInput(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }


    }
}
