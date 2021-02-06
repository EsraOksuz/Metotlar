using System;

namespace OOP3
{
    class FileeLoggerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
