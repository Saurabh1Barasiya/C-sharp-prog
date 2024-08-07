using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrimentTernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ++ 
            // --


            //Pre - increment(Prefix)
            //In pre-increment, the value of the variable is incremented before it is used in an expression. The syntax for pre - increment is ++variable.

            //Post - increment(Postfix)
            //In post - increment, the value of the variable is incremented after it is used in an expression.The syntax for post - increment is variable++.

            int x = 5;
            int y = ++x; // Pre-increment

            // x is incremented to 6 before assignment
            // y = 6
            // x = 6
            Console.WriteLine(x);
            Console.WriteLine(y);


            int x1 = 5;
            int y1 = x1++; // Post-increment

            // y1 = 5
            // x1 = incremented to 6 after assignment
            Console.WriteLine(x1);
            Console.WriteLine(y1);





            Console.WriteLine("---------------------------------------------------");
            int a = 5;
            int b = 10;
            int result;

            // Pre-increment example
            result = ++a + b;
            // a is incremented first (a becomes 6), then 6 + 10 = 16
            // result = 16
            // a = 6
            Console.WriteLine(a);

            // Post-increment example
            result = a++ + b;
            // a is used first (a is 6), then 6 + 10 = 16
            // a is incremented after the expression is evaluated (a becomes 7)
            // result = 16
            // a = 7
            Console.WriteLine(a);




            // ternary operator.

            // condition? valueIfTrue : valueIfFalse;

            bool flag = 20>10?true:false;
            Console.WriteLine(flag);



            Console.WriteLine(true?"ok":"thanks");
            Console.WriteLine(false?"ok":"thanks");


            Console.ReadLine();
        }
    }
}
