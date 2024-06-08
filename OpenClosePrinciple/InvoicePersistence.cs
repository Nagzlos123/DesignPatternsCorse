using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class InvoicePersistence
    {
        private Invoice _invoice;
        private IInvoiceSaver _invoiceSaver;
        public InvoicePersistence(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void Save()
        {
            _invoiceSaver.Save(_invoice);
        }
    }
}
