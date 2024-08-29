using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Indexer
{
    // An indexer in C# allows an object to be indexed in a similar way to an array.
    // This means you can access elements of an object using array-like syntax, without exposing the underlying data structure directly.
    // Indexers are commonly used to create classes that act like collections or arrays.


    // An indexer is declared using the this keyword, followed by a parameter list in square brackets.
    // The parameter list defines the type and number of indices you can use to access the elements.
    // Indexers are typically defined within a class or struct.

    public class Example
    {
        private int[] age = new int[3];
        // Indexer for the SampleCollection class

        public int this[int index]
        {
            set {
                if (index >= 0 &&  index < age.Length) { 
                    if(value >= 0)
                    {
                        age[index] = value;
                    }
                }
                else
                {
                    Console.WriteLine("Length Exeed...");
                }
            }
            get {
                return age[index];
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example();
            obj[0] = 20;
            obj[1] = 30;
            obj[2] = 40;
            obj[3] = 50;
            obj[4] = 50;
            obj[5] = 50;

            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj[3]);
            Console.WriteLine(obj[4]);
            Console.WriteLine(obj[5]);

            Console.ReadLine();
        }
    }
}
