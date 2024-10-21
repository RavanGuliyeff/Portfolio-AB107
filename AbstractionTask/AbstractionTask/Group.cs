namespace AbstractionTask
{
    internal class Group
    {
        string _groupNo;
        byte _studentLimit;

        public string GroupNo
        {
            get { return _groupNo; }
            set
            {
                if (CheckGroupNo(value)) _groupNo = value;
            }
        }

        public byte StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18) _studentLimit = value;
                else Console.WriteLine("Student limit must be between 5 and 18\n\n");
            }
        }

        Student[] students = new Student[0];


        public Group(string groupNo, byte studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

        public static bool CheckGroupNo(string noForCheck)
        {
            bool result = false;
            if (noForCheck.Length == 5)
            {
                if (char.IsUpper(noForCheck[0]) && char.IsUpper(noForCheck[1]))
                {
                    if (char.IsDigit(noForCheck[2]) && char.IsDigit(noForCheck[3]) && char.IsDigit(noForCheck[4])) result = true;
                    else Console.WriteLine("Last 3 characters must be digit\n\n");
                }
                else Console.WriteLine("First 2 characters must be capital letters\n\n");
            }
            else Console.WriteLine("Group no must have 5 symbols\n\n");
            return result;
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[^1] = student;
        }

        public Student GetStudent(int sID)
        {
            foreach (Student student in students)
            {
                if (student.ID == sID) return student;
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }
    }
}
