﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class SMSnotification : INotificationSender
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending SMS notification to user: {user.Name}");
        }
    }
}
