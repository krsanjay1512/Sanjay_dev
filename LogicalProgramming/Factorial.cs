using System;
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n =int.Parse( Console.ReadLine());
            int fact = 1;
           
            for (int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();

        }
    }

}
