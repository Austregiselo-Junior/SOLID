using System;

namespace Single_Responsibility_Principle
{
    /// <summary>
    /// Essa classe tem a responsabilidade de simular um repositório
    /// </summary>
    internal class InvoiceRepository
    {
        public void Save(Invoice invoice) => Console.WriteLine($"Os dados foram salvos - {invoice.Description}, {invoice.Date} and {invoice.Customer} -");
    }
}