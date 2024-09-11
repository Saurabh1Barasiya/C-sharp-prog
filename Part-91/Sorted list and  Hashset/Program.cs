using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_list_and__Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(10, "hello");
            sl.Add(11, "hi");
            sl.Add(12, "welcome");

            foreach (int key in sl.Keys)
            {
                Console.WriteLine($"{key} -- {sl[key]}");
            }


            Console.WriteLine("---------------------------------------------");

            //HashSet<int> hs = new HashSet<int>();
            HashSet<int> set = new HashSet<int>();
            set.Add(100);
            set.Add(200);
            set.Add(300);
            set.Add(400);
            set.Add(100);
            set.Add(400);

            // HashSet remove duplicate value.

            foreach (int data in set)
            {
                Console.WriteLine(data);   
            }

            

            Console.ReadLine();
        }
    }
}
