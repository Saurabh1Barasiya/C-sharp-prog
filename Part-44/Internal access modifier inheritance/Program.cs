using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_access_modifier_inheritance
{
    public class Example
    {
        internal string name = "saurabh";

        internal void showData()
        {
            Console.WriteLine(name);
        }

    }

    public class Test : Example { }

    internal class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine(obj.name);

            obj.showData();

            Console.ReadLine();
        }
    }
}
