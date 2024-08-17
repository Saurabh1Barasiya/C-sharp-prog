using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_modifier
{
    public class Example
    {
        public Example()
        {
            Console.WriteLine("I am constructor...");
        }

        public void explain()
        {
            Console.WriteLine("public members are accessible from anywhere...");
        }

        public void callAnotherFunction()
        {
            Example ob = new Example();
            ob.explain();
        }
    }

    public class Test : Example
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();

            // ham explain() ko use kar pa rahe h because ye public h.

            // or public members ko ham outside of class se use kar sakte h.

            // har jagah se ham public ko use kar sakte h.
            e.explain();

            // access from derived class.

            Test test = new Test();
            test.explain();

            test.callAnotherFunction();

            Console.ReadLine();
        }
    }
}
