using System;

namespace LeftRotateInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1,2,3,4,5};
            int size = input.Length;
            int temp;
            //left rotation
            for (int j=size-1;j>0;j--)
            {
                temp = input[size - 1];
                input[size - 1] = input[j - 1];
                input[j - 1] = temp;
            }
            foreach (int num in input)
            {
                Console.WriteLine("Array after left rotation :"+ num );
               
            }
            Console.ReadLine();
        }
    }
}
