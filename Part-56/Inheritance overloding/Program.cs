using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_overloding
{
    // Overloading by Order of Parameters.
    // parameter are same but arragement was diffrent.

    public class Example
    {
        public void show(int number,string message)
        {
            Console.WriteLine($"Number {number} and message {message} ");
        } 
        
        public void show(string message, int number)
        {
            Console.WriteLine($"message {message} and Number {number} ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            example.show(10, "I am first ");
            example.show(11, "I am secound");
            Console.ReadLine();
        }
    }
}
