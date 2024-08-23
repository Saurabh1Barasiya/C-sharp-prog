using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_method_overrding
{
    public class Parent
    {
        //public void print()
        //{
        //    Console.WriteLine("I m Parent Printing....");
        //}

        public virtual void print()
        {
            Console.WriteLine("I m Parent Printing....");
        }
    }

    public class Child : Parent
    { 
        //public new void print()
        //{
        //    Console.WriteLine("I m child priting...");
        //}
        
        public override void  print()
        {
            Console.WriteLine("I m child printing...");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // child class ka chalega.
            //Child child = new Child();
            
            //child.print();


            // abhi reference variable parent class ka h and object child class ka.
            // but overrrding me child class ki hi method call hogi,but method hiding me Parent class ki method call ho jati.
            Parent parent = new Child();
            parent.print();

            


            Console.ReadLine();
        }
    }
}
