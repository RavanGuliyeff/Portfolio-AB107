namespace Encapsulation_hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Run Forrest!";
            string text2 = "       First Rule  ";
            string text3 = "**********Echoes in eternity****";


            //Console.WriteLine(CustomMethods.CustomLastIndexOf(text, 'e'));

            //Console.WriteLine(CustomMethods.CustomContains(text, 'l'));
            //Console.WriteLine(CustomMethods.CustomContains(text, ""));
            //Console.WriteLine(CustomMethods.CustomContains(text, "esl"));
            //Console.WriteLine(CustomMethods.CustomContains(text, "est!"));

            //Console.WriteLine(CustomMethods.CustomReplace(text, 'n', 'l'));
            //Console.WriteLine(CustomMethods.CustomReplace(text, "Run", "Stop"));
            //Console.WriteLine(CustomMethods.CustomReplace("", "orre", "yaka"));
            //Console.WriteLine(CustomMethods.CustomReplace(text, " ", ""));

            //Console.WriteLine(CustomMethods.CustomSubstring(text, 5));
            //Console.WriteLine(CustomMethods.CustomSubstring(text, 5, 3));

            //Console.WriteLine(CustomMethods.CustomTrim(text2));
            //Console.WriteLine(CustomMethods.CustomTrim(text3, '*'));


            Person person1 = new Person("Ravanguliyev", 20, "0559590506");
            Person person2 = new Person("Ravan guliyev", 20, "0559590506");
            Person person3 = new Person("Ravan Guliyev", 20, "0559590506");

            Console.WriteLine(person1.FullName);
            Console.WriteLine(person2.FullName);
            Console.WriteLine(person3.FullName);

        }
    }
}
