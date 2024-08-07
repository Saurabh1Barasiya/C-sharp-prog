using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace DateTime_format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Learn about date time format.



            //In C#, the DateTime structure is used to represent dates and times. Formatting DateTime values involves converting them to a string representation based on specific patterns or formats. You can format DateTime values using standard or custom format strings.

            // Standard Date and Time Format Strings
            // Standard format strings are single characters that represent a predefined pattern.Here are some common standard format strings:

            //"d": Short date pattern.
            //"D": Long date pattern.
            //"f": Full date/ time pattern(short time).
            //"F": Full date/ time pattern(long time).
            //"g": General date/ time pattern(short time).
            //"G": General date/ time pattern(long time).
            //"t": Short time pattern.
            //"T": Long time pattern.
            //"M" or "m": Month / day pattern.
            //"Y" or "y": Year month pattern.


            DateTime now = DateTime.Now;
            Console.WriteLine($"original data :- {now}");  //  8/7/2024 2:38:41 PM

            Console.WriteLine(now.ToString("d"));          // 8/7/2024
            Console.WriteLine(now.ToString("D"));          // Wednesday, August 7, 2024
            Console.WriteLine(now.ToString("f"));          // Wednesday, August 7, 2024 2:41 PM
            Console.WriteLine(now.ToString("F"));          // Wednesday, August 7, 2024 2:41:07 PM
            Console.WriteLine(now.ToString("g"));          // 8/7/2024 2:42 PM
            Console.WriteLine(now.ToString("G"));         //  8/7/2024 2:42:53 PM
            Console.WriteLine(now.ToString("t"));        //   2:42 PM
            Console.WriteLine(now.ToString("T"));       //    2:42:53 PM
            Console.WriteLine(now.ToString("M"));        //   August 7
            Console.WriteLine(now.ToString("Y"));       //    August 2024







            //Custom Date and Time Format Strings
            //Custom format strings allow you to define your own patterns for formatting DateTime values.Here are some common custom format specifiers:

            //"yyyy": Four - digit year.
            //"yy": Two - digit year.
            //"MMMM": Full month name.
            //"MMM": Abbreviated month name.
            //"MM": Two - digit month.
            //"M": Single - digit month.
            //"dddd": Full day of the week.
            //"ddd": Abbreviated day of the week.
            //"dd": Two - digit day.
            //"d": Single - digit day.
            //"HH": Two - digit hour(24 - hour clock).
            //"H": Single - digit hour(24 - hour clock).
            //"hh": Two - digit hour(12 - hour clock).
            //"h": Single - digit hour(12 - hour clock).
            //"mm": Two - digit minute.
            //"ss": Two - digit second.
            //"tt": AM / PM designator.



            DateTime now1 = DateTime.Now;

            Console.WriteLine(now1.ToString("yyyy")); //2024
            Console.WriteLine(now1.ToString("yyyy-MM-dd")); // Custom format: year-month-day
            Console.WriteLine(now1.ToString("dd/MM/yyyy")); // Custom format: day/month/year
            Console.WriteLine(now1.ToString("MMMM dd, yyyy")); // Custom format: full month name day, year
            Console.WriteLine(now1.ToString("ddd, dd MMM yyyy HH:mm:ss")); // Custom format: abbreviated day, day abbreviated month year hour:minute:second
            Console.WriteLine(now1.ToString("hh:mm tt")); // Custom format: hour:minute AM/PM
            Console.WriteLine(now1.ToString("HH:mm:ss")); // Custom format: hour:minute:second (24-hour clock)

            Console.ReadLine();

        }
    }
}
