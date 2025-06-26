using System;

namespace Dependency_Inversion_Principle
{
    /// <summary>
    /// Camada de baixo nível
    /// </summary>
    internal class DataBeseService : IDataService
    {
        public void Save(string message)
        {
            Console.WriteLine("Save the message into the data base");
        }
    }
}