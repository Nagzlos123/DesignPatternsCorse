﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender;
        public void SendNotification(int userId, Notification notification)
        {
            string userPhoneNumber = null; // base on userId

            _smsSender.SendSms(userPhoneNumber, $"{notification.Title} {notification.Body}");
        }
    }
}
