using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_non_genric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A collection that follows the LIFO(Last In First Out) principle.
            // You can push and pop elements.

            // it comes from System.Collections.

            Stack st = new Stack();
            st.Push(1);
            st.Push("two");
            st.Push(true);
            st.Push(45.203);


            Console.WriteLine(st.Count); // 4

            object rm1 = st.Pop();
            Console.WriteLine(rm1);  // 45.203

            Stack s1 = (Stack)st.Clone();
            Console.WriteLine(s1);
            s1.Push(500);

            Console.WriteLine(s1.Count); // 4
            Console.WriteLine(st.Count); // 3

            Console.ReadLine();

        }
    }
}
