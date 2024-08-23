using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_sealed_class
{

    public class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Base class message.");
        }
    }

    public sealed class MiddleClass : BaseClass
    {
        public sealed override void DisplayMessage()
        {
            Console.WriteLine("Middle class specific message.");
        }
    }

    // Attempting to inherit from MiddleClass will result in an error.
    public class FurtherDerivedClass : MiddleClass
    {

    }



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
