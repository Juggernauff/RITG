using System;
using System.IO;

namespace RITG.Task4
{
    internal class FileManager : IDisposable
    {
        private readonly string _filePath;
        public FileManager(string filePath)
        {
            _filePath = filePath;
        }
        public void FileRead()
        {
            string line = string.Empty;
            using (StreamReader reader = new StreamReader(_filePath))
            {
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }
        public void Dispose()
        {

        }
    }
}
