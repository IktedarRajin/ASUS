using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][]arr= new int[4][];

            arr[0] = new int[2] { 1, 2 };
            arr[1] = new int[3] { 1, 2, 3 };
            arr[2] = new int[5] { 1, 2, 3, 4, 5 };
            arr[3] = new int[1] { 1 };

            int row = 0;
            while (row < arr.Length)
                {
                    int col = 0;
                    while (col < arr[row].Length)
                    {
                        Console.Write("{0}",arr[row][col]);
                        col++;
                    }
                Console.WriteLine();
                row++;
                }
            Console.WriteLine();

        }
    }
}
