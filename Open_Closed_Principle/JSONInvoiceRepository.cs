using System;

namespace Open_Closed_Principle
{
    internal class JSONInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} how file JSON.");
        }
    }
}