using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takingValueAndPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and age is {age}");

            Console.ReadLine();
        }
    }
}
