using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //INotificationSender notification = new EmailSebder();
            INotificationSender notification = new SmsSenderAdapter();
            notification.SendNotification(1, new Notification() { Title = "Title", Body = "Body"});


            Console.ReadLine();
        }
    }
}
