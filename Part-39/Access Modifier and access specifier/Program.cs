using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_and_access_specifier
{


    // Access modifiers in C# define the visibility and accessibility of classes, methods, variables, and other members within your code.
    // They determine where these members can be accessed from within the application.

    // public

    // The public access modifier makes a member accessible from any other code in the same assembly or another assembly that references it.

    // private
    // The private access modifier restricts access to the containing class or struct. Members with private access cannot be accessed from outside the class.

    // Protected
    // The protected access modifier allows access to the containing class and any class derived from it.It is more restrictive than public but less restrictive than private.

    // Internal
    // The internal access modifier allows access to members from any class within the same assembly but not from another assembly.

    // Protected Internal
    // The protected internal access modifier allows access to members within the same assembly or from derived classes in another assembly.It’s a combination of protected and internal.


    // Private Protected
    // The private protected access modifier restricts access to members within the same class and derived classes within the same assembly.It’s a combination of private and protected.



    // classes are only either public or internal.

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
