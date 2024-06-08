using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class AuthorizationHandler : BaseHandler
    {
        private Dictionary<int, int> entityOwners = new Dictionary<int, int>()
        {
            {50, 31 },
            {51, 32 }
        };
        public AuthorizationHandler(IHandler next) : base(next)
        {

        }

        public override void Handler(RequestContext requestContext)
        {
            Console.WriteLine("AuthorizationHandler");
            if (requestContext.Reqest.UserRole == "Admin")
            {
                _next.Handler(requestContext);
                return;
            }

            if (entityOwners.TryGetValue(requestContext.Reqest.EntityId, out int ownerId))// checking whether the element is in the dictionary
            {
                if (ownerId == requestContext.Reqest.UserId)
                {
                    _next.Handler(requestContext);
                    return;
                }
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "User is not authorized";
        }
    }
}
