namespace Dependency_Inversion_Principle
{
    /// <summary>
    /// Essa é a camada de abstração
    /// </summary>
    internal interface IFileService
    {
        void SaveFile(string message);
    }
}