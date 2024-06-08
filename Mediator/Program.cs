using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Button submitButton = new Button();
            Checkbox clientType = new Checkbox();

            new RegisterClientView(clientType, submitButton);

            submitButton.Click();
            clientType.Select();

            Console.ReadLine();
        }
    }
}
