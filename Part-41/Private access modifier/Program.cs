using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_access_modifier
{
    class Example
    {
        private string name="saurabh";

        private void explain()
        {
            Console.WriteLine("Private members cannot be accessable outside from class.");
        }

        public void CallPrivatemember()
        {
            Console.WriteLine($"Accessing private variable : {name}");
        }
    }

    class Test : Example
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example();

            // access nahi kar sakte hai.

            //obj.name;

            //obj.explain()

            obj.CallPrivatemember();


            // try to access private member from parent class.
            Test test = new Test();
            
            // private member inherite nahi hote h. inheritance me.
            // test.name;

            Console.ReadLine();
        }
    }
}
