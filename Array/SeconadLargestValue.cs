using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {50,30,10,60,90,5 };

            int first = Int32.MinValue;
            int second = Int32.MinValue;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]>first)
                {
                    second = first;
                    first = arr[i];
                }
                else if(arr[i]>second)
                {
                    second = arr[i];
                    
                }
            }
            Console.WriteLine(first);
            Console.WriteLine( second);
            Console.ReadLine();
        }
    }

}
