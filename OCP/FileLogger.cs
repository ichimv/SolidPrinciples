using System;
using System.IO;

namespace OCP
{
    class FileLogger
    {
        static private FileLogger singletonFileLogger;

        private FileLogger()
        {
        }

        public void HandleError(string errorMessage)
        {
            File.WriteAllText(@"D:\Error.txt", errorMessage);
            Console.WriteLine(errorMessage);
        }

        static public FileLogger Instance()
        {
            if (singletonFileLogger == null)
            {
                singletonFileLogger = new FileLogger();
            }

            return singletonFileLogger;
        }
    }
}
