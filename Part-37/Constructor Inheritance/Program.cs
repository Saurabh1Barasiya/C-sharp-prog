using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Inheritance
{
    public class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine($"I am Parent constructor...  {message}");
        }
    }

    public class child : Parent {
        public child() : base("ok") 
        {
            Console.WriteLine("I am child constructor...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            child obj = new child();
            Console.ReadLine();
        }
    }
}
