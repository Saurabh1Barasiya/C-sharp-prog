using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Inheritance
{
    public class Parent
    {
        public Parent()
        {
           Console.WriteLine("I am Parent Constructor...");
        }
    }

    public class child : Parent
    {
        public child()
        {
            Console.WriteLine("I am Child Constructor...");
        }


        // Aesa C# autometic karta h 👇👇 vo base keyword ka use karta h.
        // agar parent me koi paramenter wala constructor nahi h to , 
        // child class ka constructor parent class ke constructor ko khud call kar dega.

        //public child() : base()
        //{
        //    {
        //        Console.WriteLine("I am Child Constructor...");
        //    }
        //}

        internal class Program
        {
            static void Main(string[] args)
            {
                // jab bhi inheritance hoga , to child class ka constructor khud parent classs ke default , bina parameter wale 
                // constructor ko call karega.

                // sabse pahle parent class ka constructor chalega
                // fir child wala constructor chalega.

                child child = new child();
                Console.ReadLine();
            }
        }
    }
}
