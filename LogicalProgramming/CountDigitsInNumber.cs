using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 1234;
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
