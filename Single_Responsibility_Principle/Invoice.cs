using System;

namespace Single_Responsibility_Principle
{   /// <summary>
    /// Responsabilidade de criar a entidades
    /// </summary>
    internal class Invoice
    {
        public int InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}