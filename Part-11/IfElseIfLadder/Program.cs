using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your percent");
            int precent = int.Parse(Console.ReadLine());

            if (precent >= 85) {
                Console.WriteLine("Great");
            }
            else if (precent >= 75)
            {
                Console.WriteLine("Best");
            }
            else if(precent >= 60)
            {
                Console.WriteLine("Good");
            }else if(precent >= 45)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("focus on your study.");
            }
            Console.ReadLine();

        }
    }
}
