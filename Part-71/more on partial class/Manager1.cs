using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_partial_class
{
    public partial class Manager : Employee
    {
        public string Department {  get; set; }

        public override void Showdata()
        {
            Console.WriteLine($"Employee: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Age: {Department}");
            Console.WriteLine($"Age: {Bonus}");
        }
    }
}
