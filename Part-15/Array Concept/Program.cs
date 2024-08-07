using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, arrays are used to store multiple values of the same type.
            // They are a fundamental part of the language and provide a way to store a fixed-size sequential collection of elements.

            // 1-D .

            int[] numbers = new int[5]; 
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }


            int[] my_array = { 1, 2, 3 };

            foreach (int i in my_array)
            {
                Console.WriteLine(i);
            }


            //Multi - dimensional Arrays.
            int[,] array = new int[3, 4];
            Console.WriteLine($"Totel Size: {array.Length} "); // 12

            // how to accsess row and column.
            Console.WriteLine($"Row : {array.GetLength(0)}"); // 3
            Console.WriteLine($"Column : {array.GetLength(1)}"); // 4


            int[,] new_Array = new int[3, 4]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
            };

            int row = new_Array.GetLength(0);  // getting row.
            int col = new_Array.GetLength(1);  // gting col.

            Console.WriteLine("Printing 2-D Data : ");

            for (int i=0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write($"{new_Array[i, j]}  ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
