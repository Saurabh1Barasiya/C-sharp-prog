using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("while loop");
            int j = 0;
            while (j < 10) {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("Do while loop");
            do
            {
               Console.WriteLine("I am running");
            } while (false);

            Console.ReadLine();
        }
    }
}
