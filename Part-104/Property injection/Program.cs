using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_injection
{
    public interface ImessageService
    {
        void sendMessage(string message);
    }

    public class SMSService : ImessageService
    {
        public void sendMessage(string message)
        {
            Console.WriteLine($"1 {message} ...");
        }
    }

    public class Nortification
    {
        public ImessageService imessageService { set; get; }

        public void notify(string message)
        {
            if (imessageService != null)
            {
                imessageService.sendMessage(message);
            }
            else
            {
                Console.WriteLine("Some thing went wrong....");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ImessageService parent h jo child class ka reference store kar sakta h.
            ImessageService im = new SMSService();

            // Creating object of Nortification Class.
            Nortification nortification = new Nortification();

            // setting property .
            nortification.imessageService = im;

            // calling the function.
            nortification.notify("Message recived");
            Console.ReadLine();
        }
    }
}
