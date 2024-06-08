using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new InvoiceBuilder();

            Invoice invoice = builder.SetDate(new DateTime(2024, 1, 12))
                .SetInvoiceNumber("A1")
                .SetVendor("Google")
                .SetVendee("Vendee")
                .SetLineItems(new List<string>() { "Line item1", "Line item2" }) 
                .Build();// chain call

            Console.WriteLine(invoice.Vendor);
            Console.WriteLine(invoice.Vendee);

            Console.ReadLine();
        }
    }
}
