using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            int[] arr1 = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };
            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr1[j] == arr1[i])
                        break;
                }
                if (arr1.Length == j)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }

}
