using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_with_var_and_Dynamic
{
    internal class Program
    {
        //public static void fun(var s) { 

        //}


        public static void fun(dynamic s)
        {
            Console.WriteLine(s);
        }


        static void Main(string[] args)
        {
            // we can not use var as paramenter.
            // but we can use dynamic as parament.

            Program.fun("hello saurabh");
            Program.fun(true);
            Program.fun(100);
            Program.fun(DateTime.Now);
            Console.ReadLine(); 
        }
    }
}
