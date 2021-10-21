using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {50,30,10,60,90,5 };
            int length=arr.Length;

            int maxValue = Int32.MinValue;
            int secondMaxValue = Int32.MinValue;
            for (int i=0;i<length;i++)
            {
                if (arr[i]>maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = arr[i];
                }
                else if(arr[i]>secondMaxValue && maxValue != arr[i])
                {
                    secondMaxValue = arr[i];
                    
                }
            }
            Console.WriteLine("First Largest number :"+maxValue);
            Console.WriteLine("Second Largest number :"+secondMaxValue);
            Console.ReadLine();
        }
    }

}
