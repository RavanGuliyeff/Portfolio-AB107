namespace Encapsulation
{
    internal class Student
    {
        public string name;
        public string surname;
        public Grade[] grades = { };

        public void AddGrade(Grade grade)
        {
            Grade[] newGrades = new Grade[grades.Length + 1];
            for (int i = 0; i < grades.Length; i++)
            {
                newGrades[i] = grades[i];
            }
            newGrades[^1] = grade;
            grades = newGrades;

        }

        public double GetAvgGrade()
        {
            double avg = 0;
            foreach (Grade grade in grades)
            {
                avg += grade.point;
            }

            return avg / grades.Length;
        }

        public int GetCreditCount()
        {
            int a = 0;
            foreach (Grade grade in grades)
            {
                a += grade.creditCount;
            }
            return a;
        }

    }
}
