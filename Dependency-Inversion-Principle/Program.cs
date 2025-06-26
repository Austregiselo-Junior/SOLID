using System;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Salvando o arquivo em data base");
            var logger = new Logger(new DataBeseService());
            logger.Log("Hello");
            Console.ReadLine();

            Console.WriteLine("Salvando em arquivo");
            logger = new Logger(new FileService());// Inversão de dependência por construtor
            logger.FileLog("Hello in to file");
            Console.ReadLine();

            Console.WriteLine("Salvando em arquivo"); // Inversão de dependência por método
            logger.InversaodeDependencianoMetodo(new FileService());
            Console.ReadLine();

            // Para fazer a Injeção de Dependência, devemos configurar o serviço, deve haver um conteineiner que gerencie separadamente a criação de instâncias .
            // services.addTransient<FileService, Logger>();

            // No caso dos códigos acima não é uma injeção propriamente dita porque não tem um serviço como um conteiner configurado e controlando o fluxo de instâncias como no comentário acima
        }
    }
}