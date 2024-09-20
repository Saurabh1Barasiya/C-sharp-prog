using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_prime_range
{
    internal class Program
    {
        public static bool getPrimeRange(int num)
        {
            if (num <= 1)
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
            for (int i = 0; i < 20; i++) {
                if (Program.getPrimeRange(i))
                {
                    Console.WriteLine($"Prime number : {i} ");
                }
            }

            //Prime number : 2
            //Prime number : 3
            //Prime number : 5
            //Prime number : 7
            //Prime number : 11
            //Prime number : 13
            //Prime number : 17
            //Prime number : 19

            Console.ReadLine();
        }
    }
}
