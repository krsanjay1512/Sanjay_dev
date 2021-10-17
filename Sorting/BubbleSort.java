using System;

namespace ConsoleApp
{
    public class BubbleSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length ; j++)
            {
                for (int i = j+1; i <= arr.Length-1 ; i++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
              Console.ReadLine();
        }
    }

}
