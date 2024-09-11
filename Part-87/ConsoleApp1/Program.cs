using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // A collection that follows the FIFO(First In First Out) principle.
        // You enqueue items at the end and dequeue from the front.

        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("two");
            q.Enqueue(3.0);
            q.Enqueue(55556.21453);
            q.Enqueue('5');


            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.ReadLine();
        }
    }
}
