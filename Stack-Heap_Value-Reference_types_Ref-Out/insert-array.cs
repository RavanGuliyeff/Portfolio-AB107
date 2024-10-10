//InsertArray methodu yaradılır.
//Method parametr olaraq int tipindən array və params olaraq int-lər qəbul edir.
//Paramslardan gələn dəyərləri həmin arraya əlavə etsin
//və sonda dəyişilmiş hal köhnə arraya bərabər olsun. 
//(Array resize istifade etmirsiz ozunuz Custom yazirsiz)

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            InsertArray(out arr, 1, 2, 3, 5, 2);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static void InsertArray(out int[] arr, params int[] arr2)
        {
            arr = arr2;
        }
    }
}
