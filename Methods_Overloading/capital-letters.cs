namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello World! Write codes.";
            CapitalLetters(msg);
        }

        static void CapitalLetters(string txt)
        {
            Console.Write(txt[0] + " ");
            for (int i = 1; i < txt.Length; i++)
            {
                if (txt[i - 1] == ' ') Console.Write(txt[i] + " ");
            }
        }
    }
}
