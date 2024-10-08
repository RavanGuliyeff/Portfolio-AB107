namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 15, 20, 5, 10, 12, 10, 3, 56, 43, 37 };
            Console.WriteLine(Min(ints));
        }

        static int Min(int[] arr)
        {
            int min = arr[0];
            foreach (int n in arr)
            {
                if (n < min) min = n;
            }

            return min;
        }
    }
}
