using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        public static void fun()
        {
            Console.WriteLine("I am fun function...");
        }

        public static int fun2()
        {
            return 10;
        }

        public static int fun3(int a, int b) {
            int result = a + b;
            return result;
        }

        // we can not use var as a parameter 
        //public static string fun4(var name)
        //{

        //}

        public static void fun4(int a, string name)
        {
            Console.WriteLine($"{name}");
            Console.WriteLine(a);
        }

        public static void fun5(int age=10)
        {
            Console.WriteLine(age);
        }

        static void Main(string[] args)
        {
            Program.fun();

            int returnValue = Program.fun2();
            Console.WriteLine($"data {returnValue } ");

            int addtion = Program.fun3(10,10);
            Console.WriteLine($"Result : {addtion} ");

            //Program.fun4("aman", 4); // aese nahi de sakte error aayegi.

            // but ham named argument ka use kar sakte h.

            
            // Named argument..
            Program.fun4(name:"saurabh",a:10);
            Program.fun5(40);


            Console.ReadLine();
        }
    }
}
