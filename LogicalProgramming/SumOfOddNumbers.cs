using System;
namespace ConsoleApplication
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value a Number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            //start with 1
            //1+2 = 3
            //3+2 = 5
            for (int i = 1; i <= Number; i += 2)
            {
                sum += i;
            }
            Console.Write($"Sum of Odd numbers from 1 to {Number} is : {sum}");
            Console.ReadLine();
        }
    }
}
