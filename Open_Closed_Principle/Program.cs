using System;

namespace Open_Closed_Principle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var invoice = new Invoice
            {
                InvoiceNo = 1,
                Customer = "John Doe",
                IssuedDate = DateTime.Now.Date,
                Description = "Website Design",
                Amount = 1000
            };

            // Da forma que tá em baixo só criamos uma variável do tipo da interface que as classes implementam, assim reutilizamos
            // código e só criamos uma variável.
            IInvoiceRepository repo;

            Console.WriteLine("Salvando em arquivo");
            repo = new FileInvoiceRepository();
            repo.Save(invoice);
            Console.ReadLine();

            Console.WriteLine("Salvando no DB");
            repo = new DBInvoiceRepository();
            repo.Save(invoice);
            Console.ReadLine();

            Console.WriteLine("Salvando como JSON");
            repo = new JSONInvoiceRepository();
            repo.Save(invoice);
            Console.ReadLine();

            // A grande questão é que como os três tipos de repositório implementam a interface, podemos apenas criar uma variável e
            // reutiliza-la fazendo com que ela ganhe a instancia de cada repositório. E para extender o comportamento fazemos uma nova classe
            // herdade de IInvoiceRepository e depois a estanciamos como acima. Assim estamos adicionando uma nova funcionalidade sem alterar nenhuma
            // já implementada.
        }
    }
}