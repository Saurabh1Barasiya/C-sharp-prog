using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Inheritance
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("I am Parent class Constructor...");
        }
    }

    public class Child:Parent {

        // base() ye likhne ki need nahi h, but
        // agar parent me parameter wala constructor h to fir apko base() likhna padega...

        public Child() : base()
        { 
            Console.WriteLine("I am Child class Constructor...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            Console.ReadLine();
        }
    }
}
