using static System.Reflection.Metadata.BlobBuilder;

namespace Classes_part2
{
    internal class Department
    {
        public int No;
        Employee[] Employees = { };
        public int EmployeeLimit;

        public void AddEmployee(Employee employee)
        {
            if (Employees.Length < EmployeeLimit)
            {
                Employee[] newEmployees = new Employee[Employees.Length + 1];
                for (int i = 0; i < Employees.Length; i++)
                {
                    newEmployees[i] = Employees[i];
                }
                newEmployees[^1] = employee;
                Employees = newEmployees;
            }
            else Console.WriteLine($"Isci limitinin kecilimesi sebebinden {employee.Name} {employee.Surname} departmente elave edile bilmedi\n");
        }

        public Employee GetEmployee()
        {
            string sID = Console.ReadLine();
            foreach (Employee emp in Employees)
            {
                if (emp.ID == sID)
                {
                    return emp;
                }
            }
            return null;
        }
        public void GetEmployeeInfo()
        {
            string sID = Console.ReadLine();
            foreach (Employee emp in Employees)
            {
                if (emp.ID == sID)
                {
                    Console.WriteLine($"Name: {emp.Name}\nSurname: {emp.Surname}\nAge: {emp.Age}\nDepartment number: {emp.DepartmentNo}\nSalary: {emp.Salary}\nID: {emp.ID}\n");
                    break;
                }
            }

        }
        public void GetAllEmployees()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"Name: {emp.Name}\nSurname: {emp.Surname}\nAge: {emp.Age}\nDepartment number: {emp.DepartmentNo}\nSalary: {emp.Salary}\nID: {emp.ID}\n");
            }
        }
        public void GetAllEmployeesBySalary()
        {
            Console.Write("Minimum emek haqqi: ");
            double.TryParse(Console.ReadLine(), out double minSalary);
            Console.Write("Maksimum emek haqqi: ");
            double.TryParse(Console.ReadLine(), out double maxSalary);
            foreach (Employee emp in Employees)
            {
                if (emp.Salary > minSalary && emp.Salary < maxSalary)
                    Console.WriteLine($"Name: {emp.Name}\nSurname: {emp.Surname}\nAge: {emp.Age}\nDepartment number: {emp.DepartmentNo}\nSalary: {emp.Salary}\nID: {emp.ID}\n");
            }
        }
        public void GetAllEmployeesByDepartmentNo()
        {
            int.TryParse(Console.ReadLine(), out int no);
            foreach (Employee emp in Employees)
            {
                if (emp.DepartmentNo == no)
                    Console.WriteLine($"Name: {emp.Name}\nSurname: {emp.Surname}\nAge: {emp.Age}\nDepartment number: {emp.DepartmentNo}\nSalary: {emp.Salary}\nID: {emp.ID}\n");
            }
        }

    }
}
