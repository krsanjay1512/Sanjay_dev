using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of row:");
            int row =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the number of column:");
            int column = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1D Array Element :");
            int[] OneDarrayelement = new int[row*column];
            for (int i=0;i<OneDarrayelement.Length;i++)
            {
                OneDarrayelement[i] = int.Parse(Console.ReadLine());
            }
            int index = 0;
            int[,] TwoDarrayelment = new int[row, column];
            for (int i=0;i<row;i++)
            {
                for (int j=0;j<column;j++)
                {
                    TwoDarrayelment[i, j] = OneDarrayelement[index];
                    index++;
                }
            }
            Console.WriteLine("Print 2D Array Element :");
            foreach (var item in TwoDarrayelment)
            {
                Console.Write(item+" ");
            }
           
            Console.ReadLine();

        }
    }

}
