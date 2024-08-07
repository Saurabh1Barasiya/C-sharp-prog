using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged array");

            // aese hi create hota h Jagged array.
            int[][] array = new int[3][]
            {
               new int[] {1,2,3,4,5 },
               new int[] {6,7,8 },
               new int[] {10,11,12,13,14,15},
            };

            Console.WriteLine("Printing the array");

            for(int i=0;i<array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}  ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();


        }
    }
}
