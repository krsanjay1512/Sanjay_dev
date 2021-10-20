using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 12345;
            int sum = 0, r;
            while(n>0)
            {
                r = n % 10;
                sum = sum*10 + r;
                n = n / 10;
            }
            
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }

}
