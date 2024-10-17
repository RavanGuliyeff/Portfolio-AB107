namespace Practise
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public int DepartmentNo;
        private double _salary;
        private static int _id;

        public int ID
        {
            get { return _id; }
            set 
            {
                ++_id;
            }
        }



        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if(value >= 0) _salary = value;
            }
        }

        public Employee(string name, string surname, byte age, int departmentNo, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
            
        }
    }
}