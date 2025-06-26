using System;

namespace Dependency_Inversion_Principle
{
    /// <summary>
    /// Camada de baixo nível
    /// </summary>
    internal class FileService : IFileService
    {
        public void SaveFile(string message)
        {
            Console.WriteLine("Save in to file");
        }
    }
}