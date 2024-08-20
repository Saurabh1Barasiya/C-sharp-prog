using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_overloding
{
    // return type does not metter inheritance.
    // public int show() and public string show()  both have diffrent return type 
    // but overloding me isse fark nahi padta, ham log only parameter list ke base par overloding karte hai.

    public class Example
    {
        public int Show()
        {
            return 100;
        }

        // error h ye.
        public string Show()
        {
            return "hello";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
