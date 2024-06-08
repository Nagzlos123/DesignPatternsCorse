using System;

namespace DependencyInversionPrinciple
{
    internal class EmailNotification :INotificationSender
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending notification to user: {user.Name}");
        }
    }
}