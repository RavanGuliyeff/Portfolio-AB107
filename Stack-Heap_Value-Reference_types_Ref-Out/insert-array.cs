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
            int[] arr = { 4, 2, 6, 4, -1, 4, 0, -5 };
            InsertArray(ref arr, 1, 2, 3, 5, 2);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
        static void InsertArray(ref int[] arr, params int[] arr2)
        {
            int[] newArr = new int[arr.Length + arr2.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[arr.Length + i] = arr2[i];
            }

            arr = newArr;

        }
    }
}
