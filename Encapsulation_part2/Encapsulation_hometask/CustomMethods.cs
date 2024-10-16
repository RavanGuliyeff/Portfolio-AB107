//1.String-in "LastIndexOf(),Contains(),Replace(),Substring(),Trim()"
//methodlarını custom şəkildə yazmaq

using System.Text;

namespace Encapsulation_hometask
{
    internal class CustomMethods
    {
        public static int CustomLastIndexOf(string s, char value)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool CustomContains(string s, char value)
        {
            foreach (char c in s)
            {
                if (c == value) return true;
            }
            return false;
        }
        public static bool CustomContains(string s, string value)
        {

            if (value.Length == 0) return true;

            if (s.Length < value.Length) return false;

            bool found;
            for (int i = 0; i <= s.Length - value.Length; i++)
            {
                if (s[i] == value[0])
                {
                    found = true;
                    for (int j = 1; j < value.Length; j++)
                    {
                        if (s[i + j] != value[j])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found) return true;
                }

            }
            return false;
        }



        public static string CustomReplace(string s, char value1, char value2)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in s)
            {
                if (c == value1) stringBuilder.Append(value2);
                else stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }
        public static string CustomReplace(string s, string value1, string value2)
        {
            if (s == "" || s == null) return s;
            if (value1 == "" || value1 == null)
            {
                Console.WriteLine("Old value can not be empty");
                return s;
            }
            StringBuilder stringBuilder = new StringBuilder();
            bool found;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == value1[0] && i <= s.Length - value1.Length)
                {
                    found = true;
                    for (int j = 1; j < value1.Length; j++)
                    {
                        if (s[i + j] != value1[j])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        if (value2.Length > 0)
                        {
                            for (int j = 0; j < value2.Length; j++)
                            {
                                stringBuilder.Append(value2[j]);
                            }
                        }
                        i += value1.Length - 1;
                    }
                    else stringBuilder.Append(s[i]);

                }
                else stringBuilder.Append(s[i]);
            }
            return stringBuilder.ToString();
        }

        public static string CustomSubstring(string s, int value)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = value; i < s.Length; i++)
            {
                stringBuilder.Append(s[i]);
            }
            return stringBuilder.ToString();

        }
        public static string CustomSubstring(string s, int value1, int value2)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = value1; i < value1 + value2; i++)
            {
                stringBuilder.Append(s[i]);
            }
            return stringBuilder.ToString();

        }


        public static string CustomTrim(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int minIndex = 0;
            int maxIndex = s.Length - 1;

            while (minIndex < maxIndex)
            {
                if (s[minIndex] == ' ') minIndex++;
                else if (s[maxIndex] == ' ') maxIndex--;
                else break;
            }
            for (int i = minIndex;  i <= maxIndex; i++)
            {
                stringBuilder.Append(s[i]);
            }
            return stringBuilder.ToString();
        }
        public static string CustomTrim(string s, char value)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int minIndex = 0;
            int maxIndex = s.Length - 1;

            while (minIndex < maxIndex)
            {
                if (s[minIndex] == value) minIndex++;
                else if (s[maxIndex] == value) maxIndex--;
                else break;
            }
            for (int i = minIndex;  i <= maxIndex; i++)
            {
                stringBuilder.Append(s[i]);
            }
            return stringBuilder.ToString();
        }

    }
}
