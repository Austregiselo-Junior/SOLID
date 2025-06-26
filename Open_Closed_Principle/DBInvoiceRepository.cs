using System;

namespace Open_Closed_Principle
{
    internal class DBInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into the database.");
        }
    }
}