namespace Core.Helpers
{
    public static class Helper
    {
        public static string GetStringInput(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(input));
            Console.WriteLine();
            return input;
        }


        public static int GetDigitInput(string message)
        {
            int result;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (!int.TryParse(input, out result));
            Console.WriteLine();
            return result;
        }


        public static double GetDoubleInput(string message)
        {
            double result;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (!double.TryParse(input, out result));
            Console.WriteLine();
            return result;
        }

        public static bool GetBooleanInput(string message)
        {
            bool result;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (input.ToLower() != "true" && input.ToLower() != "false" && input != "1" && input != "0");
            if (input.ToLower() == "true" || input == "1") result = true;
            else result = false;

            Console.WriteLine();
            return result;
        }

    }
}
