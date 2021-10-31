using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("Enter Number :");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n>0)
            {
                n = n / 10;
                count++;    
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }

}
