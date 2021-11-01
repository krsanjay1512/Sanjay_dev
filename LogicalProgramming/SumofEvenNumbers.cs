using System;
namespace DotNetTutorials
{
    class SumOfEvenNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value a Number:");
            int Number = Convert.ToInt32(Console.ReadLine());

            //start with 2
            //2+2 = 4
            //4+2 = 6
            for (int i = 2; i <= Number; i += 2)
            {
                sum += i;
            }
            Console.Write($"Sum of even numbers from 1 to {Number} is : {sum}");
            Console.ReadLine();
        }
    }
}
