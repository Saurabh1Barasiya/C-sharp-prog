using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class_concept
{
    public partial class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }


        public void ShowData()
        {
            Console.WriteLine($"Firstame {Firstname}");
            Console.WriteLine($"Lastname {Lastname}");
            Console.WriteLine($"Age {Age}");
        }
    }
}
