using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Genric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Represents a collection of key - value pairs.
            //Each key must be unique, and you specify the type for both the keys(TKey) and the values(TValue).


            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(4, "Four");
            dict.Add(5, "Five");



            foreach (int key in dict.Keys)
            {
                Console.WriteLine($"Key is {key} and value is {dict[key]}");
            }



            Console.WriteLine("---------------------------------------------------------------");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine(stack.Pop());  // 4
            Console.WriteLine(stack.Pop());  // 3
            Console.WriteLine(stack.Pop());  // 2
            Console.WriteLine(stack.Pop());  // 1


            Console.WriteLine("---------------------------------------------------------------");



            Queue<string> q = new Queue<string>();
            q.Enqueue("banana");
            q.Enqueue("papaya");
            q.Enqueue("apple");
            q.Enqueue("strawberry");

            Console.WriteLine(q.Dequeue()); // banana
            Console.WriteLine(q.Dequeue()); // papaya
            Console.WriteLine(q.Dequeue()); // apple
            Console.WriteLine(q.Dequeue()); // strawberry

            Console.ReadLine();
        }
    }
}
