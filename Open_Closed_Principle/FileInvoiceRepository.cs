using System;

namespace Open_Closed_Principle
{
    internal class FileInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a file.");
        }
    }
}