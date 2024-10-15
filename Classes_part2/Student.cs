namespace Classes_part2
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public double Point;
        public bool isGraduated;

        public Student(string name, string surname, string group, double point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

            if (Point >= 65) isGraduated = true;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\n");
        }

        public void CheckGraduation()
        {
            string result = (isGraduated) ? "Telebe mezun olub\n" : "Telebe mezun olmayib\n";
            Console.WriteLine(result);
        }

        public void GetDiplomDegree()
        {
            switch (Point)
            {
                case < 65:
                    Console.WriteLine("Yoxdur\n");
                    break;
                case < 80:
                    Console.WriteLine("Adi\n");
                    break;
                case < 90:
                    Console.WriteLine("Seref\n");
                    break;
                default:
                    Console.WriteLine("Yuksek seref\n");
                    break;
            }
        }
    }
}
