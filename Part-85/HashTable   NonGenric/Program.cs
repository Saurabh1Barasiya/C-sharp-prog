using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HashTable___NonGenric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hashtable also comes from System.Collections namespace.

            // hashtable contains key,value pair.

            // Hashtable is a data structure that stores data in key - value format.
            // The stored data is neither in sorted order nor preserves the insertion order.


            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "one");
            hashtable.Add(2, "two");
            hashtable.Add(3, "three");

            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"key is {key} and value is {hashtable[key]}");
            }

            Console.WriteLine(hashtable.Count); // 3



            // getting only keys.
            Console.WriteLine("getting only keys");
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"key is {key} ");
            }



            // getting only Value.
            Console.WriteLine("getting only Value");
            foreach (object val in hashtable.Values)
            {
                Console.WriteLine($"Value is {val} ");
            }


            Console.WriteLine(hashtable.GetType());  // System.Collections.Hashtable



            Console.WriteLine(hashtable.Contains(1)); // True
            Console.WriteLine(hashtable.Contains(10)); // False




            Console.WriteLine(hashtable.ContainsKey(1));  // True
            Console.WriteLine(hashtable.ContainsKey(10)); // False


            Console.WriteLine(hashtable.ContainsValue("one"));  // True
            Console.WriteLine(hashtable.ContainsValue("Ten")); // False

            hashtable.Remove(1);
            Console.WriteLine("Removing key 1");

            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"key is {key} and value is {hashtable[key]}");
            }


            Console.WriteLine("Clear the hashtable");
            hashtable.Clear();
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"key is {key} and value is {hashtable[key]}");
            }

            Console.ReadLine();
        }
    }
}
