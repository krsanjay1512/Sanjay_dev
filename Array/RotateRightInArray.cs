using System;

namespace RotateRightInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1,2,3,4,5};
            int size = input.Length;
            int temp;

            for (int i=0;i<size-1;i++)
            {
                temp = input[0];
                input[0] = input[i + 1];
                input[i + 1] = temp;
            }
            foreach (int num in input)
            {
                Console.WriteLine("Array after right rotation :"+ num );
               
            }
            Console.ReadLine();
        }
    }
}
