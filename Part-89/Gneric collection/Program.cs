using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gneric_collection
{
    // In C#, generic collections are strongly-typed collections
    // that allow you to define the type of elements stored within the collection at compile-time,
    // thus ensuring type safety. These collections are part of the System.Collections.Generic namespace
    // and are commonly used due to their flexibility, performance, and type safety compared to non-generic collections.

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // similar type data hi rahega isme.

            foreach (int item in list)
            {
                Console.WriteLine(item);   
            }

            List<string> stringlist = new List<string>();
            stringlist.Add("One ");
            stringlist.Add("Two");
            stringlist.Add("Three ");
            stringlist.Add("Four ");
            stringlist.Add("Five ");


            foreach (string item in stringlist)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
