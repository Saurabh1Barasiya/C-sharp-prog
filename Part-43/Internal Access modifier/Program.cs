using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Access_modifier
{
    public class Example
    {
        internal string name = "saurabh";
    }

    public class Test
    {
        internal int id = 100;
        internal int aaadhar = 1232456;
        internal void display()
        {
            // accessing internal variable.
            Console.WriteLine($"access internal data {id}");
        }
    }

    public class Child : Test
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example();
            Console.WriteLine(obj.name);


            // access data.
            Child obj2 = new Child();

            // access internal variable.
            Console.WriteLine(obj2.aaadhar);
            obj2.display();


            Console.ReadLine();
        }
    }
}
