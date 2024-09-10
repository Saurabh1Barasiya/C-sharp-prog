using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_on_Genric
{
    public class Pair<Tkey, Tvalue>
    {
        private Tkey Key;
        private Tvalue Value;

        public Pair(Tkey key, Tvalue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public Tkey Getkey()
        {
            return Key;
        }

        public Tvalue Getvalue() {
            return  Value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> obj = new Pair<int, string>(1, "one");
            Console.WriteLine($"Key is {obj.Getkey()}");
            Console.WriteLine($"Value is {obj.Getvalue()}");

            Console.ReadLine();
        }
    }
}
