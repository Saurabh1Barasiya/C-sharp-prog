using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_sealed_class
{


    // In typical object-oriented design, if you want to allow some inheritance but prevent further inheritance at a certain level,
    // sealing a "middle" class (a class between the base and most derived classes) can make sense.

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


    // BaseClass: This is open for inheritance, allowing derived classes to extend its functionality.
    // MiddleClass: This class is sealed, meaning no further inheritance is possible beyond this point.It provides a final, specific implementation that you don't want to be overridden or extended.


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
