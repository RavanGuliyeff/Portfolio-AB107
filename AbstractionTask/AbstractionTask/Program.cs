namespace AbstractionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("ahmadov.samad32@mail.ru", "Samad2005")
            {
                FullName = "Samad Ahmadov",
            };
            User user2 = new User("salimovsarvan05@gmail.com", "Sarvan1234")
            {
                FullName = "Sarvan Salimov",
            };

            user1.ShowInfo();
            user2.ShowInfo();



            Student student1 = new Student("Akif Memmedov", 652);
            Student student2 = new Student("Nesir Veliyev", 478);

            student1.StudentInfo();
            student2.StudentInfo();


            Group group1 = new Group("AB107", 12);
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            Student student3 = group1.GetStudent(2);
            Console.WriteLine(student3.FullName);
            Student[] studentsArr = group1.GetAllStudents();
            foreach (Student student in studentsArr)
            {
                Console.WriteLine(student.FullName + "\n");
            }

        }
    }
}
