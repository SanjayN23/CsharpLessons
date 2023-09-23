using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayThree
{
    internal interface MessageServices
    {
        void SendMessages(string message);
        void SendAudioMessages(string message);
        void SendVideoMessages(string message);
        void ReceiveMessages();
        void DeleteMessages();
    }
    internal interface Payments
    {
        void Makepayments(float amount);
    }

    internal class WhatsApp : MessageServices,Payments
    {
        public void DeleteMessages()
        {
            Console.WriteLine("It is not implements");
        }

        public void ReceiveMessages()
        {
            Console.WriteLine("It is not implements");
        }
        public void SendAudioMessages(string message)
        {
            Console.WriteLine("it is not implemented");                                        
        }
        public void SendMessages(string message) {
            Console.WriteLine("It is not implements");
            
        }
        public void SendVideoMessages(string message)
        {
            Console.WriteLine("It is not implements");
        }
        public void Makepayments(float amount)
        {
            Console.WriteLine($"Paid amount{amount}");
        }
    }

    public class MessageTester { 
    
        public static void TestOne()
    {
        WhatsApp messageServices = new WhatsApp();
        messageServices.SendMessages("hello");
        messageServices.ReceiveMessages();
            messageServices.Makepayments(1);
        
    }

    }
}
    
