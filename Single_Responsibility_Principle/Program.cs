using System;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Criando o objeto
            var invoice = new Invoice { InvoiceNo = 1, Customer = "Austro", Date = DateTime.Now.Date, Description = "Boleto da Pós", Amount = 1000 };

            // Salando em uma classe especialista
            var invoiceRepository = new InvoiceRepository();
            invoiceRepository.Save(invoice);
            Console.ReadLine();
        }
    }
}