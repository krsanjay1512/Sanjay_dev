using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n =Convert.ToInt32( Console.ReadLine());
            int count = 0;
            for (int i=1;i<=n;i++)
            {
                if (n%i ==0)
                {
                    count++;
                }
            }
            if (count==2)
            {
                Console.WriteLine("{0} is prime Number",n);
            }
            else
            {
                Console.WriteLine("{0} is Not Prime Number",n);
            }
            Console.ReadLine();

        }
    }

}
