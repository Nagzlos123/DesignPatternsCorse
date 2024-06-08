using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class AuthenticationManager
    {
        private INotificationSender emailNotification;

        public AuthenticationManager(INotificationSender notificationSender)// dependency ingection using contraction
        {
            this.emailNotification = notificationSender;
        }
        public void Authenticate(User user, string email, string password)
        {
            if(user.Email == email && user.Password == password)
            {
                emailNotification.SendNotification(user);
            }
        }
    }
}
