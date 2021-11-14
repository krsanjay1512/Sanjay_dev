using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number :");
            int n = int.Parse(Console.ReadLine());
            for (int i=1;i<=n; i++)
            {
                if (n%i == 0)
                {
                    Console.WriteLine("Factor Of Number is: "+i);
                }
            }
            Console.ReadLine();
        }
    }

}
