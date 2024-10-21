namespace AbstractionTask
{
    internal class Student
    {
        static int idCounter;
        public readonly int ID = ++idCounter;

        public string FullName { get; set; }

        public int Point { get; set; }

        public Student(string fullName, int point)
        {
            FullName = fullName;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Student's full name: {FullName}\nPoint: {Point}\nID: {ID}\n\n");
        }

    }
}
