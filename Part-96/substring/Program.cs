using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    internal class Program
    {
        public static string GetSubString()
        {
            Console.WriteLine("Enter a string");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter start point");
            int startIndex = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter start point");
            int length = int.Parse(Console.ReadLine());


            if(startIndex >= 0 && (startIndex + length) <= inputString.Length)
            {
                return inputString.Substring(startIndex, length);
            }
            else
            {
                return "";
            }
        }

        static void Main(string[] args)
        {
            string substring = Program.GetSubString();
            Console.WriteLine(substring);
            Console.ReadLine();
        }
    }
}
