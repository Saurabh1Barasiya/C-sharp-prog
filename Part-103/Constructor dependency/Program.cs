using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_dependency
{


    // problem statement
    // hamare paas 2 class h Nortifaction and EmailService.
    // We want Nortifaction class se EmailService ko acess kare without creating object of EmailService in Nortifaction class.
    // So here we use the concept of Dependancy Servicce...


    public interface Imessage
    {
        void SendMessage(string message);
    }


    public class EmailService : Imessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Nortifaction
    {
        Imessage _message;
        public Nortifaction(Imessage message)
        {
            this._message = message;
        }

        public void Send() {
            this._message.SendMessage("recived 1 nortification...");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Imessage obj = new EmailService();
            Nortifaction nor = new Nortifaction(obj);
            nor.Send();

            Console.ReadKey();
        }
    }
}
