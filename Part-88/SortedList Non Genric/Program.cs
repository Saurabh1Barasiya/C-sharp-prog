using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_Non_Genric
{
    internal class Program
    {
        // A collection of key-value pairs that are sorted by the key.
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(1, "one");
            sl.Add(2, "two");
            sl.Add(3, "three");


            Console.WriteLine(sl[1]);
            Console.WriteLine(sl[2]);
            Console.WriteLine(sl[3]);

            foreach (object key in sl.Keys)
            {
                Console.WriteLine($"{key} -- {sl[key]}");
            }

            Console.ReadLine();

        }
    }
}
