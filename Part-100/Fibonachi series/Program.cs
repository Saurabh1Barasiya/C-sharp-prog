using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -1; int b = 1;

            int temp;

            int terms = 10;

            for (int i = 0; i < terms; i++)
            {
                temp = a + b;
                Console.Write($" {temp} ");
                a = b;
                b = temp;
            }

            Console.ReadLine();

        }
    }
}
