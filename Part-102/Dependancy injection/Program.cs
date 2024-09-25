using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_injection
{

    //   Key Concepts:
    //      Service: A class that provides functionality to other classes.
    //      Client: A class that consumes the services.
    //      Dependency: The service that the client depends on.
    //      IoC Container: A framework for managing dependency lifetimes and resolutions.


    //Constructor Injection(most common)
    //    Property Injection
    //    Method Injection


    public interface IMessageService
    {
        void SendMessage(string message);
    }


    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }


    // Client that depends on IMessageService
    public class Notification
    {
        private readonly IMessageService _messageService;

        // Dependency Injection through the constructor
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }



    // ham nortification class me EmailService ko use karna cah rahe h .
    // but ham EmailService ka object nahi banayege.
    // ham dependency injection ka use karege . or object recive karege Notification class me.


    internal class Program
    {
        static void Main(string[] args)
        {
            //IMessageService emailService = new EmailService();
            Notification notification = new Notification(new EmailService());

            notification.Notify("1 message recived...");

            Console.ReadLine();
        }
    }
}
