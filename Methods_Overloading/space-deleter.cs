namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Remove spaces from this sentence.";
            Console.WriteLine(SpaceDeleter(msg));
        }

        static string SpaceDeleter(string txt)
        {
            string txt2 = "";
            foreach (char l in txt)
            {
                if (l != ' ') txt2 += l;
            }
            return txt2;
        }
    }
}
