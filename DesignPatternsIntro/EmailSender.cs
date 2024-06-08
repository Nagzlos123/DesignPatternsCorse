using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    public class EmailSender
    {
        private void ConnectToSmtpServer()
        {
            Console.WriteLine("Connecting to smpt server");
        }

        private void InsertCredentials()
        {
            Console.WriteLine("Inseting credentials");
        }

        public void SendEmail(string to, string title, string body)
        {
            ConnectToSmtpServer();
            InsertCredentials();
            Console.WriteLine($"Sending email to {to}, {title}, {body}");
            Disconnect();
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from server");
        }
    }
}
