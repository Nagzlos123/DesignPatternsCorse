using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var requestContext = new RequestContext()
            {
                Reqest = new Reqest()
                {
                    EntityId = 51,
                    UserId = 31,
                    UserRole = "Admin"
                },
                Response = new Response()

               
            };

            var resultHandler = new ResultHandler(null);
            var validationHandler = new ValidationHandler(resultHandler);
            var authorizationHandler = new AuthorizationHandler(validationHandler);

            authorizationHandler.Handler(requestContext);

            Console.WriteLine($"IsSuccessful: {requestContext.Response.IsSuccessful}");
            Console.WriteLine($"Message: {requestContext.Response.Message}");
            Console.WriteLine($"Data: {requestContext.Response.Data}");

            Console.ReadLine();
        }
    }
}
