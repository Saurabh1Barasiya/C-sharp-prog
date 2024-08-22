using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ___operator_overloding
{
    // In C#, the == operator is used to compare two objects for equality. By default, it compares object references (memory locations),
    // but you can overload this operator in your class or struct to compare the contents (or specific properties) of the objects instead.

    // jab overload karoge to public static ka use karna .

    // To overload the == operator, you need to define a static method in your class or struct using the operator keyword.
    // This method should return a bool indicating whether the two objects being compared are equal.


    // in C#, it is generally considered mandatory (though not enforced by the compiler) to overload the != operator when you overload the == operator.

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
            {
                return false;
            }

            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
            {
                return true;
            }

            return (p1.X == p2.X && p1.Y == p2.Y);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point obj1 = new Point(2, 3);
            Point obj2 = new Point(2, 3);

            Console.WriteLine(obj1 == obj2);
            Console.ReadLine();
        }
    }
}
