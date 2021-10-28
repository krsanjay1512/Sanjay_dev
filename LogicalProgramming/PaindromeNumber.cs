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
            int r, sum = 0;
            int temp = n;
            while (n>0)
            {
                 r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
                    
            }
            if(temp==sum)
            Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not Palindrome Number");
            Console.ReadLine();

        }
    }

}
