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







            //if (condition1)
            //{
            //    // Code to execute if condition1 is true
            //}
            //else if (condition2)
            //{
            //    // Code to execute if condition2 is true
            //}
            //else if (condition3)
            //{
            //    // Code to execute if condition3 is true
            //}
            //else
            //{
            //    // Code to execute if none of the above conditions are true
            //}


        }
    }
}
