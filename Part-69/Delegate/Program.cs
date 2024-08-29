using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    public delegate void Show();

    internal class Program
    {

        public static void Display()
        {
            Console.WriteLine("I am Display method...");
        }

        public static void Print()
        {
            Console.WriteLine("I am Print method...");
        }

        public static void Dikhao()
        {
            Console.WriteLine("I am Dikhao method...");
        }

        static void Main(string[] args)
        {
            Show obj = Display;
            obj += Print;

            // To isme Dikhao wale nahi chagea 
            // Display and print hi chalega.
            obj -= Dikhao;
            obj();

            Console.ReadLine();
        }
    }
}
