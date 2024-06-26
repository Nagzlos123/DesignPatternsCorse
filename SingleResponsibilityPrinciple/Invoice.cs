﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Invoice
    {
        public IEnumerable<LineItem> LineItems { get; set; }
        public string Vendor { get; set; }
        public string Vendee { get; set; }
        public float Total { get; set; }

        public Invoice(IEnumerable<LineItem> lineItems, string vedor, string vendee)
        {
            LineItems = lineItems;
            Vendor = vedor;
            Vendee = vendee;
            Total = this.CalculateTotal();
        }


        public float CalculateTotal()
        {
            float total = 0;

            foreach (var lineItem in LineItems)
            {
                total += lineItem.Price * lineItem.Count * (1 + lineItem.TaxRate);
            }

            return total;
        }
    }
}
