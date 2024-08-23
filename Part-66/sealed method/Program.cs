using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    // A sealed method in C# is a method in a derived class that overrides a method in its base class
    // but cannot be further overridden by any classes that derive from the derived class.
    // This is useful when you want to allow a method to be overridden only once, preventing any further changes to its implementation in the inheritance chain.

    // To declare a sealed method, you first need to have an override method in a derived class.
    // Then, you use the sealed keyword to prevent any further overriding in classes that might inherit from this derived class.

    public class Base
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass.");
        }
    }

    public class FirstChild : Base
    {
        public override sealed void DisplayMessage() {
            Console.WriteLine("Message from FirstChild class...");
        }
    }



    // ye error isiliye aa rahi h kyoki hamne FirstChild classs me DisplayMessage() ko sealed bana diya h.
    // to ab ham us method ko inherited nahi kar payege.

    public class SecondChild : FirstChild { 
        public override void DisplayMessage()
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            FirstChild obj = new FirstChild();
            obj.DisplayMessage();
            Console.ReadLine();
        }
    }



    // If you want to allow a method to be overridden but want to ensure that no further overrides occur,
    // you use a sealed method.This provides a balance between flexibility(allowing one override) and control(preventing further overrides).
}
