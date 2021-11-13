using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Number, sum = 0; ;
            Console.Write("Enter the Number : ");
             Number = int.Parse(Console.ReadLine());
            int remender;
            int temp = Number;
            while (temp != 0)
            {
                remender = temp % 10;
                int fact = IsFactorial(remender);
                temp = temp / 10;
                sum = sum + fact;
            }
            if (sum == Number)
            {
                Console.WriteLine(Number + " is a Strong Number");
            }
            else
            {
                Console.WriteLine(Number + " is not a Strong Number");
            }
            Console.ReadKey();
        }

        public static int IsFactorial(int number)
        {
            int fact = 1;
            for(int i=1;i<=number;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }

}
