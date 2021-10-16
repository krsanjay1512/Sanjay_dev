using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] int2DArray = new int[2, 3];
            Console.Write("Enter 2D Array Element :");
            
            for (int i =0;i<2;i++)
            {
                for (int j=0;j<3;j++)
                {
                    int2DArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            int index = 0;
            int NoOfRows = int2DArray.GetLength(0);
            int NoOfColumns = int2DArray.GetLength(1);
            int[] int1DArray = new int[NoOfRows * NoOfColumns];
            for (int x=0;x<NoOfRows;x++)
            {
                for  (int y=0;y<NoOfColumns;y++)
                {
                    int1DArray[index] = int2DArray[x, y];
                    index++;
                }

            }
            Console.WriteLine("1D Array Element :");
            foreach (var data in int1DArray)
            {
                Console.Write(data+" ");
            }

            Console.ReadLine();
        }
    }

}
