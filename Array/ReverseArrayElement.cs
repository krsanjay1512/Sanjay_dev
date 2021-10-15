using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int[] arr = { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };
           
            for (int i = arr.Length-1;i>=0; i--)
            {
                Console.Write(arr[i]+" ");

            }
        
            Console.ReadLine();
        }
    }

}
