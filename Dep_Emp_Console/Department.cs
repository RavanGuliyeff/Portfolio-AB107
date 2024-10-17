namespace Practise
{
    internal class Department
    {
        private static int _counter;
        public int No { get; private set; }
        Employee[] Employees = { };
        public int EmployeeLimit;

        public Department(int employeeLimit)
        {
            EmployeeLimit = employeeLimit;
            _counter++;
            No = _counter;
        }

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
            int.TryParse(Console.ReadLine(), out int sID);
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
            Console.WriteLine("ID daxil edin: ");
            int.TryParse(Console.ReadLine(), out int sID);
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
            Console.WriteLine("Departament nomresi daxil et: ");
            int.TryParse(Console.ReadLine(), out int no);
            foreach (Employee emp in Employees)
            {
                if (emp.DepartmentNo == no)
                    Console.WriteLine($"Name: {emp.Name}\nSurname: {emp.Surname}\nAge: {emp.Age}\nDepartment number: {emp.DepartmentNo}\nSalary: {emp.Salary}\nID: {emp.ID}\n");
            }
        }

    }
}