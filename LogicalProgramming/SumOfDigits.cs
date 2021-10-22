using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 12306;
            int sum = 0;

            while (n>0)
            {
                sum = sum + n % 10;
                n=n / 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }

}
