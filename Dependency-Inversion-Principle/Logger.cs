namespace Dependency_Inversion_Principle
{
    /// <summary>
    /// Como a classe Logger recebe as interfaces no construtor, quando a logger é instanciada conseguimos ter acesso aos métodos
    /// implementados na base de dados, porque eles também implementam a interface.
    /// </summary>
    internal class Logger
    {
        private readonly IDataService _dataService;
        private readonly IFileService _fileService;

        public Logger(IDataService dataService) // Injeção de dependência por construtor, assim a classe Logger depende de uma abstração que é o IDataService, não tem o new,
        {
            _dataService = dataService;
        }

        public Logger(IFileService fileService)// Injeção de dependência por construtor, assim a classe Logger depende de uma abstração que é o IFileService, não tem o new
        {
            _fileService = fileService;
        }

        public void Log(string message)
        {
            _dataService.Save(message);
        }

        public void FileLog(string message)
        {
            _fileService.SaveFile(message);
        }

        public void InversaodeDependencianoMetodo(IFileService fileService)// Injeção de dependência por método
        {
            fileService.SaveFile("teste");
        }
    }
}