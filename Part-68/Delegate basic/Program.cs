using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_basic
{

    // Example of multicast delegate...

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
            obj += Dikhao;
            obj.Invoke();
            Console.ReadLine();
        }
    }
}
