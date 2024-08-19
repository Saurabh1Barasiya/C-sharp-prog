using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_on_static_properties
{
    // can we get acces instance variable in static properties.

    public class Example
    {
        public string name;
        public static string _name
        {
            set {

                // aesa nahi kar sakte h kyoki name intance variable h.
                // _name 1  static property hai.
                name = value;
            }
            get {
                return name;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
