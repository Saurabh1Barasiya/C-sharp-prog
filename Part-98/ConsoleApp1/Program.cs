using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool PrimeOrNot(int num)
        {
            if (num == 0 && num == 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++) { 
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");
            int num = int.Parse(Console.ReadLine());
            if (Program.PrimeOrNot(num))
            {
                Console.WriteLine("Prime no..");
            }
            else
            {
                Console.WriteLine("Not a Prime no..");
            }

            Console.ReadLine();
        }
    }
}
